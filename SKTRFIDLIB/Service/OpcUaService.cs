using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using AIM.AutoId;
using SKTRFIDLIB.Model;
using UnifiedAutomation.UaBase;
using UnifiedAutomation.UaClient;

namespace SKTRFIDLIB.Service
{
    public class OpcUaService
    {
        #region Instance

        private static readonly Lazy<OpcUaService> Lazy = new Lazy<OpcUaService>(() => new OpcUaService());

        /// <summary>
        /// Singleton
        /// </summary>
        public static OpcUaService Instance => Lazy.Value;

        #endregion Instance

        #region Events

        public event DataChangeEventHandler DataChange;

        public delegate void DataChangeEventHandler(string dataName, DataValue dataValue);

        public event NewEventEventHandler NewEvent;

        public delegate void NewEventEventHandler(Reader reader, EventInfoArgs infoArgs, RfidTag tag);

        #endregion Events

        #region Member

        private Session _session;
        private Subscription _subscription;

        #endregion Member

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public OpcUaService()
        {
            try
            {
                // License.lic = File must exist as a embedded resource
                ApplicationLicenseManager.AddProcessLicenses(System.Reflection.Assembly.GetExecutingAssembly(), "SKTRFID.License.License.lic");

                // Create the certificate if it does not exist yet
                ApplicationInstanceBase.Default.AutoCreateCertificate = true;
                //ApplicationInstance.Default.Start();

            }
            catch (Exception e)
            {
                //    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.Error.WriteLine(e.Message);
            }
        }

        #endregion Constructor

        #region Functions

        #region Connect

        /// <summary>
        /// Creates a connection to the OPC server
        /// </summary>
        /// <param name="ip">IP from OPC-Server</param>
        /// <param name="port">Port from OPC-Server</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <exception cref="OpcUaServiceException">Error description, why no connection is established.</exception>
        public bool Connect(string ip, int port)
        {
            bool result = false;

            // Create a new session
            _session = new Session
            {
                UseDnsNameAndPortFromDiscoveryUrl = true,
                SessionTimeout = 60000 * 5,

            };

            try
            {
                // Connect to OPC server
                _session.Connect($"opc.tcp://{ip}:{port}", SecuritySelection.None);

                // Add encodeable object to the factory
                // Required in the functions "Scan" and "ScanStart" to convert result
                MessageContext context = new MessageContext();
                context.Factory.AddEncodeableType(typeof(RfidScanResult));

                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new OpcUaServiceException(e.Message, e);

            }

            return result;
        }

        /// <summary>
        /// Creates a connection to the OPC server (async)
        /// </summary>
        /// <param name="ip">IP from OPC-Server</param>
        /// <param name="port">Port from OPC-Server</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        public async Task<bool> ConnectAsync(string ip, int port)
        {
            bool result = false;
            await Task.Run(() =>
            {
                result = Connect(ip, port);
            });
            return result;
        }

        #endregion Connect

        #region Disconnect

        /// <summary>
        /// Close connection to the OPC Server
        /// </summary>
        public void Disconnect()
        {
            try
            {
                DeleteSubscriptions();
                _session?.Disconnect(SubscriptionCleanupPolicy.Delete, null);
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Close connection to the OPC Server (async)
        /// </summary>
        /// <returns></returns>
        public async Task DisconnectAsync()
        {
            await Task.Run(() =>
            {
                Disconnect();
            });
        }

        #endregion Disconnect

        #region GetAllReader

        /// <summary>
        /// Returns a list of found readers
        /// </summary>
        /// <returns>A list of found readers</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public ObservableCollection<Reader> GetAllReader()
        {
            var result = new ObservableCollection<Reader>();

            BrowseContext context = new BrowseContext
            {
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.References,
                IncludeSubtypes = true,
                MaxReferencesToReturn = 0,
            };

            List<ReferenceDescription> references;
            try
            {
                references = _session.Browse(
                    new NodeId(5001, 2),
                    context,
                    new RequestSettings() { OperationTimeout = 10000 },
                    out byte[] continuationPoint);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            foreach (ReferenceDescription reference in references)
            {
                if (_session.Cache.GetDisplayText(reference.TypeDefinition) == AIM.AutoId.BrowseNames.RfidReaderDeviceType)
                {
                    var nodeId = reference.NodeId.ToNodeId(_session.NamespaceUris);

                    string typeName = "";
                    string readerName = "-";
                    var propertiesList = GetReaderProperties(new Reader(nodeId, "", "", ""));

                    foreach (var property in propertiesList)
                    {
                        if (property.Name == "DeviceInfo")
                        {
                            typeName = property.Value;
                        }
                        else if (property.Name == "DeviceName")
                        {
                            readerName = property.Value;
                        }
                    }

                    result.Add(new Reader(nodeId, reference.DisplayName.Text, typeName, readerName));
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a list of found readers (async)
        /// </summary>
        /// <returns>A list of found readers</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<ObservableCollection<Reader>> GetAllReaderAsync()
        {
            ObservableCollection<Reader> result = new ObservableCollection<Reader>();

            await Task.Run(() =>
            {
                result = GetAllReader();
            });

            return result;
        }

        #endregion GetAllReader

        #region GetReaderBusConfiguration

        /// <summary>
        /// Returns a list of found readers
        /// </summary>
        /// <returns>A list of found readers</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public NodeId GetReaderBusConfiguration()
        {
            return GetNodeId("Bus_Configuration");
        }

        /// <summary>
        /// Returns a list of found readers (async)
        /// </summary>
        /// <returns>A list of found readers</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<ObservableCollection<Reader>> GetReaderBusConfigurationAsync()
        {
            ObservableCollection<Reader> result = new ObservableCollection<Reader>();

            await Task.Run(() =>
            {
                result = GetAllReader(); //TODO
            });

            return result;
        }

        #endregion GetReaderBusConfiguration

        #region Scan

        /// <summary>
        /// Calls the "Scan" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataAviarible">Stop scanning when tag found</param>
        /// <param name="status">Return the status</param>
        /// <returns>A list of RfidTags</returns>
        /// <remarks>Timeout: In 10 seconds</remarks>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public OpcUaServiceScanResult Scan(Reader reader, bool dataAviarible, out OpcUaStatusCode status)
        {
            var settings = new ScanSettings
            {
                DataAvailable = dataAviarible
            };
            List<Variant> inputArguments = new List<Variant>
            {
                new ExtensionObject(settings)
            };

            StatusCode statusCode;
            List<Variant> outputArguments;
            //LoopScan:
            try
            {
                statusCode = _session.Call(
                reader.NodeId, //Ident 0 //NodeId.Parse("ns=3;i=5024")
                GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.Scan), //Scan method
                inputArguments,
                new RequestSettings() { OperationTimeout = 600000 },
                out List<StatusCode> inputArgumentErrors,
                out outputArguments);
            }
            catch(Exception e)
            {             
                //goto LoopScan;
                throw new OpcUaServiceException(e.Message, e);
            }

            var tags = new ObservableCollection<RfidTag>();

            if (StatusCode.IsBad(statusCode))
            {
                //goto LoopScan;
                throw new OpcUaServiceException(statusCode.GetCodeName());
            }

            if (StatusCode.IsGood(statusCode))
            {
                var extensionObjects = outputArguments[0].ToExtensionObjectArray();
                foreach (var extensionObject in extensionObjects)
                {
                    var rfidScanResult = ExtensionObject.GetObject<RfidScanResult>(extensionObject);
                    var sightings = new ObservableCollection<Sighting>();

                    foreach (var sigthingElement in rfidScanResult.Sighting)
                    {
                        sightings.Add(new Sighting(sigthingElement.Antenna, sigthingElement.Strength, sigthingElement.Timestamp, sigthingElement.CurrentPowerLevel));
                    }

                    var tag = new RfidTag(rfidScanResult.ScanData.ByteString, rfidScanResult.Timestamp, rfidScanResult.CodeType, sightings);

                    tags.Add(tag);
                }
            }

            var statusString = Enum.GetName(typeof(AutoIdOperationStatusEnumeration), (int)outputArguments[1].Value);

            status = new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
            return new OpcUaServiceScanResult(tags, statusString);
        }

        /// <summary>
        /// Calls the "Scan" method from the reader (async)
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataAviarible">Stop scanning when tag found</param>
        /// <returns>A list of RfidTags and a status</returns>
        /// <remarks>Timeout: In 10 seconds</remarks>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<Tuple<OpcUaServiceScanResult, OpcUaStatusCode>> ScanAsync(Reader reader, bool dataAviarible)
        {
            OpcUaServiceScanResult result = null;
            OpcUaStatusCode status = null;

            await Task.Run(() =>
            {
                result = Scan(reader, dataAviarible, out status);
            });

            return new Tuple<OpcUaServiceScanResult, OpcUaStatusCode>(result, status);
        }

        /// <summary>
        /// Calls the "Scan" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="duration">Duration of a cycle</param>
        /// <param name="cycles">Scanning cycles</param>
        /// <param name="status">Return the status</param>
        /// <returns>A list of RfidTags and Status</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public OpcUaServiceScanResult Scan(Reader reader, int duration, int cycles, out OpcUaStatusCode status)
        {
            var settings = new ScanSettings
            {
                Duration = duration,
                Cycles = cycles
            };
            List<Variant> inputArguments = new List<Variant>
            {
                new ExtensionObject(settings)
            };

            List<Variant> outputArguments;
            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                   reader.NodeId,
                   GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.Scan), //Scan method
                   inputArguments,
                   new RequestSettings() { OperationTimeout = 600000 },
                   out List<StatusCode> inputArgumentErrors,
                   out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            var tags = new ObservableCollection<RfidTag>();
            string statusString = null;

            if (StatusCode.IsGood(statusCode))
            {
                var extensionObjects = outputArguments[0].ToExtensionObjectArray();
                foreach (var extensionObject in extensionObjects)
                {
                    var rfidScanResult = ExtensionObject.GetObject<RfidScanResult>(extensionObject);
                    var sightings = new ObservableCollection<Sighting>();

                    foreach (var sigthingElement in rfidScanResult.Sighting)
                    {
                        sightings.Add(new Sighting(sigthingElement.Antenna, sigthingElement.Strength, sigthingElement.Timestamp, sigthingElement.CurrentPowerLevel));
                    }

                    var tag = new RfidTag(rfidScanResult.ScanData.ByteString, rfidScanResult.Timestamp, rfidScanResult.CodeType, sightings);

                    tags.Add(tag);
                }

                if (!outputArguments[1].IsArray) // Up version 1.0.10
                {
                    statusString = Enum.GetName(typeof(AutoIdOperationStatusEnumeration), (int)outputArguments[1].Value);
                }
                else
                {
                    statusString = null;
                }
            }

            status = new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
            return new OpcUaServiceScanResult(tags, statusString);
        }

        /// <summary>
        /// Calls the "Scan" method from the reader (async)
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="duration">Duration of a cycle</param>
        /// <param name="cycles">Scanning cycles</param>
        /// <returns>A list of RfidTags and a status</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<Tuple<OpcUaServiceScanResult, OpcUaStatusCode>> ScanAsync(Reader reader, int duration, int cycles)
        {
            OpcUaServiceScanResult result = null;
            OpcUaStatusCode status = null;

            await Task.Run(() =>
            {
                result = Scan(reader, duration, cycles, out status);
            });

            return new Tuple<OpcUaServiceScanResult, OpcUaStatusCode>(result, status);
        }

        /// <summary>
        /// Calls the "ScanStart" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns status code</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public OpcUaStatusCode ScanStart(Reader reader)
        {
            List<Variant> inputArguments = new List<Variant>
            {
                new ExtensionObject(new ScanSettings())
            };
            List<Variant> outputArguments = null;

            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                    reader.NodeId,
                    GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.ScanStart),
                    inputArguments,
                    new RequestSettings() { OperationTimeout = 600000 },
                    out List<StatusCode> inputArgumentErrors,
                    out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            return new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
        }

        /// <summary>
        /// Calls the "ScanStart" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataAviarible">Stop scanning when tag found</param>
        /// <returns>Returns status code</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public OpcUaStatusCode ScanStart(Reader reader, bool dataAviarible)
        {
            var settings = new ScanSettings
            {
                DataAvailable = dataAviarible
            };
            List<Variant> inputArguments = new List<Variant>
            {
                new ExtensionObject(settings)
            };
            List<Variant> outputArguments = null;

            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                    reader.NodeId,
                    GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.ScanStart),
                    inputArguments,
                    new RequestSettings() { OperationTimeout = int.MaxValue },
                    out List<StatusCode> inputArgumentErrors,
                    out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            return new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
        }

        /// <summary>
        /// Calls the "ScanStop" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public OpcUaStatusCode ScanStop(Reader reader)
        {
            List<Variant> inputArguments = new List<Variant>();
            List<Variant> outputArguments = null;

            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                reader.NodeId,
                GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.ScanStop),
                inputArguments,
                new RequestSettings() { OperationTimeout = 10000 },
                out List<StatusCode> inputArgumentErrors,
                out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            return new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
        }

        #endregion Scan

        #region ReadTag

        /// <summary>
        ///  Calls the "ReadTag" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="tag">Tag Identifer</param>
        /// <param name="offset">Offset</param>
        /// <param name="length">Length</param>
        /// <param name="status">Return the status</param>
        /// <returns>A byte-array of data</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public byte[] ReadTag(Reader reader, RfidTag tag, int offset, int length, out OpcUaStatusCode status)
        {
            byte[] result = null;

            MessageContext context = new MessageContext();
            context.Factory.AddEncodeableType(typeof(ByteString));

            List<Variant> inputArguments = new List<Variant>();

            ScanData scanData = new ScanData
            {
                ByteString = tag?.Identifer
            };
            inputArguments.Add(new ExtensionObject(scanData));

            inputArguments.Add("UID"); // Format
            inputArguments.Add((UInt16)1); // 3 = Region User
            inputArguments.Add((UInt32)offset); // Offset
            inputArguments.Add((UInt32)length); // Length
            inputArguments.Add(new byte[0]); // Password

            List<Variant> outputArguments;
            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                reader.NodeId,
                GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.ReadTag),
                inputArguments,
                new RequestSettings() { OperationTimeout = 60000 * 10 },
                out List<StatusCode> inputArgumentErrors,
                out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            if (StatusCode.IsBad(statusCode))
            {
                throw new OpcUaServiceException(statusCode.Message);
            }

            if (StatusCode.IsGood(statusCode))
            {
                if ((int)AutoIdOperationStatusEnumeration.SUCCESS == (int)outputArguments[1].Value)
                {
                    if (!outputArguments[1].IsNull)
                    {
                        result = (byte[])outputArguments[0].Value;
                    }
                    else
                    {
                        result = new byte[] { };
                    }
                }
                else
                {
                    throw new OpcUaServiceException(Enum.GetName(typeof(AutoIdOperationStatusEnumeration), (int)outputArguments[1].Value));
                }
            }

            status = new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
            return result;
        }

        /// <summary>
        ///  Calls the "ReadTag" method from the reader (async)
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="tag">Tag Identifer</param>
        /// <param name="offset">Offset</param>
        /// <param name="length">Length</param>
        /// <returns>A byte-array of data and a status</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<Tuple<byte[], OpcUaStatusCode>> ReadTagAsync(Reader reader, RfidTag tag, int offset, int length)
        {
            byte[] result = null;
            OpcUaStatusCode status = null;

            await Task.Run(() =>
            {
                result = ReadTag(reader, tag, offset, length, out status);
            });

            return new Tuple<byte[], OpcUaStatusCode>(result, status);
        }

        #endregion ReadTag

        #region WriteTag

        /// <summary>
        ///  Calls the "WriteTag" method from the reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="tag">Tag Identifer</param>
        /// <param name="offset">Offset</param>
        /// <param name="data">a byte-array of data</param>
        /// <param name="status">Return the status</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public bool WriteTag(Reader reader, RfidTag tag, int offset, byte[] data, out OpcUaStatusCode status)
        {
            bool result = false;

            MessageContext context = new MessageContext();
            context.Factory.AddEncodeableType(typeof(ByteString));

            List<Variant> inputArguments = new List<Variant>();

            ScanData scanData = new ScanData
            {
                ByteString = tag?.Identifer
            };
            inputArguments.Add(new ExtensionObject(scanData));

            inputArguments.Add("UID"); // Format
            inputArguments.Add((UInt16)1); // 3 = Region User
            inputArguments.Add((UInt32)offset); // Offset
            inputArguments.Add(data); // ByteString Data
            inputArguments.Add(new byte[0]); // Password

            List<Variant> outputArguments;
            StatusCode statusCode;
            try
            {
                statusCode = _session.Call(
                reader.NodeId,
                GetMethodNodeId(reader.NodeId, AIM.AutoId.BrowseNames.WriteTag),
                inputArguments,
                new RequestSettings() { OperationTimeout = 60000},
                out List<StatusCode> inputArgumentErrors,
                out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            if (StatusCode.IsBad(statusCode))
            {
                throw new OpcUaServiceException(statusCode.Message);
            }

            if (StatusCode.IsGood(statusCode))
            {
                if ((int)AutoIdOperationStatusEnumeration.SUCCESS == (int)outputArguments[0].Value)
                {
                    result = true;
                }
                else
                {
                    throw new OpcUaServiceException(Enum.GetName(typeof(AutoIdOperationStatusEnumeration), (int)outputArguments[0].Value));
                }
            }

            status = new OpcUaStatusCode(statusCode.IsGood(), statusCode.Code, statusCode.GetCodeName());
            return result;
        }

        /// <summary>
        ///  Calls the "WriteTag" method from the reader (async)
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="tag">Tag Identifer</param>
        /// <param name="offset">Offset</param>
        /// <param name="data">a byte-array of data</param>
        /// <returns>Returns True if successful, otherwise False and a status</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<Tuple<bool, OpcUaStatusCode>> WriteTagAsync(Reader reader, RfidTag tag, int offset, byte[] data)
        {
            bool result = false;
            OpcUaStatusCode status = null;

            await Task.Run(() =>
            {
                result = WriteTag(reader, tag, offset, data, out status);
            });

            return new Tuple<bool, OpcUaStatusCode>(result, status);
        }

        #endregion WriteTag

        #region GetReaderProperties

        /// <summary>
        /// Read all properties from reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>A list of proterties from reader</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public List<ReaderProperty> GetReaderProperties(Reader reader)
        {
            var result = new List<ReaderProperty>();

            var allProperties = GetPropertiesFromNodeId(reader.NodeId);

            var nodesToRead = new List<ReadValueId>();

            foreach (var propertyNodeId in allProperties)
            {
                nodesToRead.Add(new ReadValueId() { NodeId = propertyNodeId, AttributeId = Attributes.DisplayName });
                nodesToRead.Add(new ReadValueId() { NodeId = propertyNodeId, AttributeId = Attributes.Value });
                nodesToRead.Add(new ReadValueId() { NodeId = propertyNodeId, AttributeId = Attributes.Description });
            }

            List<DataValue> dataValues;
            try
            {
                dataValues = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            for (int i = 0; i < dataValues.Count; i += 3)
            {
                result.Add(new ReaderProperty(dataValues[i].ToString(), dataValues[i + 1].ToString(), dataValues[i + 2].ToString()));
            }

            return result;
        }

        #endregion GetReaderProperties

        #region SetReaderName

        /// <summary>
        /// Rename the name of Reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="newName">new name</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public bool SetReaderName(Reader reader, string newName)
        {
            bool result = false;

            var propertyNodeId = GetPropertyFromNodeId(reader.NodeId, "DeviceName");

            if (propertyNodeId != null)
            {
                List<WriteValue> nodesToWrite = new List<WriteValue>();

                nodesToWrite.Add(new WriteValue()
                {
                    NodeId = propertyNodeId,
                    AttributeId = Attributes.Value,
                    Value = new DataValue() { WrappedValue = new Variant(newName) }
                });

                List<StatusCode> results;
                try
                {
                    results = _session.Write(
                    nodesToWrite,
                    new RequestSettings() { OperationTimeout = 10000 });
                }
                catch (Exception e)
                {
                    throw new OpcUaServiceException(e.Message, e);
                }

                if (results.Count > 0)
                {
                    if (results[0].IsGood())
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        #endregion SetReaderName

        #region SetAntenna

        /// <summary>
        /// Set Antenna of Reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="number">Number of Antenna</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public bool SetAntenna(Reader reader, int number)
        {
            bool result = false;

            var runtimeParametersNodeId = GetComponentFromNodeId(reader.NodeId, "RuntimeParameters");
            var enableAntennasNodeId = GetComponentFromNodeId(runtimeParametersNodeId, "EnableAntennas");

            if (enableAntennasNodeId != null)
            {
                List<WriteValue> nodesToWrite = new List<WriteValue>();

                nodesToWrite.Add(new WriteValue()
                {
                    NodeId = enableAntennasNodeId,
                    AttributeId = Attributes.Value,
                    Value = new DataValue() { WrappedValue = new Variant((UInt32)Math.Pow(2, number - 1)) }
                });

                List<StatusCode> results;
                try
                {
                    results = _session.Write(
                    nodesToWrite,
                    new RequestSettings() { OperationTimeout = 10000 });
                }
                catch (Exception e)
                {
                    throw new OpcUaServiceException(e.Message, e);
                }

                if (results.Count > 0)
                {
                    if (results[0].IsGood())
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        #endregion SetAntenna

        #region GetAntenna

        /// <summary>
        /// Ger Antenna of Reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns the number of antenna, otherwise 0</returns>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public int GetAntenna(Reader reader)
        {
            int result = 0;

            var runtimeParametersNodeId = GetComponentFromNodeId(reader.NodeId, "RuntimeParameters");
            if (runtimeParametersNodeId == null)
                return result;
            var enableAntennasNodeId = GetComponentFromNodeId(runtimeParametersNodeId, "EnableAntennas");
            if (enableAntennasNodeId == null)
                return result;

            if (enableAntennasNodeId != null)
            {
                List<ReadValueId> nodesToRead = new List<ReadValueId>
                {
                    new ReadValueId() {NodeId = enableAntennasNodeId, AttributeId = Attributes.Value}
                };

                List<DataValue> results = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });

                if (results.Count == 1)
                {
                    if (results[0].WrappedValue.DataType == BuiltInType.UInt32)
                    {
                        var value = results[0].WrappedValue.ToUInt32();

                        result = (int)Math.Log(value, 2) + 1;
                    }
                }
            }

            return result;
        }

        #endregion GetAntenna

        #region GetActivatedBusHeads

        /// <summary>
        /// Calls the "GetActivatedBusHeads" method to read activ bus heads
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="busConfiguration">NodeId of bus configuration</param>
        /// <returns>A list of active bus heads</returns>
        /// <remarks>Timeout: In 10 seconds</remarks>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public int[] GetActivatedBusHeads(Reader reader, NodeId busConfiguration)
        {
            int[] result = { };

            List<Variant> inputArguments = new List<Variant>
            {
                (UInt16)reader.Number
            };

            StatusCode statusCode;
            List<Variant> outputArguments;
            try
            {
                statusCode = _session.Call(
                busConfiguration,
                GetMethodNodeId(busConfiguration, "GetActivatedBusHeads"), //GetActivatedBusHeads method
                inputArguments,
                new RequestSettings() { OperationTimeout = int.MaxValue },
                out List<StatusCode> inputArgumentErrors,
                out outputArguments);
            }
            catch (Exception e)
            {
                throw new OpcUaServiceException(e.Message, e);
            }

            if (StatusCode.IsBad(statusCode))
            {
                throw new OpcUaServiceException(statusCode.GetCodeName());
            }

            if (StatusCode.IsGood(statusCode))
            {
                result = outputArguments[0].ToInt32Array();
            }

            return result;
        }

        /// <summary>
        /// Calls the "Scan" method from the reader (async)
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataAviarible">Stop scanning when tag found</param>
        /// <returns>A list of RfidTags and a status</returns>
        /// <remarks>Timeout: In 10 seconds</remarks>
        /// <exception cref="OpcUaServiceException">Error description why the function cannot be executed.</exception>
        public async Task<int[]> GetActivatedBusHeadsAsync(Reader reader, NodeId busConfiguration)
        {
            int[] result = null;

            await Task.Run(() =>
            {
                result = GetActivatedBusHeads(reader, busConfiguration);
            });

            return result;
        }

        #endregion GetActivatedBusHeads

        #region Monitored

        /// <summary>
        /// Creates a new subscription on the server
        /// </summary>
        public bool CreateSubscriptions()
        {
            bool result = false;
            try
            {
                if (_subscription != null)
                {
                    DeleteSubscriptions();
                }

                // initialize subscription.
                _subscription = new Subscription(_session)
                {
                    PublishingInterval = 0,
                    MaxKeepAliveTime = 5000,
                    Lifetime = int.MaxValue,
                    MaxNotificationsPerPublish = 0,
                    Priority = 0,
                    PublishingEnabled = true
                };

                // create subscription.
                _subscription.Create(new RequestSettings() { OperationTimeout = 10000 });

                _subscription.DataChanged += SubscriptionOnDataChanged;
                _subscription.NewEvents += SubscriptionOnNewEvents;

                result = true;
            }
            catch
            {
                // ignored
            }

            return result;
        }

        /// <summary>
        /// Delete a exist subscription on the server
        /// </summary>
        public void DeleteSubscriptions()
        {
            if (_subscription != null)
            {
                _subscription.DataChanged -= SubscriptionOnDataChanged;
                _subscription.NewEvents -= SubscriptionOnNewEvents;

                try
                {
                    _subscription.Delete(new RequestSettings() { OperationTimeout = 1000 });
                    _subscription = null;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// Occurs when any new event has arrived
        /// </summary>
        /// <param name="subscription">The subscription object that contains the MonitoredItems passed in the NewEvents of newEventsEventArgs</param>
        /// <param name="newEventsEventArgs">The information about the new events</param>
        private void SubscriptionOnNewEvents(Subscription subscription, NewEventsEventArgs newEventsEventArgs)
        {
            try
            {
                if (!ReferenceEquals(subscription, _subscription))
                {
                    return;
                }

                foreach (NewEvent anEvent in newEventsEventArgs.Events)
                {
                    if (anEvent.MonitoredItem.UserData is Reader reader)
                    {
                        var filter = anEvent.MonitoredItem.Filter;

                        //NodeId eventType = filter.GetValue<NodeId>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.EventType, NodeId.Null);
                        NodeId sourceNode = filter.GetValue<NodeId>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.SourceNode, NodeId.Null);
                        DateTime time = filter.GetValue<DateTime>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.Time, DateTime.MinValue);
                        DateTime receiveTime = filter.GetValue<DateTime>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.ReceiveTime, DateTime.MinValue);
                        ushort severity = filter.GetValue<ushort>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.Severity, 0);
                        LocalizedText message = filter.GetValue<LocalizedText>(anEvent.Event, UnifiedAutomation.UaBase.BrowseNames.Message, LocalizedText.Null);

                        string deviceName = filter.GetValue<String>(anEvent.Event, new QualifiedName("DeviceName", 4), String.Empty);
                        var scanResult = filter.GetValue<ExtensionObject[]>(anEvent.Event, new QualifiedName("ScanResult", 4), null);
                        RfidTag tag = null;

                        if (scanResult != null && scanResult.Length > 0)
                        {
                            foreach (var extensionObject in scanResult)
                            {
                                var rfidScanResult = ExtensionObject.GetObject<RfidScanResult>(extensionObject);
                                var sightings = new ObservableCollection<Sighting>();

                                foreach (var sigthingElement in rfidScanResult.Sighting)
                                {
                                    sightings.Add(new Sighting(sigthingElement.Antenna, sigthingElement.Strength, sigthingElement.Timestamp, sigthingElement.CurrentPowerLevel));
                                }

                                tag = new RfidTag(rfidScanResult.ScanData.ByteString, rfidScanResult.Timestamp, rfidScanResult.CodeType, sightings);
                            }
                        }

                        var infos = new EventInfoArgs(_subscription.Session.Cache.GetDisplayText(sourceNode), time, receiveTime, severity, message.ToString());

                        NewEvent?.Invoke(reader, infos, tag);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Occurs when any subscribed data value has changed
        /// </summary>
        /// <param name="subscription">The subscription object that contains the MonitoredItems passed in the DataChanges of dataChangedEventArgs</param>
        /// <param name="dataChangedEventArgs">The information about the changed values</param>
        private void SubscriptionOnDataChanged(Subscription subscription, DataChangedEventArgs dataChangedEventArgs)
        {
            try
            {
                if (!ReferenceEquals(subscription, _subscription))
                {
                    return;
                }

                foreach (DataChange change in dataChangedEventArgs.DataChanges)
                {
                    if (change.MonitoredItem.UserData is string item)
                    {
                        DataChange?.Invoke(item, change.Value);
                    }
                }
            }
            catch
            {
                // ignored
            }
        }

        /// <summary>
        /// Adding a variable from the reader to the monitored
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataName">Unique name for monitored item</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool AddMonitoredItem(Reader reader, string dataName)
        {
            bool result = false;

            var monitorNodeId = GetComponentFromNodeId(reader.NodeId, dataName);
            if (monitorNodeId != null)
            {
                if (_subscription == null)
                {
                    CreateSubscriptions();
                }

                var monitoredItems = new List<MonitoredItem>();

                MonitoredItem monitoredItem = new DataMonitoredItem(monitorNodeId);
                monitoredItem.UserData = dataName;
                monitoredItems.Add(monitoredItem);

                // create monitored item
                var results = _subscription.CreateMonitoredItems(
                    monitoredItems,
                    new RequestSettings() { OperationTimeout = 10000 });

                if (results.Count == 1 && results[0].IsGood())
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Removing a variable from the reader to the monitored
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <param name="dataName">Unique name for monitored item</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        /// <remarks></remarks>
        public bool RemoveMonitoredItem(Reader reader, string dataName)
        {
            bool result = false;

            var monitoredItems = new List<MonitoredItem>();

            foreach (var item in _subscription.MonitoredItems)
            {
                if (item.UserData is string uniqueName)
                {
                    if (uniqueName == dataName)
                    {
                        monitoredItems.Add(item);
                        break;
                    }
                }
            }

            if (monitoredItems.Count != 0)
            {
                // create monitored item
                var results = _subscription.DeleteMonitoredItems(
                    monitoredItems,
                    new RequestSettings() { OperationTimeout = 10000 });

                if (results.Count == 1 && results[0].IsGood())
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Add AutoIdScanEvent from the reader to the monitored
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        public bool AddMonitoredAutoIdScanEvent(Reader reader)
        {
            bool result = false;

            EventMonitoredItem eventMonitoredItem =
                new EventMonitoredItem(reader.NodeId)
                {
                    MonitoringMode = MonitoringMode.Reporting,
                    SamplingInterval = -1,
                    QueueSize = 1000,
                    DiscardOldest = true,
                    Filter = new ItemEventFilter(_subscription.Session.NamespaceUris)
                };

            eventMonitoredItem.Filter.SetDefault();

            var eventList = GetVariableListFromObjectType(AIM.AutoId.BrowseNames.AutoIdScanEventType);

            foreach (var referenceDescription in eventList)
            {
                eventMonitoredItem.Filter.SelectClauses.Add(referenceDescription.BrowseName);
            }

            if (_subscription == null)
            {
                CreateSubscriptions();
            }

            var monitoredItems = new List<MonitoredItem>();

            MonitoredItem monitoredItem = eventMonitoredItem;
            monitoredItem.UserData = reader;
            monitoredItems.Add(monitoredItem);

            // create monitored item
            var results = _subscription.CreateMonitoredItems(
                monitoredItems,
                new RequestSettings() { OperationTimeout = 10000 });

            if (results.Count == 1 && results[0].IsGood())
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Remove AutoIdScanEvent from the reader to the monitored
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns True if successful, otherwise False</returns>
        public bool RemoveAutoIdScanEvent(Reader reader)
        {
            bool result = false;

            List<MonitoredItem> monitoredItems = new List<MonitoredItem>();

            foreach (var item in _subscription.MonitoredItems)
            {
                if (item.UserData is Reader uniqueReader)
                {
                    if (uniqueReader == reader)
                    {
                        monitoredItems.Add(item);
                    }
                }
            }

            if (monitoredItems.Count != 0)
            {
                // create monitored item
                List<StatusCode> results = _subscription.DeleteMonitoredItems(
                    monitoredItems,
                    new RequestSettings() { OperationTimeout = 10000 });

                if (results.Count == 1 && results[0].IsGood())
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Checks if AutoIdScanEvent is configured
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Returns true if configured, otherwise false</returns>
        public bool HasMonitoredAutoIdScanEvent(Reader reader)
        {
            bool result = false;

            foreach (var item in _subscription.MonitoredItems)
            {
                if (item.UserData is Reader uniqueReader)
                {
                    if (uniqueReader == reader)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        #endregion Monitored

        #region LastScanData

        /// <summary>
        /// Get the last detected tag
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Last detected tag</returns>
        public RfidTag GetLastScanResult(Reader reader)
        {
            RfidTag result = null;

            MessageContext context = new MessageContext();
            context.Factory.AddEncodeableType(typeof(ScanData));
            context.Factory.AddEncodeableType(typeof(ScanDataEpc));

            var lastScanResultNodeId = GetComponentFromNodeId(reader.NodeId, "LastScanData");

            List<ReadValueId> nodesToRead = new List<ReadValueId>
            {
                new ReadValueId() {NodeId = lastScanResultNodeId, AttributeId = Attributes.Value}
            };

            // read the value (setting a 10 second timeout).
            List<DataValue> results = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });

            if (results.Count == 1)
            {
                if (results[0].WrappedValue.DataType == BuiltInType.ByteString)
                {
                    result = new RfidTag(results[0].WrappedValue.ToByteString(), results[0].SourceTimestamp, results[0].WrappedValue.DataType.ToString(), null);
                }
                else if (results[0].WrappedValue.DataType == BuiltInType.String)
                {
                    result = new RfidTag(Encoding.ASCII.GetBytes(results[0].WrappedValue.ToString()), results[0].SourceTimestamp, results[0].WrappedValue.DataType.ToString(), null);
                }
                else if (results[0].WrappedValue.DataType == BuiltInType.ExtensionObject)
                {
                    var scanDataEpc = ExtensionObject.GetObject<ScanDataEpc>(results[0].WrappedValue.ToExtensionObject());
                    result = new RfidTag(scanDataEpc.UId, results[0].SourceTimestamp, BuiltInType.ByteString.ToString(), null);
                }
            }

            return result;
        }

        #endregion LastScanData

        #region LastScanRssi

        /// <summary>
        /// Get the last rssi value
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Last rssi value</returns>
        public int GetLastScanRssi(Reader reader)
        {
            int result = 0;

            //MessageContext context = new MessageContext();
            //context.Factory.AddEncodeableType(typeof(ScanData));

            var lastScanResultNodeId = GetComponentFromNodeId(reader.NodeId, "LastScanRSSI");

            List<ReadValueId> nodesToRead = new List<ReadValueId>
            {
                new ReadValueId() {NodeId = lastScanResultNodeId, AttributeId = Attributes.Value}
            };

            // read the value (setting a 10 second timeout).
            List<DataValue> results = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });

            if (results.Count == 1)
            {
                if (results[0].WrappedValue.DataType == BuiltInType.Int32)
                {
                    result = results[0].WrappedValue.ToInt32();
                }
            }

            return result;
        }

        #endregion LastScanRssi

        #region LastScanAntenna

        /// <summary>
        /// Get the last rssi value
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Last rssi value</returns>
        public int GetLastScanAntenna(Reader reader)
        {
            int result = 0;

            //MessageContext context = new MessageContext();
            //context.Factory.AddEncodeableType(typeof(ScanData));

            var lastScanResultNodeId = GetComponentFromNodeId(reader.NodeId, "LastScanAntenna");

            List<ReadValueId> nodesToRead = new List<ReadValueId>
            {
                new ReadValueId() {NodeId = lastScanResultNodeId, AttributeId = Attributes.Value}
            };

            // read the value (setting a 10 second timeout).
            List<DataValue> results = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });

            if (results.Count == 1)
            {
                if (results[0].WrappedValue.DataType == BuiltInType.Int32)
                {
                    result = results[0].WrappedValue.ToInt32();
                }
            }

            return result;
        }

        #endregion LastScanAntenna

        #region IsBusModeActive

        /// <summary>
        /// Check BusMode of reader
        /// </summary>
        /// <param name="reader">Reader</param>
        /// <returns>Return TRUE when the reader has BusMode, otherwise FALSE</returns>
        public bool IsBusModeActive(Reader reader, NodeId busConfiguration)
        {
            bool result = false;

            var busModeNodeId = GetComponentFromNodeId(busConfiguration, "BusMode");
            if (busModeNodeId == null)
                return result;
            var busModeIdentNodeId = GetComponentFromNodeId(busModeNodeId, "Ident" + reader.Number);
            if (busModeIdentNodeId == null)
                return result;

            List<ReadValueId> nodesToRead = new List<ReadValueId>
            {
                new ReadValueId() {NodeId = busModeIdentNodeId, AttributeId = Attributes.Value}
            };

            // read the value (setting a 10 second timeout).
            List<DataValue> results = _session.Read(
                nodesToRead,
                0,
                TimestampsToReturn.Both,
                new RequestSettings() { OperationTimeout = 10000 });

            if (results.Count == 1)
            {
                if (results[0].WrappedValue.DataType == BuiltInType.Boolean)
                {
                    result = results[0].WrappedValue.ToBoolean();
                }
            }

            return result;
        }

        #endregion IsBusModeActive

        #endregion Functions

        #region Private Functions

        /// <summary>
        /// Get a list of NodeId from parent
        /// </summary>
        /// <param name="nodeId">Parent NodeId</param>
        /// <returns>A list of NodeId</returns>
        private List<NodeId> GetPropertiesFromNodeId(NodeId nodeId)
        {
            var result = new List<NodeId>();

            BrowseContext context = new BrowseContext
            {
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HasProperty,
                IncludeSubtypes = true,
                MaxReferencesToReturn = 0
            };

            List<ReferenceDescription> references = _session.Browse(
                nodeId,
                context,
                new RequestSettings() { OperationTimeout = 10000 },
                out byte[] continuationPoint);

            foreach (ReferenceDescription reference in references)
            {
                result.Add(reference.NodeId.ToNodeId(_session.NamespaceUris));
            }

            return result;
        }

        /// <summary>
        /// Get a NodeId from Folder
        /// </summary>
        /// <param name="folderName">Name of Folder</param>
        /// <returns>Get NodeId</returns>
        private NodeId GetNodeId(string browserName)
        {
            return SearchNodeId(new NodeId(85, 0), browserName);
        }

        /// <summary>
        /// Finds nodeid by the browsername
        /// </summary>
        /// <param name="startPoint">Start point</param>
        /// <param name="browserName">NodeId with browsername</param>
        /// <returns>Returns the found NodeId, otherwise NULL</returns>
        private NodeId SearchNodeId(NodeId startPoint, string browserName)
        {
            if (startPoint == null)
                return null;
            if (string.IsNullOrEmpty(browserName))
                return null;

            NodeId result = null;

            BrowseDescription description = new BrowseDescription()
            {
                NodeId = startPoint,
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.Organizes,
                IncludeSubtypes = true,
                NodeClassMask = (uint)NodeClass.Object,
                ResultMask = (uint)(BrowseResultMask.All)
            };

            List<BrowseDescription> nodesToBrowse = new List<BrowseDescription>
            {
                description
            };

            var refList = _session.BrowseList(
                null,
                nodesToBrowse,
                0,
                new RequestSettings() { OperationTimeout = 10000 });

            foreach (var refsDescriptions in refList)
            {
                foreach (var refs in refsDescriptions)
                {
                    if (refs.DisplayName.Text == browserName)
                    {
                        return refs.NodeId.ToNodeId(_session.NamespaceUris);
                    }

                    var nodeId = refs.NodeId.ToNodeId(_session.NamespaceUris);
                    result = SearchNodeId(nodeId, browserName);
                    if (result != null)
                    {
                        break;
                    }
                }

                if (result != null)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Get a NodeId of the given property name
        /// </summary>
        /// <param name="nodeId">Parent NodeId</param>
        /// <param name="propertyName">Name of property</param>
        /// <returns>NodeId from property name, otherwise null</returns>
        private NodeId GetPropertyFromNodeId(NodeId nodeId, string propertyName)
        {
            NodeId result = null;

            if (nodeId == null || String.IsNullOrEmpty(propertyName.Trim()))
            {
                return null;
            }

            BrowseContext context = new BrowseContext
            {
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HasProperty,
                IncludeSubtypes = true,
                MaxReferencesToReturn = 0
            };

            List<ReferenceDescription> references = _session.Browse(
                nodeId,
                context,
                new RequestSettings() { OperationTimeout = 10000 },
                out byte[] continuationPoint);

            foreach (ReferenceDescription reference in references)
            {
                if (propertyName == reference.DisplayName.Text)
                {
                    result = reference.NodeId.ToNodeId(_session.NamespaceUris);
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Get a NodeId of the given component name
        /// </summary>
        /// <param name="nodeId">Parent NodeId</param>
        /// <param name="componentName">Name of component</param>
        /// <returns>NodeId from component name, otherwise null</returns>
        private NodeId GetComponentFromNodeId(NodeId nodeId, string componentName)
        {
            NodeId result = null;

            if (nodeId == null || String.IsNullOrEmpty(componentName.Trim()))
            {
                return null;
            }

            BrowseContext context = new BrowseContext
            {
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HasComponent,
                IncludeSubtypes = true,
                MaxReferencesToReturn = 0
            };

            List<ReferenceDescription> references = _session.Browse(
                nodeId,
                context,
                new RequestSettings() { OperationTimeout = 10000 },
                out byte[] continuationPoint);

            foreach (ReferenceDescription reference in references)
            {
                if (componentName == reference.DisplayName.Text)
                {
                    result = reference.NodeId.ToNodeId(_session.NamespaceUris);
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Get a NodeId of the given method name
        /// </summary>
        /// <param name="nodeId">Parent NodeId</param>
        /// <param name="methodName">Name of method</param>
        /// <returns>NodeId from method name, otherwise null</returns>
        private NodeId GetMethodNodeId(NodeId nodeId, string methodName)
        {
            NodeId result = null;

            BrowseDescription description = new BrowseDescription()
            {
                NodeId = nodeId,
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HasComponent,
                IncludeSubtypes = true,
                NodeClassMask = (uint)NodeClass.Method,
                ResultMask = (uint)(BrowseResultMask.BrowseName | BrowseResultMask.DisplayName)
            };

            List<BrowseDescription> nodesToBrowse = new List<BrowseDescription>
            {
                description
            };

            var methodList = _session.BrowseList(
                null,
                nodesToBrowse,
                0,
                new RequestSettings() { OperationTimeout = 10000 });

            foreach (var items in methodList)
            {
                foreach (var item in items)
                {
                    if (item.DisplayName.Text == methodName)
                    {
                        result = item.NodeId.ToNodeId(_session.NamespaceUris);
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns all variables of a given node
        /// </summary>
        /// <param name="objectTypeName">Name from oject type</param>
        /// <returns>List of variable</returns>
        private IEnumerable<ReferenceDescription> GetVariableListFromObjectType(string objectTypeName)
        {
            var result = new List<ReferenceDescription>();

            BrowseDescription description = new BrowseDescription()
            {
                NodeId = new NodeId(UnifiedAutomation.UaBase.ObjectTypes.BaseEventType, 0),
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HierarchicalReferences,
                IncludeSubtypes = true,
                NodeClassMask = (uint)NodeClass.ObjectType,
                ResultMask = (uint)BrowseResultMask.All
            };

            List<BrowseDescription> nodesToBrowse = new List<BrowseDescription>
            {
                description
            };

            var methodList = _session.BrowseList(
                null,
                nodesToBrowse,
                0,
                new RequestSettings() { OperationTimeout = 10000 });

            foreach (var items in methodList)
            {
                foreach (ReferenceDescription item in items)
                {
                    if (item.DisplayName.Text == objectTypeName)
                    {
                        result = GetVariableListFromNode(item);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns all variables of a node
        /// </summary>
        /// <param name="nodeId">Reference description node</param>
        /// <returns>List of variable</returns>
        private List<ReferenceDescription> GetVariableListFromNode(ReferenceDescription nodeId)
        {
            var result = new List<ReferenceDescription>();

            BrowseDescription description = new BrowseDescription()
            {
                NodeId = nodeId.NodeId.ToNodeId(_session.NamespaceUris),
                BrowseDirection = BrowseDirection.Forward,
                ReferenceTypeId = UnifiedAutomation.UaBase.ReferenceTypeIds.HierarchicalReferences,
                IncludeSubtypes = true,
                NodeClassMask = (uint)(NodeClass.Variable | NodeClass.ObjectType),
                ResultMask = (uint)BrowseResultMask.All
            };

            List<BrowseDescription> nodesToBrowse = new List<BrowseDescription>
            {
                description
            };

            var methodList = _session.BrowseList(
                null,
                nodesToBrowse,
                0,
                new RequestSettings() { OperationTimeout = 10000 });

            foreach (var items in methodList)
            {
                foreach (var item in items)
                {
                    if (item.NodeClass == NodeClass.ObjectType)
                    {
                        result.AddRange(GetVariableListFromNode(item));
                    }
                    else if (item.NodeClass == NodeClass.Variable)
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }

        #endregion Private Functions
    }
}
