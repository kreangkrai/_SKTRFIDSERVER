

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;
using UnifiedAutomation.UaBase;
using System.Diagnostics;

namespace AIM.AutoId
{
    #region AutoIdOperationStatusEnumeration
    /// <summary>
    /// The possible encodings for a AutoIdOperationStatusEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum AutoIdOperationStatusEnumeration
    {
        /// <summary>
        /// Successful operation
        /// </summary>
        [EnumMember(Value = "SUCCESS_0")]
        SUCCESS = 0,
        /// <summary>
        /// The operation has not be executed in total
        /// </summary>
        [EnumMember(Value = "MISC_ERROR_TOTAL_1")]
        MISC_ERROR_TOTAL = 1,
        /// <summary>
        /// The operation has been executed only partial
        /// </summary>
        [EnumMember(Value = "MISC_ERROR_PARTIAL_2")]
        MISC_ERROR_PARTIAL = 2,
        /// <summary>
        /// Password required
        /// </summary>
        [EnumMember(Value = "PERMISSON_ERROR_3")]
        PERMISSON_ERROR = 3,
        /// <summary>
        /// Password is wrong
        /// </summary>
        [EnumMember(Value = "PASSWORD_ERROR_4")]
        PASSWORD_ERROR = 4,
        /// <summary>
        /// Memory region not available for the actual tag
        /// </summary>
        [EnumMember(Value = "REGION_NOT_FOUND_ERROR_5")]
        REGION_NOT_FOUND_ERROR = 5,
        /// <summary>
        /// Operation not supported by the actual tag
        /// </summary>
        [EnumMember(Value = "OP_NOT_POSSIBLE_ERROR_6")]
        OP_NOT_POSSIBLE_ERROR = 6,
        /// <summary>
        /// Addressed memory not available for the actual tag
        /// </summary>
        [EnumMember(Value = "OUT_OF_RANGE_ERROR_7")]
        OUT_OF_RANGE_ERROR = 7,
        /// <summary>
        /// The operation cannot be executed because no tag or code was inside the range of the AutoID Device or the tag or code has been moved out of the range during execution
        /// </summary>
        [EnumMember(Value = "NO_IDENTIFIER_8")]
        NO_IDENTIFIER = 8,
        /// <summary>
        /// Multiple tags or codes have been selected, but the command can only be used with a single tag or code
        /// </summary>
        [EnumMember(Value = "MULTIPLE_IDENTIFIERS_9")]
        MULTIPLE_IDENTIFIERS = 9,
        /// <summary>
        /// The tag or code exists and has a valid format, but there was a problem reading the data (e.g. still CRC error after maximum number of retries)
        /// </summary>
        [EnumMember(Value = "READ_ERROR_10")]
        READ_ERROR = 10,
        /// <summary>
        /// The (optical) code or plain text has too many failures and cannot be detected
        /// </summary>
        [EnumMember(Value = "DECODING_ERROR_11")]
        DECODING_ERROR = 11,
        /// <summary>
        /// The code doesn’t match the given target value
        /// </summary>
        [EnumMember(Value = "MATCH_ERROR_12")]
        MATCH_ERROR = 12,
        /// <summary>
        /// The code format is not supported by the AutoID Device
        /// </summary>
        [EnumMember(Value = "CODE_NOT_SUPPORTED_13")]
        CODE_NOT_SUPPORTED = 13,
        /// <summary>
        /// The tag exists, but there was a problem writing the data 
        /// </summary>
        [EnumMember(Value = "WRITE_ERROR_14")]
        WRITE_ERROR = 14,
        /// <summary>
        /// The command or a parameter combination is not supported by the AutoID Device
        /// </summary>
        [EnumMember(Value = "NOT_SUPPORTED_BY_DEVICE_15")]
        NOT_SUPPORTED_BY_DEVICE = 15,
        /// <summary>
        /// The command or a parameter combination is not supported by the tag
        /// </summary>
        [EnumMember(Value = "NOT_SUPPORTED_BY_TAG_16")]
        NOT_SUPPORTED_BY_TAG = 16,
        /// <summary>
        /// The AutoID Device is in a state not ready to execute the command
        /// </summary>
        [EnumMember(Value = "DEVICE_NOT_READY_17")]
        DEVICE_NOT_READY = 17,
        /// <summary>
        /// The AutoID Device configuration is not valid
        /// </summary>
        [EnumMember(Value = "INVALID_CONFIGURATION_18")]
        INVALID_CONFIGURATION = 18,
        /// <summary>
        /// This error indicates that there is a general error in the communication between the transponder and the reader
        /// </summary>
        [EnumMember(Value = "RF_COMMUNICATION_ERROR_19")]
        RF_COMMUNICATION_ERROR = 19,
        /// <summary>
        /// The AutoID Device has a hardware fault
        /// </summary>
        [EnumMember(Value = "DEVICE_FAULT_20")]
        DEVICE_FAULT = 20,
        /// <summary>
        /// The battery of the (active) tag is low
        /// </summary>
        [EnumMember(Value = "TAG_HAS_LOW_BATTERY_21")]
        TAG_HAS_LOW_BATTERY = 21,
    }

    #region AutoIdOperationStatusEnumerationCollection Class
    /// <summary>
    /// A collection of AutoIdOperationStatusEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class AutoIdOperationStatusEnumerationCollection : List<AutoIdOperationStatusEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AutoIdOperationStatusEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AutoIdOperationStatusEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AutoIdOperationStatusEnumerationCollection(IEnumerable<AutoIdOperationStatusEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AutoIdOperationStatusEnumerationCollection(AutoIdOperationStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new AutoIdOperationStatusEnumerationCollection(values);
            }

            return new AutoIdOperationStatusEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AutoIdOperationStatusEnumeration[](AutoIdOperationStatusEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            AutoIdOperationStatusEnumerationCollection clone = new AutoIdOperationStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AutoIdOperationStatusEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region DeviceStatusEnumeration
    /// <summary>
    /// The possible encodings for a DeviceStatusEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum DeviceStatusEnumeration
    {
        [EnumMember(Value = "Idle_0")]
        Idle = 0,
        [EnumMember(Value = "Error_1")]
        Error = 1,
        [EnumMember(Value = "Scanning_2")]
        Scanning = 2,
        [EnumMember(Value = "Busy_3")]
        Busy = 3,
    }

    #region DeviceStatusEnumerationCollection Class
    /// <summary>
    /// A collection of DeviceStatusEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class DeviceStatusEnumerationCollection : List<DeviceStatusEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DeviceStatusEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DeviceStatusEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DeviceStatusEnumerationCollection(IEnumerable<DeviceStatusEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DeviceStatusEnumerationCollection(DeviceStatusEnumeration[] values)
        {
            if (values != null)
            {
                return new DeviceStatusEnumerationCollection(values);
            }

            return new DeviceStatusEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DeviceStatusEnumeration[](DeviceStatusEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            DeviceStatusEnumerationCollection clone = new DeviceStatusEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DeviceStatusEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region LocationTypeEnumeration
    /// <summary>
    /// The possible encodings for a LocationTypeEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum LocationTypeEnumeration
    {
        [EnumMember(Value = "NMEA_0")]
        NMEA = 0,
        [EnumMember(Value = "UTM_1")]
        UTM = 1,
        [EnumMember(Value = "LOCAL_2")]
        LOCAL = 2,
        [EnumMember(Value = "LOCAL_1D_3")]
        LOCAL_1D = 3,
        [EnumMember(Value = "WGS84_4")]
        WGS84 = 4,
        [EnumMember(Value = "NAME_5")]
        NAME = 5,
        [EnumMember(Value = "LCI_DHCP_6")]
        LCI_DHCP = 6,
        [EnumMember(Value = "Civic_Address_7")]
        Civic_Address = 7,
    }

    #region LocationTypeEnumerationCollection Class
    /// <summary>
    /// A collection of LocationTypeEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class LocationTypeEnumerationCollection : List<LocationTypeEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public LocationTypeEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public LocationTypeEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public LocationTypeEnumerationCollection(IEnumerable<LocationTypeEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator LocationTypeEnumerationCollection(LocationTypeEnumeration[] values)
        {
            if (values != null)
            {
                return new LocationTypeEnumerationCollection(values);
            }

            return new LocationTypeEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator LocationTypeEnumeration[](LocationTypeEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            LocationTypeEnumerationCollection clone = new LocationTypeEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LocationTypeEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region RfidLockOperationEnumeration
    /// <summary>
    /// The possible encodings for a RfidLockOperationEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum RfidLockOperationEnumeration
    {
        [EnumMember(Value = "Lock_0")]
        Lock = 0,
        [EnumMember(Value = "Unlock_1")]
        Unlock = 1,
        [EnumMember(Value = "PermanentLock_2")]
        PermanentLock = 2,
        [EnumMember(Value = "PermanentUnlock_3")]
        PermanentUnlock = 3,
    }

    #region RfidLockOperationEnumerationCollection Class
    /// <summary>
    /// A collection of RfidLockOperationEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class RfidLockOperationEnumerationCollection : List<RfidLockOperationEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RfidLockOperationEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RfidLockOperationEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RfidLockOperationEnumerationCollection(IEnumerable<RfidLockOperationEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RfidLockOperationEnumerationCollection(RfidLockOperationEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidLockOperationEnumerationCollection(values);
            }

            return new RfidLockOperationEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RfidLockOperationEnumeration[](RfidLockOperationEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RfidLockOperationEnumerationCollection clone = new RfidLockOperationEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidLockOperationEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region RfidLockRegionEnumeration
    /// <summary>
    /// The possible encodings for a RfidLockRegionEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum RfidLockRegionEnumeration
    {
        [EnumMember(Value = "Kill_0")]
        Kill = 0,
        [EnumMember(Value = "Access_1")]
        Access = 1,
        [EnumMember(Value = "EPC_2")]
        EPC = 2,
        [EnumMember(Value = "TID_3")]
        TID = 3,
        [EnumMember(Value = "User_4")]
        User = 4,
    }

    #region RfidLockRegionEnumerationCollection Class
    /// <summary>
    /// A collection of RfidLockRegionEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class RfidLockRegionEnumerationCollection : List<RfidLockRegionEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RfidLockRegionEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RfidLockRegionEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RfidLockRegionEnumerationCollection(IEnumerable<RfidLockRegionEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RfidLockRegionEnumerationCollection(RfidLockRegionEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidLockRegionEnumerationCollection(values);
            }

            return new RfidLockRegionEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RfidLockRegionEnumeration[](RfidLockRegionEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RfidLockRegionEnumerationCollection clone = new RfidLockRegionEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidLockRegionEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region RfidPasswordTypeEnumeration
    /// <summary>
    /// The possible encodings for a RfidPasswordTypeEnumeration value.
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public enum RfidPasswordTypeEnumeration
    {
        [EnumMember(Value = "Access_0")]
        Access = 0,
        [EnumMember(Value = "Kill_1")]
        Kill = 1,
        [EnumMember(Value = "Read_2")]
        Read = 2,
        [EnumMember(Value = "Write_3")]
        Write = 3,
    }

    #region RfidPasswordTypeEnumerationCollection Class
    /// <summary>
    /// A collection of RfidPasswordTypeEnumeration objects.
    /// </summary>
    [CollectionDataContract]
    public partial class RfidPasswordTypeEnumerationCollection : List<RfidPasswordTypeEnumeration>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RfidPasswordTypeEnumerationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RfidPasswordTypeEnumerationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RfidPasswordTypeEnumerationCollection(IEnumerable<RfidPasswordTypeEnumeration> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RfidPasswordTypeEnumerationCollection(RfidPasswordTypeEnumeration[] values)
        {
            if (values != null)
            {
                return new RfidPasswordTypeEnumerationCollection(values);
            }

            return new RfidPasswordTypeEnumerationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RfidPasswordTypeEnumeration[](RfidPasswordTypeEnumerationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RfidPasswordTypeEnumerationCollection clone = new RfidPasswordTypeEnumerationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidPasswordTypeEnumeration)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region AntennaNameIdPair Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class AntennaNameIdPair : IEncodeable
    {
        #region Constructors
        public AntennaNameIdPair()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_AntennaId = (int)0;
            m_AntennaName = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "AntennaId", IsRequired = false, Order = 1)]
        public int AntennaId
        {
            get
            {
                return m_AntennaId;
            }
            set
            {
                m_AntennaId = value;
            }
        }
        [DataMember(Name = "AntennaName", IsRequired = false, Order = 2)]
        public string AntennaName
        {
            get
            {
                return m_AntennaName;
            }
            set
            {
                m_AntennaName = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.AntennaNameIdPair; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.AntennaNameIdPair_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.AntennaNameIdPair_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteInt32("AntennaId", AntennaId);
            encoder.WriteString("AntennaName", AntennaName);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            AntennaId = decoder.ReadInt32("AntennaId");
            AntennaName = decoder.ReadString("AntennaName");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            AntennaNameIdPair value = encodeable as AntennaNameIdPair;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_AntennaId, value.m_AntennaId)) return false;
            if (!TypeUtils.IsEqual(m_AntennaName, value.m_AntennaName)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            AntennaNameIdPair clone = (AntennaNameIdPair)this.MemberwiseClone();

            clone.m_AntennaId = (int)TypeUtils.Clone(this.m_AntennaId);
            clone.m_AntennaName = (string)TypeUtils.Clone(this.m_AntennaName);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_AntennaId;
        private string m_AntennaName;
        #endregion
    }

    #region AntennaNameIdPairCollection class
    /// <summary>
    /// A collection of AntennaNameIdPair objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfAntennaNameIdPair", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "AntennaNameIdPair")]
    public partial class AntennaNameIdPairCollection : List<AntennaNameIdPair>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public AntennaNameIdPairCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public AntennaNameIdPairCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public AntennaNameIdPairCollection(IEnumerable<AntennaNameIdPair> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator AntennaNameIdPairCollection(AntennaNameIdPair[] values)
        {
            if (values != null)
            {
                return new AntennaNameIdPairCollection(values);
            }

            return new AntennaNameIdPairCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator AntennaNameIdPair[](AntennaNameIdPairCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            AntennaNameIdPairCollection clone = new AntennaNameIdPairCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((AntennaNameIdPair)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region CivicAddressElement Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class CivicAddressElement : IEncodeable
    {
        #region Constructors
        public CivicAddressElement()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_CAtype = (byte)0;
            m_CAvalue = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "CAtype", IsRequired = false, Order = 1)]
        public byte CAtype
        {
            get
            {
                return m_CAtype;
            }
            set
            {
                m_CAtype = value;
            }
        }
        [DataMember(Name = "CAvalue", IsRequired = false, Order = 2)]
        public string CAvalue
        {
            get
            {
                return m_CAvalue;
            }
            set
            {
                m_CAvalue = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CivicAddressElement; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CivicAddressElement_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CivicAddressElement_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteByte("CAtype", CAtype);
            encoder.WriteString("CAvalue", CAvalue);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            CAtype = decoder.ReadByte("CAtype");
            CAvalue = decoder.ReadString("CAvalue");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CivicAddressElement value = encodeable as CivicAddressElement;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_CAtype, value.m_CAtype)) return false;
            if (!TypeUtils.IsEqual(m_CAvalue, value.m_CAvalue)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            CivicAddressElement clone = (CivicAddressElement)this.MemberwiseClone();

            clone.m_CAtype = (byte)TypeUtils.Clone(this.m_CAtype);
            clone.m_CAvalue = (string)TypeUtils.Clone(this.m_CAvalue);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_CAtype;
        private string m_CAvalue;
        #endregion
    }

    #region CivicAddressElementCollection class
    /// <summary>
    /// A collection of CivicAddressElement objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfCivicAddressElement", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "CivicAddressElement")]
    public partial class CivicAddressElementCollection : List<CivicAddressElement>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CivicAddressElementCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CivicAddressElementCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CivicAddressElementCollection(IEnumerable<CivicAddressElement> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CivicAddressElementCollection(CivicAddressElement[] values)
        {
            if (values != null)
            {
                return new CivicAddressElementCollection(values);
            }

            return new CivicAddressElementCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CivicAddressElement[](CivicAddressElementCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            CivicAddressElementCollection clone = new CivicAddressElementCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CivicAddressElement)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region CivicAddressType Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class CivicAddressType : IEncodeable
    {
        #region Constructors
        public CivicAddressType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_CAcountry = null;
            m_CAelements = new CivicAddressElementCollection();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "CAcountry", IsRequired = false, Order = 1)]
        public string CAcountry
        {
            get
            {
                return m_CAcountry;
            }
            set
            {
                m_CAcountry = value;
            }
        }
        [DataMember(Name = "CAelements", IsRequired = false, Order = 2)]
        public CivicAddressElementCollection CAelements
        {
            get
            {
                return m_CAelements;
            }
            set
            {
                m_CAelements = value;

                if (value == null)
                {
                    m_CAelements = new CivicAddressElementCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.CivicAddressType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.CivicAddressType_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.CivicAddressType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteString("CAcountry", CAcountry);
            encoder.WriteEncodeableArray("CAelements", CAelements.ToArray(), typeof(CivicAddressElement));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            CAcountry = decoder.ReadString("CAcountry");
            CAelements = (CivicAddressElementCollection)decoder.ReadEncodeableArray("CAelements", typeof(CivicAddressElement));

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            CivicAddressType value = encodeable as CivicAddressType;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_CAcountry, value.m_CAcountry)) return false;
            if (!TypeUtils.IsEqual(m_CAelements, value.m_CAelements)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            CivicAddressType clone = (CivicAddressType)this.MemberwiseClone();

            clone.m_CAcountry = (string)TypeUtils.Clone(this.m_CAcountry);
            clone.m_CAelements = (CivicAddressElementCollection)TypeUtils.Clone(this.m_CAelements);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_CAcountry;
        private CivicAddressElementCollection m_CAelements;
        #endregion
    }

    #region CivicAddressTypeCollection class
    /// <summary>
    /// A collection of CivicAddressType objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfCivicAddressType", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "CivicAddressType")]
    public partial class CivicAddressTypeCollection : List<CivicAddressType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public CivicAddressTypeCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public CivicAddressTypeCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public CivicAddressTypeCollection(IEnumerable<CivicAddressType> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator CivicAddressTypeCollection(CivicAddressType[] values)
        {
            if (values != null)
            {
                return new CivicAddressTypeCollection(values);
            }

            return new CivicAddressTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator CivicAddressType[](CivicAddressTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            CivicAddressTypeCollection clone = new CivicAddressTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((CivicAddressType)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region DhcpGeoConfCoordinate Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class DhcpGeoConfCoordinate : IEncodeable
    {
        #region Constructors
        public DhcpGeoConfCoordinate()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_LaRes = (byte)0;
            m_LatitudeInteger = (short)0;
            m_LatitudeFraction = (int)0;
            m_LoRes = (byte)0;
            m_LongitudeInteger = (short)0;
            m_LongitudeFraction = (int)0;
            m_AT = (byte)0;
            m_AltRes = (byte)0;
            m_AltitudeInteger = (int)0;
            m_AltitudeFraction = (short)0;
            m_Datum = (byte)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "LaRes", IsRequired = false, Order = 1)]
        public byte LaRes
        {
            get
            {
                return m_LaRes;
            }
            set
            {
                m_LaRes = value;
            }
        }
        [DataMember(Name = "LatitudeInteger", IsRequired = false, Order = 2)]
        public short LatitudeInteger
        {
            get
            {
                return m_LatitudeInteger;
            }
            set
            {
                m_LatitudeInteger = value;
            }
        }
        [DataMember(Name = "LatitudeFraction", IsRequired = false, Order = 3)]
        public int LatitudeFraction
        {
            get
            {
                return m_LatitudeFraction;
            }
            set
            {
                m_LatitudeFraction = value;
            }
        }
        [DataMember(Name = "LoRes", IsRequired = false, Order = 4)]
        public byte LoRes
        {
            get
            {
                return m_LoRes;
            }
            set
            {
                m_LoRes = value;
            }
        }
        [DataMember(Name = "LongitudeInteger", IsRequired = false, Order = 5)]
        public short LongitudeInteger
        {
            get
            {
                return m_LongitudeInteger;
            }
            set
            {
                m_LongitudeInteger = value;
            }
        }
        [DataMember(Name = "LongitudeFraction", IsRequired = false, Order = 6)]
        public int LongitudeFraction
        {
            get
            {
                return m_LongitudeFraction;
            }
            set
            {
                m_LongitudeFraction = value;
            }
        }
        [DataMember(Name = "AT", IsRequired = false, Order = 7)]
        public byte AT
        {
            get
            {
                return m_AT;
            }
            set
            {
                m_AT = value;
            }
        }
        [DataMember(Name = "AltRes", IsRequired = false, Order = 8)]
        public byte AltRes
        {
            get
            {
                return m_AltRes;
            }
            set
            {
                m_AltRes = value;
            }
        }
        [DataMember(Name = "AltitudeInteger", IsRequired = false, Order = 9)]
        public int AltitudeInteger
        {
            get
            {
                return m_AltitudeInteger;
            }
            set
            {
                m_AltitudeInteger = value;
            }
        }
        [DataMember(Name = "AltitudeFraction", IsRequired = false, Order = 10)]
        public short AltitudeFraction
        {
            get
            {
                return m_AltitudeFraction;
            }
            set
            {
                m_AltitudeFraction = value;
            }
        }
        [DataMember(Name = "Datum", IsRequired = false, Order = 11)]
        public byte Datum
        {
            get
            {
                return m_Datum;
            }
            set
            {
                m_Datum = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.DhcpGeoConfCoordinate; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.DhcpGeoConfCoordinate_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.DhcpGeoConfCoordinate_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteByte("LaRes", LaRes);
            encoder.WriteInt16("LatitudeInteger", LatitudeInteger);
            encoder.WriteInt32("LatitudeFraction", LatitudeFraction);
            encoder.WriteByte("LoRes", LoRes);
            encoder.WriteInt16("LongitudeInteger", LongitudeInteger);
            encoder.WriteInt32("LongitudeFraction", LongitudeFraction);
            encoder.WriteByte("AT", AT);
            encoder.WriteByte("AltRes", AltRes);
            encoder.WriteInt32("AltitudeInteger", AltitudeInteger);
            encoder.WriteInt16("AltitudeFraction", AltitudeFraction);
            encoder.WriteByte("Datum", Datum);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            LaRes = decoder.ReadByte("LaRes");
            LatitudeInteger = decoder.ReadInt16("LatitudeInteger");
            LatitudeFraction = decoder.ReadInt32("LatitudeFraction");
            LoRes = decoder.ReadByte("LoRes");
            LongitudeInteger = decoder.ReadInt16("LongitudeInteger");
            LongitudeFraction = decoder.ReadInt32("LongitudeFraction");
            AT = decoder.ReadByte("AT");
            AltRes = decoder.ReadByte("AltRes");
            AltitudeInteger = decoder.ReadInt32("AltitudeInteger");
            AltitudeFraction = decoder.ReadInt16("AltitudeFraction");
            Datum = decoder.ReadByte("Datum");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            DhcpGeoConfCoordinate value = encodeable as DhcpGeoConfCoordinate;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_LaRes, value.m_LaRes)) return false;
            if (!TypeUtils.IsEqual(m_LatitudeInteger, value.m_LatitudeInteger)) return false;
            if (!TypeUtils.IsEqual(m_LatitudeFraction, value.m_LatitudeFraction)) return false;
            if (!TypeUtils.IsEqual(m_LoRes, value.m_LoRes)) return false;
            if (!TypeUtils.IsEqual(m_LongitudeInteger, value.m_LongitudeInteger)) return false;
            if (!TypeUtils.IsEqual(m_LongitudeFraction, value.m_LongitudeFraction)) return false;
            if (!TypeUtils.IsEqual(m_AT, value.m_AT)) return false;
            if (!TypeUtils.IsEqual(m_AltRes, value.m_AltRes)) return false;
            if (!TypeUtils.IsEqual(m_AltitudeInteger, value.m_AltitudeInteger)) return false;
            if (!TypeUtils.IsEqual(m_AltitudeFraction, value.m_AltitudeFraction)) return false;
            if (!TypeUtils.IsEqual(m_Datum, value.m_Datum)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            DhcpGeoConfCoordinate clone = (DhcpGeoConfCoordinate)this.MemberwiseClone();

            clone.m_LaRes = (byte)TypeUtils.Clone(this.m_LaRes);
            clone.m_LatitudeInteger = (short)TypeUtils.Clone(this.m_LatitudeInteger);
            clone.m_LatitudeFraction = (int)TypeUtils.Clone(this.m_LatitudeFraction);
            clone.m_LoRes = (byte)TypeUtils.Clone(this.m_LoRes);
            clone.m_LongitudeInteger = (short)TypeUtils.Clone(this.m_LongitudeInteger);
            clone.m_LongitudeFraction = (int)TypeUtils.Clone(this.m_LongitudeFraction);
            clone.m_AT = (byte)TypeUtils.Clone(this.m_AT);
            clone.m_AltRes = (byte)TypeUtils.Clone(this.m_AltRes);
            clone.m_AltitudeInteger = (int)TypeUtils.Clone(this.m_AltitudeInteger);
            clone.m_AltitudeFraction = (short)TypeUtils.Clone(this.m_AltitudeFraction);
            clone.m_Datum = (byte)TypeUtils.Clone(this.m_Datum);

            return clone;
        }
        #endregion

        #region Private Fields
        private byte m_LaRes;
        private short m_LatitudeInteger;
        private int m_LatitudeFraction;
        private byte m_LoRes;
        private short m_LongitudeInteger;
        private int m_LongitudeFraction;
        private byte m_AT;
        private byte m_AltRes;
        private int m_AltitudeInteger;
        private short m_AltitudeFraction;
        private byte m_Datum;
        #endregion
    }

    #region DhcpGeoConfCoordinateCollection class
    /// <summary>
    /// A collection of DhcpGeoConfCoordinate objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfDhcpGeoConfCoordinate", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "DhcpGeoConfCoordinate")]
    public partial class DhcpGeoConfCoordinateCollection : List<DhcpGeoConfCoordinate>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public DhcpGeoConfCoordinateCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public DhcpGeoConfCoordinateCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public DhcpGeoConfCoordinateCollection(IEnumerable<DhcpGeoConfCoordinate> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator DhcpGeoConfCoordinateCollection(DhcpGeoConfCoordinate[] values)
        {
            if (values != null)
            {
                return new DhcpGeoConfCoordinateCollection(values);
            }

            return new DhcpGeoConfCoordinateCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator DhcpGeoConfCoordinate[](DhcpGeoConfCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            DhcpGeoConfCoordinateCollection clone = new DhcpGeoConfCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((DhcpGeoConfCoordinate)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region Local1DCoordinate Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class Local1DCoordinate : IEncodeable
    {
        #region Constructors
        public Local1DCoordinate()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Distance = 0.0;
            m_Timestamp = DateTime.MinValue;
            m_DilutionOfPrecision = 0.0;
            m_UsefulPrecision = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Distance", IsRequired = false, Order = 1)]
        public double Distance
        {
            get
            {
                return m_Distance;
            }
            set
            {
                m_Distance = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 2)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 3)]
        public double DilutionOfPrecision
        {
            get
            {
                return m_DilutionOfPrecision;
            }
            set
            {
                m_DilutionOfPrecision = value;
            }
        }
        [DataMember(Name = "UsefulPrecision", IsRequired = false, Order = 4)]
        public int UsefulPrecision
        {
            get
            {
                return m_UsefulPrecision;
            }
            set
            {
                m_UsefulPrecision = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.Local1DCoordinate; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.Local1DCoordinate_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.Local1DCoordinate_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteDouble("Distance", Distance);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecision", UsefulPrecision);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            Distance = decoder.ReadDouble("Distance");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecision = decoder.ReadInt32("UsefulPrecision");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Local1DCoordinate value = encodeable as Local1DCoordinate;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_Distance, value.m_Distance)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (!TypeUtils.IsEqual(m_DilutionOfPrecision, value.m_DilutionOfPrecision)) return false;
            if (!TypeUtils.IsEqual(m_UsefulPrecision, value.m_UsefulPrecision)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            Local1DCoordinate clone = (Local1DCoordinate)this.MemberwiseClone();

            clone.m_Distance = (double)TypeUtils.Clone(this.m_Distance);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_DilutionOfPrecision = (double)TypeUtils.Clone(this.m_DilutionOfPrecision);
            clone.m_UsefulPrecision = (int)TypeUtils.Clone(this.m_UsefulPrecision);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_Distance;
        private DateTime m_Timestamp;
        private double m_DilutionOfPrecision;
        private int m_UsefulPrecision;
        #endregion
    }

    #region Local1DCoordinateCollection class
    /// <summary>
    /// A collection of Local1DCoordinate objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfLocal1DCoordinate", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "Local1DCoordinate")]
    public partial class Local1DCoordinateCollection : List<Local1DCoordinate>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public Local1DCoordinateCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public Local1DCoordinateCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public Local1DCoordinateCollection(IEnumerable<Local1DCoordinate> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator Local1DCoordinateCollection(Local1DCoordinate[] values)
        {
            if (values != null)
            {
                return new Local1DCoordinateCollection(values);
            }

            return new Local1DCoordinateCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator Local1DCoordinate[](Local1DCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            Local1DCoordinateCollection clone = new Local1DCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Local1DCoordinate)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region LocalCoordinate Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class LocalCoordinate : IEncodeable
    {
        #region Constructors
        public LocalCoordinate()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_X = 0.0;
            m_Y = 0.0;
            m_Z = 0.0;
            m_Timestamp = DateTime.MinValue;
            m_DilutionOfPrecision = 0.0;
            m_UsefulPrecicision = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "X", IsRequired = false, Order = 1)]
        public double X
        {
            get
            {
                return m_X;
            }
            set
            {
                m_X = value;
            }
        }
        [DataMember(Name = "Y", IsRequired = false, Order = 2)]
        public double Y
        {
            get
            {
                return m_Y;
            }
            set
            {
                m_Y = value;
            }
        }
        [DataMember(Name = "Z", IsRequired = false, Order = 3)]
        public double Z
        {
            get
            {
                return m_Z;
            }
            set
            {
                m_Z = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 4)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 5)]
        public double DilutionOfPrecision
        {
            get
            {
                return m_DilutionOfPrecision;
            }
            set
            {
                m_DilutionOfPrecision = value;
            }
        }
        [DataMember(Name = "UsefulPrecicision", IsRequired = false, Order = 6)]
        public int UsefulPrecicision
        {
            get
            {
                return m_UsefulPrecicision;
            }
            set
            {
                m_UsefulPrecicision = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.LocalCoordinate; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.LocalCoordinate_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.LocalCoordinate_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteDouble("X", X);
            encoder.WriteDouble("Y", Y);
            encoder.WriteDouble("Z", Z);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecicision", UsefulPrecicision);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            X = decoder.ReadDouble("X");
            Y = decoder.ReadDouble("Y");
            Z = decoder.ReadDouble("Z");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecicision = decoder.ReadInt32("UsefulPrecicision");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            LocalCoordinate value = encodeable as LocalCoordinate;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_X, value.m_X)) return false;
            if (!TypeUtils.IsEqual(m_Y, value.m_Y)) return false;
            if (!TypeUtils.IsEqual(m_Z, value.m_Z)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (!TypeUtils.IsEqual(m_DilutionOfPrecision, value.m_DilutionOfPrecision)) return false;
            if (!TypeUtils.IsEqual(m_UsefulPrecicision, value.m_UsefulPrecicision)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            LocalCoordinate clone = (LocalCoordinate)this.MemberwiseClone();

            clone.m_X = (double)TypeUtils.Clone(this.m_X);
            clone.m_Y = (double)TypeUtils.Clone(this.m_Y);
            clone.m_Z = (double)TypeUtils.Clone(this.m_Z);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_DilutionOfPrecision = (double)TypeUtils.Clone(this.m_DilutionOfPrecision);
            clone.m_UsefulPrecicision = (int)TypeUtils.Clone(this.m_UsefulPrecicision);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_X;
        private double m_Y;
        private double m_Z;
        private DateTime m_Timestamp;
        private double m_DilutionOfPrecision;
        private int m_UsefulPrecicision;
        #endregion
    }

    #region LocalCoordinateCollection class
    /// <summary>
    /// A collection of LocalCoordinate objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfLocalCoordinate", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "LocalCoordinate")]
    public partial class LocalCoordinateCollection : List<LocalCoordinate>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public LocalCoordinateCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public LocalCoordinateCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public LocalCoordinateCollection(IEnumerable<LocalCoordinate> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator LocalCoordinateCollection(LocalCoordinate[] values)
        {
            if (values != null)
            {
                return new LocalCoordinateCollection(values);
            }

            return new LocalCoordinateCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator LocalCoordinate[](LocalCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            LocalCoordinateCollection clone = new LocalCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((LocalCoordinate)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region Position Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class Position : IEncodeable
    {
        #region Constructors
        public Position()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_PositionX = (int)0;
            m_PositionY = (int)0;
            m_SizeX = (int)0;
            m_SizeY = (int)0;
            m_Rotation = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "PositionX", IsRequired = false, Order = 1)]
        public int PositionX
        {
            get
            {
                return m_PositionX;
            }
            set
            {
                m_PositionX = value;
            }
        }
        [DataMember(Name = "PositionY", IsRequired = false, Order = 2)]
        public int PositionY
        {
            get
            {
                return m_PositionY;
            }
            set
            {
                m_PositionY = value;
            }
        }
        [DataMember(Name = "SizeX", IsRequired = false, Order = 3)]
        public int SizeX
        {
            get
            {
                return m_SizeX;
            }
            set
            {
                m_SizeX = value;
            }
        }
        [DataMember(Name = "SizeY", IsRequired = false, Order = 4)]
        public int SizeY
        {
            get
            {
                return m_SizeY;
            }
            set
            {
                m_SizeY = value;
            }
        }
        [DataMember(Name = "Rotation", IsRequired = false, Order = 5)]
        public int Rotation
        {
            get
            {
                return m_Rotation;
            }
            set
            {
                m_Rotation = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.Position; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.Position_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.Position_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteInt32("PositionX", PositionX);
            encoder.WriteInt32("PositionY", PositionY);
            encoder.WriteInt32("SizeX", SizeX);
            encoder.WriteInt32("SizeY", SizeY);
            encoder.WriteInt32("Rotation", Rotation);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            PositionX = decoder.ReadInt32("PositionX");
            PositionY = decoder.ReadInt32("PositionY");
            SizeX = decoder.ReadInt32("SizeX");
            SizeY = decoder.ReadInt32("SizeY");
            Rotation = decoder.ReadInt32("Rotation");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Position value = encodeable as Position;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_PositionX, value.m_PositionX)) return false;
            if (!TypeUtils.IsEqual(m_PositionY, value.m_PositionY)) return false;
            if (!TypeUtils.IsEqual(m_SizeX, value.m_SizeX)) return false;
            if (!TypeUtils.IsEqual(m_SizeY, value.m_SizeY)) return false;
            if (!TypeUtils.IsEqual(m_Rotation, value.m_Rotation)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            Position clone = (Position)this.MemberwiseClone();

            clone.m_PositionX = (int)TypeUtils.Clone(this.m_PositionX);
            clone.m_PositionY = (int)TypeUtils.Clone(this.m_PositionY);
            clone.m_SizeX = (int)TypeUtils.Clone(this.m_SizeX);
            clone.m_SizeY = (int)TypeUtils.Clone(this.m_SizeY);
            clone.m_Rotation = (int)TypeUtils.Clone(this.m_Rotation);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_PositionX;
        private int m_PositionY;
        private int m_SizeX;
        private int m_SizeY;
        private int m_Rotation;
        #endregion
    }

    #region PositionCollection class
    /// <summary>
    /// A collection of Position objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfPosition", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "Position")]
    public partial class PositionCollection : List<Position>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public PositionCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public PositionCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public PositionCollection(IEnumerable<Position> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator PositionCollection(Position[] values)
        {
            if (values != null)
            {
                return new PositionCollection(values);
            }

            return new PositionCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator Position[](PositionCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            PositionCollection clone = new PositionCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Position)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region RfidSighting Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class RfidSighting : IEncodeable
    {
        #region Constructors
        public RfidSighting()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Antenna = (int)0;
            m_Strength = (int)0;
            m_Timestamp = DateTime.MinValue;
            m_CurrentPowerLevel = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Antenna", IsRequired = false, Order = 1)]
        public int Antenna
        {
            get
            {
                return m_Antenna;
            }
            set
            {
                m_Antenna = value;
            }
        }
        [DataMember(Name = "Strength", IsRequired = false, Order = 2)]
        public int Strength
        {
            get
            {
                return m_Strength;
            }
            set
            {
                m_Strength = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 3)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "CurrentPowerLevel", IsRequired = false, Order = 4)]
        public int CurrentPowerLevel
        {
            get
            {
                return m_CurrentPowerLevel;
            }
            set
            {
                m_CurrentPowerLevel = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RfidSighting; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RfidSighting_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RfidSighting_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteInt32("Antenna", Antenna);
            encoder.WriteInt32("Strength", Strength);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteInt32("CurrentPowerLevel", CurrentPowerLevel);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            Antenna = decoder.ReadInt32("Antenna");
            Strength = decoder.ReadInt32("Strength");
            Timestamp = decoder.ReadDateTime("Timestamp");
            CurrentPowerLevel = decoder.ReadInt32("CurrentPowerLevel");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RfidSighting value = encodeable as RfidSighting;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_Antenna, value.m_Antenna)) return false;
            if (!TypeUtils.IsEqual(m_Strength, value.m_Strength)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (!TypeUtils.IsEqual(m_CurrentPowerLevel, value.m_CurrentPowerLevel)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            RfidSighting clone = (RfidSighting)this.MemberwiseClone();

            clone.m_Antenna = (int)TypeUtils.Clone(this.m_Antenna);
            clone.m_Strength = (int)TypeUtils.Clone(this.m_Strength);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_CurrentPowerLevel = (int)TypeUtils.Clone(this.m_CurrentPowerLevel);

            return clone;
        }
        #endregion

        #region Private Fields
        private int m_Antenna;
        private int m_Strength;
        private DateTime m_Timestamp;
        private int m_CurrentPowerLevel;
        #endregion
    }

    #region RfidSightingCollection class
    /// <summary>
    /// A collection of RfidSighting objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfRfidSighting", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "RfidSighting")]
    public partial class RfidSightingCollection : List<RfidSighting>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RfidSightingCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RfidSightingCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RfidSightingCollection(IEnumerable<RfidSighting> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RfidSightingCollection(RfidSighting[] values)
        {
            if (values != null)
            {
                return new RfidSightingCollection(values);
            }

            return new RfidSightingCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RfidSighting[](RfidSightingCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RfidSightingCollection clone = new RfidSightingCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidSighting)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region Rotation Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class Rotation : IEncodeable
    {
        #region Constructors
        public Rotation()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Yaw = 0.0;
            m_Pitch = 0.0;
            m_Roll = 0.0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Yaw", IsRequired = false, Order = 1)]
        public double Yaw
        {
            get
            {
                return m_Yaw;
            }
            set
            {
                m_Yaw = value;
            }
        }
        [DataMember(Name = "Pitch", IsRequired = false, Order = 2)]
        public double Pitch
        {
            get
            {
                return m_Pitch;
            }
            set
            {
                m_Pitch = value;
            }
        }
        [DataMember(Name = "Roll", IsRequired = false, Order = 3)]
        public double Roll
        {
            get
            {
                return m_Roll;
            }
            set
            {
                m_Roll = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.Rotation; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.Rotation_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.Rotation_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteDouble("Yaw", Yaw);
            encoder.WriteDouble("Pitch", Pitch);
            encoder.WriteDouble("Roll", Roll);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            Yaw = decoder.ReadDouble("Yaw");
            Pitch = decoder.ReadDouble("Pitch");
            Roll = decoder.ReadDouble("Roll");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Rotation value = encodeable as Rotation;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_Yaw, value.m_Yaw)) return false;
            if (!TypeUtils.IsEqual(m_Pitch, value.m_Pitch)) return false;
            if (!TypeUtils.IsEqual(m_Roll, value.m_Roll)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            Rotation clone = (Rotation)this.MemberwiseClone();

            clone.m_Yaw = (double)TypeUtils.Clone(this.m_Yaw);
            clone.m_Pitch = (double)TypeUtils.Clone(this.m_Pitch);
            clone.m_Roll = (double)TypeUtils.Clone(this.m_Roll);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_Yaw;
        private double m_Pitch;
        private double m_Roll;
        #endregion
    }

    #region RotationCollection class
    /// <summary>
    /// A collection of Rotation objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfRotation", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "Rotation")]
    public partial class RotationCollection : List<Rotation>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RotationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RotationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RotationCollection(IEnumerable<Rotation> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RotationCollection(Rotation[] values)
        {
            if (values != null)
            {
                return new RotationCollection(values);
            }

            return new RotationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator Rotation[](RotationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RotationCollection clone = new RotationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Rotation)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region ScanDataEpc Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class ScanDataEpc : IEncodeable
    {
        #region Constructors
        public ScanDataEpc()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_PC = (ushort)0;
            m_UId = null;
            m_XPC_W1 = (ushort)0;
            m_XPC_W2 = (ushort)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "PC", IsRequired = false, Order = 1)]
        public ushort PC
        {
            get
            {
                return m_PC;
            }
            set
            {
                m_PC = value;
            }
        }
        [DataMember(Name = "UId", IsRequired = false, Order = 2)]
        public byte[] UId
        {
            get
            {
                return m_UId;
            }
            set
            {
                m_UId = value;
            }
        }
        [DataMember(Name = "XPC_W1", IsRequired = false, Order = 3)]
        public ushort XPC_W1
        {
            get
            {
                return m_XPC_W1;
            }
            set
            {
                m_XPC_W1 = value;
            }
        }
        [DataMember(Name = "XPC_W2", IsRequired = false, Order = 4)]
        public ushort XPC_W2
        {
            get
            {
                return m_XPC_W2;
            }
            set
            {
                m_XPC_W2 = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ScanDataEpc; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ScanDataEpc_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ScanDataEpc_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteUInt16("PC", PC);
            encoder.WriteByteString("UId", UId);
            encoder.WriteUInt16("XPC_W1", XPC_W1);
            encoder.WriteUInt16("XPC_W2", XPC_W2);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            PC = decoder.ReadUInt16("PC");
            UId = decoder.ReadByteString("UId");
            XPC_W1 = decoder.ReadUInt16("XPC_W1");
            XPC_W2 = decoder.ReadUInt16("XPC_W2");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanDataEpc value = encodeable as ScanDataEpc;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_PC, value.m_PC)) return false;
            if (!TypeUtils.IsEqual(m_UId, value.m_UId)) return false;
            if (!TypeUtils.IsEqual(m_XPC_W1, value.m_XPC_W1)) return false;
            if (!TypeUtils.IsEqual(m_XPC_W2, value.m_XPC_W2)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            ScanDataEpc clone = (ScanDataEpc)this.MemberwiseClone();

            clone.m_PC = (ushort)TypeUtils.Clone(this.m_PC);
            clone.m_UId = (byte[])TypeUtils.Clone(this.m_UId);
            clone.m_XPC_W1 = (ushort)TypeUtils.Clone(this.m_XPC_W1);
            clone.m_XPC_W2 = (ushort)TypeUtils.Clone(this.m_XPC_W2);

            return clone;
        }
        #endregion

        #region Private Fields
        private ushort m_PC;
        private byte[] m_UId;
        private ushort m_XPC_W1;
        private ushort m_XPC_W2;
        #endregion
    }

    #region ScanDataEpcCollection class
    /// <summary>
    /// A collection of ScanDataEpc objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfScanDataEpc", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "ScanDataEpc")]
    public partial class ScanDataEpcCollection : List<ScanDataEpc>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ScanDataEpcCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ScanDataEpcCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ScanDataEpcCollection(IEnumerable<ScanDataEpc> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ScanDataEpcCollection(ScanDataEpc[] values)
        {
            if (values != null)
            {
                return new ScanDataEpcCollection(values);
            }

            return new ScanDataEpcCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ScanDataEpc[](ScanDataEpcCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            ScanDataEpcCollection clone = new ScanDataEpcCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanDataEpc)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region ScanResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class ScanResult : IEncodeable
    {
        #region Optional Members
        [Flags]
        private enum ScanResultSet
        {
            Location = 1,
        }
        #endregion

        #region Constructors
        public ScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_encodingMask = 0;
            m_CodeType = null;
            m_ScanData = null;
            m_Timestamp = DateTime.MinValue;
            m_Location = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = false, Order = 1)]
        private uint EncodingMask
        {
            get
            {
                return m_encodingMask;
            }
            set
            {
                m_encodingMask = value;
            }
        }

        [DataMember(Name = "CodeType", IsRequired = false, Order = 2)]
        public string CodeType
        {
            get
            {
                return m_CodeType;
            }
            set
            {
                m_CodeType = value;
            }
        }
        [DataMember(Name = "ScanData", IsRequired = false, Order = 3)]
        public ScanData ScanData
        {
            get
            {
                return m_ScanData;
            }
            set
            {
                m_ScanData = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 4)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "Location", IsRequired = false, Order = 5)]
        public Location Location
        {
            get
            {
                return m_Location;
            }
            set
            {
                m_Location = value;
                m_encodingMask |= (uint)ScanResultSet.Location;
            }
        }

        public bool IsLocationSet()
        {
            return (m_encodingMask & (uint)ScanResultSet.Location) != 0;
        }

        public void UnsetLocation()
        {
            m_encodingMask &= (~((uint)ScanResultSet.Location));
            m_Location = null;
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ScanResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ScanResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ScanResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteUInt32("EncodingMask", (uint)m_encodingMask);

            encoder.WriteString("CodeType", CodeType);
            encoder.WriteEncodeable("ScanData", ScanData, typeof(ScanData));
            encoder.WriteDateTime("Timestamp", Timestamp);
            if (IsLocationSet())
            {
                encoder.WriteEncodeable("Location", Location, typeof(Location));
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);

            m_encodingMask = decoder.ReadUInt32("EncodingMask");

            CodeType = decoder.ReadString("CodeType");
            ScanData = (ScanData)decoder.ReadEncodeable("ScanData", typeof(ScanData));
            Timestamp = decoder.ReadDateTime("Timestamp");
            if (IsLocationSet())
            {
                Location = (Location)decoder.ReadEncodeable("Location", typeof(Location));
            }

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanResult value = encodeable as ScanResult;

            if (value == null)
            {
                return false;
            }
            if (m_encodingMask != value.m_encodingMask) return false;
            if (!TypeUtils.IsEqual(m_CodeType, value.m_CodeType)) return false;
            if (!TypeUtils.IsEqual(m_ScanData, value.m_ScanData)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (IsLocationSet())
            {
                if (!TypeUtils.IsEqual(m_Location, value.m_Location)) return false;
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            ScanResult clone = (ScanResult)this.MemberwiseClone();

            clone.m_encodingMask = m_encodingMask;
            clone.m_CodeType = (string)TypeUtils.Clone(this.m_CodeType);
            clone.m_ScanData = (ScanData)TypeUtils.Clone(this.m_ScanData);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_Location = (Location)TypeUtils.Clone(this.m_Location);

            return clone;
        }
        #endregion

        #region Private Fields
        protected uint m_encodingMask;
        private string m_CodeType;
        private ScanData m_ScanData;
        private DateTime m_Timestamp;
        private Location m_Location;
        #endregion
    }

    #region ScanResultCollection class
    /// <summary>
    /// A collection of ScanResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfScanResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "ScanResult")]
    public partial class ScanResultCollection : List<ScanResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ScanResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ScanResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ScanResultCollection(IEnumerable<ScanResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ScanResultCollection(ScanResult[] values)
        {
            if (values != null)
            {
                return new ScanResultCollection(values);
            }

            return new ScanResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ScanResult[](ScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            ScanResultCollection clone = new ScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region OcrScanResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class OcrScanResult : ScanResult
    {
        #region Optional Members
        [Flags]
        private enum OcrScanResultSet
        {
            Location = 1,
            Font = 2,
            DecodingTime = 4,
        }
        #endregion

        #region Constructors
        public OcrScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_encodingMask = 0;
            m_ImageId = null;
            m_Quality = (byte)0;
            m_Position = null;
            m_Font = null;
            m_DecodingTime = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "ImageId", IsRequired = false, Order = 1)]
        public NodeId ImageId
        {
            get
            {
                return m_ImageId;
            }
            set
            {
                m_ImageId = value;
            }
        }
        [DataMember(Name = "Quality", IsRequired = false, Order = 2)]
        public byte Quality
        {
            get
            {
                return m_Quality;
            }
            set
            {
                m_Quality = value;
            }
        }
        [DataMember(Name = "Position", IsRequired = false, Order = 3)]
        public Position Position
        {
            get
            {
                return m_Position;
            }
            set
            {
                m_Position = value;
            }
        }
        [DataMember(Name = "Font", IsRequired = false, Order = 4)]
        public string Font
        {
            get
            {
                return m_Font;
            }
            set
            {
                m_Font = value;
                m_encodingMask |= (uint)OcrScanResultSet.Font;
            }
        }
        [DataMember(Name = "DecodingTime", IsRequired = false, Order = 5)]
        public DateTime? DecodingTime
        {
            get
            {
                return m_DecodingTime;
            }
            set
            {
                m_DecodingTime = value;
                m_encodingMask |= (uint)OcrScanResultSet.DecodingTime;
            }
        }

        public bool IsFontSet()
        {
            return (m_encodingMask & (uint)OcrScanResultSet.Font) != 0;
        }

        public void UnsetFont()
        {
            m_encodingMask &= (~((uint)OcrScanResultSet.Font));
            m_Font = null;
        }

        public bool IsDecodingTimeSet()
        {
            return (m_encodingMask & (uint)OcrScanResultSet.DecodingTime) != 0;
        }

        public void UnsetDecodingTime()
        {
            m_encodingMask &= (~((uint)OcrScanResultSet.DecodingTime));
            m_DecodingTime = null;
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OcrScanResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OcrScanResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OcrScanResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteNodeId("ImageId", ImageId);
            encoder.WriteByte("Quality", Quality);
            encoder.WriteEncodeable("Position", Position, typeof(Position));
            if (IsFontSet())
            {
                encoder.WriteString("Font", Font);
            }
            if (IsDecodingTimeSet())
            {
                encoder.WriteDateTime("DecodingTime", DecodingTime.Value);
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Namespaces.AutoIdXsd);
            ImageId = decoder.ReadNodeId("ImageId");
            Quality = decoder.ReadByte("Quality");
            Position = (Position)decoder.ReadEncodeable("Position", typeof(Position));
            if (IsFontSet())
            {
                Font = decoder.ReadString("Font");
            }
            if (IsDecodingTimeSet())
            {
                DecodingTime = decoder.ReadDateTime("DecodingTime");
            }

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OcrScanResult value = encodeable as OcrScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_ImageId, value.m_ImageId)) return false;
            if (!TypeUtils.IsEqual(m_Quality, value.m_Quality)) return false;
            if (!TypeUtils.IsEqual(m_Position, value.m_Position)) return false;
            if (IsFontSet())
            {
                if (!TypeUtils.IsEqual(m_Font, value.m_Font)) return false;
            }
            if (IsDecodingTimeSet())
            {
                if (!TypeUtils.IsEqual(m_DecodingTime, value.m_DecodingTime)) return false;
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            OcrScanResult clone = (OcrScanResult)base.Clone();

            clone.m_ImageId = (NodeId)TypeUtils.Clone(this.m_ImageId);
            clone.m_Quality = (byte)TypeUtils.Clone(this.m_Quality);
            clone.m_Position = (Position)TypeUtils.Clone(this.m_Position);
            clone.m_Font = (string)TypeUtils.Clone(this.m_Font);
            clone.m_DecodingTime = (DateTime)TypeUtils.Clone(this.m_DecodingTime);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_ImageId;
        private byte m_Quality;
        private Position m_Position;
        private string m_Font;
        private DateTime? m_DecodingTime;
        #endregion
    }

    #region OcrScanResultCollection class
    /// <summary>
    /// A collection of OcrScanResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfOcrScanResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "OcrScanResult")]
    public partial class OcrScanResultCollection : List<OcrScanResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OcrScanResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OcrScanResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OcrScanResultCollection(IEnumerable<OcrScanResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OcrScanResultCollection(OcrScanResult[] values)
        {
            if (values != null)
            {
                return new OcrScanResultCollection(values);
            }

            return new OcrScanResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OcrScanResult[](OcrScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            OcrScanResultCollection clone = new OcrScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OcrScanResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region OpticalScanResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class OpticalScanResult : ScanResult
    {
        #region Optional Members
        [Flags]
        private enum OpticalScanResultSet
        {
            Location = 1,
            Grade = 2,
            Position = 4,
            Symbology = 8,
        }
        #endregion

        #region Constructors
        public OpticalScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_encodingMask = 0;
            m_Grade = null;
            m_Position = null;
            m_Symbology = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Grade", IsRequired = false, Order = 1)]
        public float? Grade
        {
            get
            {
                return m_Grade;
            }
            set
            {
                m_Grade = value;
                m_encodingMask |= (uint)OpticalScanResultSet.Grade;
            }
        }
        [DataMember(Name = "Position", IsRequired = false, Order = 2)]
        public Position Position
        {
            get
            {
                return m_Position;
            }
            set
            {
                m_Position = value;
                m_encodingMask |= (uint)OpticalScanResultSet.Position;
            }
        }
        [DataMember(Name = "Symbology", IsRequired = false, Order = 3)]
        public string Symbology
        {
            get
            {
                return m_Symbology;
            }
            set
            {
                m_Symbology = value;
                m_encodingMask |= (uint)OpticalScanResultSet.Symbology;
            }
        }

        public bool IsGradeSet()
        {
            return (m_encodingMask & (uint)OpticalScanResultSet.Grade) != 0;
        }

        public void UnsetGrade()
        {
            m_encodingMask &= (~((uint)OpticalScanResultSet.Grade));
            m_Grade = null;
        }

        public bool IsPositionSet()
        {
            return (m_encodingMask & (uint)OpticalScanResultSet.Position) != 0;
        }

        public void UnsetPosition()
        {
            m_encodingMask &= (~((uint)OpticalScanResultSet.Position));
            m_Position = null;
        }

        public bool IsSymbologySet()
        {
            return (m_encodingMask & (uint)OpticalScanResultSet.Symbology) != 0;
        }

        public void UnsetSymbology()
        {
            m_encodingMask &= (~((uint)OpticalScanResultSet.Symbology));
            m_Symbology = null;
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OpticalScanResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OpticalScanResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OpticalScanResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Namespaces.AutoIdXsd);

            if (IsGradeSet())
            {
                encoder.WriteFloat("Grade", Grade.Value);
            }
            if (IsPositionSet())
            {
                encoder.WriteEncodeable("Position", Position, typeof(Position));
            }
            if (IsSymbologySet())
            {
                encoder.WriteString("Symbology", Symbology);
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Namespaces.AutoIdXsd);
            if (IsGradeSet())
            {
                Grade = decoder.ReadFloat("Grade");
            }
            if (IsPositionSet())
            {
                Position = (Position)decoder.ReadEncodeable("Position", typeof(Position));
            }
            if (IsSymbologySet())
            {
                Symbology = decoder.ReadString("Symbology");
            }

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OpticalScanResult value = encodeable as OpticalScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (IsGradeSet())
            {
                if (!TypeUtils.IsEqual(m_Grade, value.m_Grade)) return false;
            }
            if (IsPositionSet())
            {
                if (!TypeUtils.IsEqual(m_Position, value.m_Position)) return false;
            }
            if (IsSymbologySet())
            {
                if (!TypeUtils.IsEqual(m_Symbology, value.m_Symbology)) return false;
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            OpticalScanResult clone = (OpticalScanResult)base.Clone();

            clone.m_Grade = (float)TypeUtils.Clone(this.m_Grade);
            clone.m_Position = (Position)TypeUtils.Clone(this.m_Position);
            clone.m_Symbology = (string)TypeUtils.Clone(this.m_Symbology);

            return clone;
        }
        #endregion

        #region Private Fields
        private float? m_Grade;
        private Position m_Position;
        private string m_Symbology;
        #endregion
    }

    #region OpticalScanResultCollection class
    /// <summary>
    /// A collection of OpticalScanResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfOpticalScanResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "OpticalScanResult")]
    public partial class OpticalScanResultCollection : List<OpticalScanResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OpticalScanResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OpticalScanResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OpticalScanResultCollection(IEnumerable<OpticalScanResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OpticalScanResultCollection(OpticalScanResult[] values)
        {
            if (values != null)
            {
                return new OpticalScanResultCollection(values);
            }

            return new OpticalScanResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OpticalScanResult[](OpticalScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            OpticalScanResultCollection clone = new OpticalScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OpticalScanResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region OpticalVerifierScanResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class OpticalVerifierScanResult : ScanResult
    {
        #region Constructors
        public OpticalVerifierScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_IsoGrade = null;
            m_RMin = (short)0;
            m_SymbolContrast = (short)0;
            m_ECMin = (short)0;
            m_Modulation = (short)0;
            m_Defects = (short)0;
            m_Decodability = (short)0;
            m_Decode_ = (short)0;
            m_PrintGain = (short)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "IsoGrade", IsRequired = false, Order = 1)]
        public string IsoGrade
        {
            get
            {
                return m_IsoGrade;
            }
            set
            {
                m_IsoGrade = value;
            }
        }
        [DataMember(Name = "RMin", IsRequired = false, Order = 2)]
        public short RMin
        {
            get
            {
                return m_RMin;
            }
            set
            {
                m_RMin = value;
            }
        }
        [DataMember(Name = "SymbolContrast", IsRequired = false, Order = 3)]
        public short SymbolContrast
        {
            get
            {
                return m_SymbolContrast;
            }
            set
            {
                m_SymbolContrast = value;
            }
        }
        [DataMember(Name = "ECMin", IsRequired = false, Order = 4)]
        public short ECMin
        {
            get
            {
                return m_ECMin;
            }
            set
            {
                m_ECMin = value;
            }
        }
        [DataMember(Name = "Modulation", IsRequired = false, Order = 5)]
        public short Modulation
        {
            get
            {
                return m_Modulation;
            }
            set
            {
                m_Modulation = value;
            }
        }
        [DataMember(Name = "Defects", IsRequired = false, Order = 6)]
        public short Defects
        {
            get
            {
                return m_Defects;
            }
            set
            {
                m_Defects = value;
            }
        }
        [DataMember(Name = "Decodability", IsRequired = false, Order = 7)]
        public short Decodability
        {
            get
            {
                return m_Decodability;
            }
            set
            {
                m_Decodability = value;
            }
        }
        [DataMember(Name = "Decode_", IsRequired = false, Order = 8)]
        public short Decode_
        {
            get
            {
                return m_Decode_;
            }
            set
            {
                m_Decode_ = value;
            }
        }
        [DataMember(Name = "PrintGain", IsRequired = false, Order = 9)]
        public short PrintGain
        {
            get
            {
                return m_PrintGain;
            }
            set
            {
                m_PrintGain = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.OpticalVerifierScanResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.OpticalVerifierScanResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.OpticalVerifierScanResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteString("IsoGrade", IsoGrade);
            encoder.WriteInt16("RMin", RMin);
            encoder.WriteInt16("SymbolContrast", SymbolContrast);
            encoder.WriteInt16("ECMin", ECMin);
            encoder.WriteInt16("Modulation", Modulation);
            encoder.WriteInt16("Defects", Defects);
            encoder.WriteInt16("Decodability", Decodability);
            encoder.WriteInt16("Decode_", Decode_);
            encoder.WriteInt16("PrintGain", PrintGain);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Namespaces.AutoIdXsd);
            IsoGrade = decoder.ReadString("IsoGrade");
            RMin = decoder.ReadInt16("RMin");
            SymbolContrast = decoder.ReadInt16("SymbolContrast");
            ECMin = decoder.ReadInt16("ECMin");
            Modulation = decoder.ReadInt16("Modulation");
            Defects = decoder.ReadInt16("Defects");
            Decodability = decoder.ReadInt16("Decodability");
            Decode_ = decoder.ReadInt16("Decode_");
            PrintGain = decoder.ReadInt16("PrintGain");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            OpticalVerifierScanResult value = encodeable as OpticalVerifierScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_IsoGrade, value.m_IsoGrade)) return false;
            if (!TypeUtils.IsEqual(m_RMin, value.m_RMin)) return false;
            if (!TypeUtils.IsEqual(m_SymbolContrast, value.m_SymbolContrast)) return false;
            if (!TypeUtils.IsEqual(m_ECMin, value.m_ECMin)) return false;
            if (!TypeUtils.IsEqual(m_Modulation, value.m_Modulation)) return false;
            if (!TypeUtils.IsEqual(m_Defects, value.m_Defects)) return false;
            if (!TypeUtils.IsEqual(m_Decodability, value.m_Decodability)) return false;
            if (!TypeUtils.IsEqual(m_Decode_, value.m_Decode_)) return false;
            if (!TypeUtils.IsEqual(m_PrintGain, value.m_PrintGain)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            OpticalVerifierScanResult clone = (OpticalVerifierScanResult)base.Clone();

            clone.m_IsoGrade = (string)TypeUtils.Clone(this.m_IsoGrade);
            clone.m_RMin = (short)TypeUtils.Clone(this.m_RMin);
            clone.m_SymbolContrast = (short)TypeUtils.Clone(this.m_SymbolContrast);
            clone.m_ECMin = (short)TypeUtils.Clone(this.m_ECMin);
            clone.m_Modulation = (short)TypeUtils.Clone(this.m_Modulation);
            clone.m_Defects = (short)TypeUtils.Clone(this.m_Defects);
            clone.m_Decodability = (short)TypeUtils.Clone(this.m_Decodability);
            clone.m_Decode_ = (short)TypeUtils.Clone(this.m_Decode_);
            clone.m_PrintGain = (short)TypeUtils.Clone(this.m_PrintGain);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_IsoGrade;
        private short m_RMin;
        private short m_SymbolContrast;
        private short m_ECMin;
        private short m_Modulation;
        private short m_Defects;
        private short m_Decodability;
        private short m_Decode_;
        private short m_PrintGain;
        #endregion
    }

    #region OpticalVerifierScanResultCollection class
    /// <summary>
    /// A collection of OpticalVerifierScanResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfOpticalVerifierScanResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "OpticalVerifierScanResult")]
    public partial class OpticalVerifierScanResultCollection : List<OpticalVerifierScanResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public OpticalVerifierScanResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public OpticalVerifierScanResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public OpticalVerifierScanResultCollection(IEnumerable<OpticalVerifierScanResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator OpticalVerifierScanResultCollection(OpticalVerifierScanResult[] values)
        {
            if (values != null)
            {
                return new OpticalVerifierScanResultCollection(values);
            }

            return new OpticalVerifierScanResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator OpticalVerifierScanResult[](OpticalVerifierScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            OpticalVerifierScanResultCollection clone = new OpticalVerifierScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((OpticalVerifierScanResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region RfidScanResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class RfidScanResult : ScanResult
    {
        #region Constructors
        public RfidScanResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Sighting = new RfidSightingCollection();
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Sighting", IsRequired = false, Order = 1)]
        public RfidSightingCollection Sighting
        {
            get
            {
                return m_Sighting;
            }
            set
            {
                m_Sighting = value;

                if (value == null)
                {
                    m_Sighting = new RfidSightingCollection();
                }
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RfidScanResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RfidScanResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RfidScanResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteEncodeableArray("Sighting", Sighting.ToArray(), typeof(RfidSighting));

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Namespaces.AutoIdXsd);
            Sighting = (RfidSightingCollection)decoder.ReadEncodeableArray("Sighting", typeof(RfidSighting));

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RfidScanResult value = encodeable as RfidScanResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_Sighting, value.m_Sighting)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            RfidScanResult clone = (RfidScanResult)base.Clone();

            clone.m_Sighting = (RfidSightingCollection)TypeUtils.Clone(this.m_Sighting);

            return clone;
        }
        #endregion

        #region Private Fields
        private RfidSightingCollection m_Sighting;
        #endregion
    }

    #region RfidScanResultCollection class
    /// <summary>
    /// A collection of RfidScanResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfRfidScanResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "RfidScanResult")]
    public partial class RfidScanResultCollection : List<RfidScanResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RfidScanResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RfidScanResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RfidScanResultCollection(IEnumerable<RfidScanResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RfidScanResultCollection(RfidScanResult[] values)
        {
            if (values != null)
            {
                return new RfidScanResultCollection(values);
            }

            return new RfidScanResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RfidScanResult[](RfidScanResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RfidScanResultCollection clone = new RfidScanResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RfidScanResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region RtlsLocationResult Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class RtlsLocationResult : ScanResult
    {
        #region Constructors
        public RtlsLocationResult()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Speed = 0.0;
            m_Heading = 0.0;
            m_Rotation = null;
            m_ReceiveTime = DateTime.MinValue;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "Speed", IsRequired = false, Order = 1)]
        public double Speed
        {
            get
            {
                return m_Speed;
            }
            set
            {
                m_Speed = value;
            }
        }
        [DataMember(Name = "Heading", IsRequired = false, Order = 2)]
        public double Heading
        {
            get
            {
                return m_Heading;
            }
            set
            {
                m_Heading = value;
            }
        }
        [DataMember(Name = "Rotation", IsRequired = false, Order = 3)]
        public Rotation Rotation
        {
            get
            {
                return m_Rotation;
            }
            set
            {
                m_Rotation = value;
            }
        }
        [DataMember(Name = "ReceiveTime", IsRequired = false, Order = 4)]
        public DateTime ReceiveTime
        {
            get
            {
                return m_ReceiveTime;
            }
            set
            {
                m_ReceiveTime = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RtlsLocationResult; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RtlsLocationResult_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RtlsLocationResult_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            base.Encode(encoder);

            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteDouble("Speed", Speed);
            encoder.WriteDouble("Heading", Heading);
            encoder.WriteEncodeable("Rotation", Rotation, typeof(Rotation));
            encoder.WriteDateTime("ReceiveTime", ReceiveTime);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            base.Decode(decoder);

            decoder.PushNamespace(Namespaces.AutoIdXsd);
            Speed = decoder.ReadDouble("Speed");
            Heading = decoder.ReadDouble("Heading");
            Rotation = (Rotation)decoder.ReadEncodeable("Rotation", typeof(Rotation));
            ReceiveTime = decoder.ReadDateTime("ReceiveTime");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RtlsLocationResult value = encodeable as RtlsLocationResult;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_Speed, value.m_Speed)) return false;
            if (!TypeUtils.IsEqual(m_Heading, value.m_Heading)) return false;
            if (!TypeUtils.IsEqual(m_Rotation, value.m_Rotation)) return false;
            if (!TypeUtils.IsEqual(m_ReceiveTime, value.m_ReceiveTime)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            RtlsLocationResult clone = (RtlsLocationResult)base.Clone();

            clone.m_Speed = (double)TypeUtils.Clone(this.m_Speed);
            clone.m_Heading = (double)TypeUtils.Clone(this.m_Heading);
            clone.m_Rotation = (Rotation)TypeUtils.Clone(this.m_Rotation);
            clone.m_ReceiveTime = (DateTime)TypeUtils.Clone(this.m_ReceiveTime);

            return clone;
        }
        #endregion

        #region Private Fields
        private double m_Speed;
        private double m_Heading;
        private Rotation m_Rotation;
        private DateTime m_ReceiveTime;
        #endregion
    }

    #region RtlsLocationResultCollection class
    /// <summary>
    /// A collection of RtlsLocationResult objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfRtlsLocationResult", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "RtlsLocationResult")]
    public partial class RtlsLocationResultCollection : List<RtlsLocationResult>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RtlsLocationResultCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RtlsLocationResultCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RtlsLocationResultCollection(IEnumerable<RtlsLocationResult> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RtlsLocationResultCollection(RtlsLocationResult[] values)
        {
            if (values != null)
            {
                return new RtlsLocationResultCollection(values);
            }

            return new RtlsLocationResultCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RtlsLocationResult[](RtlsLocationResultCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RtlsLocationResultCollection clone = new RtlsLocationResultCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RtlsLocationResult)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region ScanSettings Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class ScanSettings : IEncodeable
    {
        #region Optional Members
        [Flags]
        private enum ScanSettingsSet
        {
            LocationType = 1,
        }
        #endregion

        #region Constructors
        public ScanSettings()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_encodingMask = 0;
            m_Duration = 0.0;
            m_Cycles = (int)0;
            m_DataAvailable = false;
            m_LocationType = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "EncodingMask", IsRequired = false, Order = 1)]
        private uint EncodingMask
        {
            get
            {
                return m_encodingMask;
            }
            set
            {
                m_encodingMask = value;
            }
        }

        [DataMember(Name = "Duration", IsRequired = false, Order = 2)]
        public double Duration
        {
            get
            {
                return m_Duration;
            }
            set
            {
                m_Duration = value;
            }
        }
        [DataMember(Name = "Cycles", IsRequired = false, Order = 3)]
        public int Cycles
        {
            get
            {
                return m_Cycles;
            }
            set
            {
                m_Cycles = value;
            }
        }
        [DataMember(Name = "DataAvailable", IsRequired = false, Order = 4)]
        public bool DataAvailable
        {
            get
            {
                return m_DataAvailable;
            }
            set
            {
                m_DataAvailable = value;
            }
        }
        [DataMember(Name = "LocationType", IsRequired = false, Order = 5)]
        public LocationTypeEnumeration? LocationType
        {
            get
            {
                return m_LocationType;
            }
            set
            {
                m_LocationType = value;
                m_encodingMask |= (uint)ScanSettingsSet.LocationType;
            }
        }

        public bool IsLocationTypeSet()
        {
            return (m_encodingMask & (uint)ScanSettingsSet.LocationType) != 0;
        }

        public void UnsetLocationType()
        {
            m_encodingMask &= (~((uint)ScanSettingsSet.LocationType));
            m_LocationType = null;
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ScanSettings; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ScanSettings_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ScanSettings_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteUInt32("EncodingMask", (uint)m_encodingMask);

            encoder.WriteDouble("Duration", Duration);
            encoder.WriteInt32("Cycles", Cycles);
            encoder.WriteBoolean("DataAvailable", DataAvailable);
            if (IsLocationTypeSet())
            {
                encoder.WriteEnumerated("LocationType", LocationType.Value);
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);

            m_encodingMask = decoder.ReadUInt32("EncodingMask");

            Duration = decoder.ReadDouble("Duration");
            Cycles = decoder.ReadInt32("Cycles");
            DataAvailable = decoder.ReadBoolean("DataAvailable");
            if (IsLocationTypeSet())
            {
                LocationType = (LocationTypeEnumeration)decoder.ReadEnumerated("LocationType", typeof(LocationTypeEnumeration));
            }

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanSettings value = encodeable as ScanSettings;

            if (value == null)
            {
                return false;
            }
            if (m_encodingMask != value.m_encodingMask) return false;
            if (!TypeUtils.IsEqual(m_Duration, value.m_Duration)) return false;
            if (!TypeUtils.IsEqual(m_Cycles, value.m_Cycles)) return false;
            if (!TypeUtils.IsEqual(m_DataAvailable, value.m_DataAvailable)) return false;
            if (IsLocationTypeSet())
            {
                if (!TypeUtils.IsEqual(m_LocationType, value.m_LocationType)) return false;
            }

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            ScanSettings clone = (ScanSettings)this.MemberwiseClone();

            clone.m_encodingMask = m_encodingMask;
            clone.m_Duration = (double)TypeUtils.Clone(this.m_Duration);
            clone.m_Cycles = (int)TypeUtils.Clone(this.m_Cycles);
            clone.m_DataAvailable = (bool)TypeUtils.Clone(this.m_DataAvailable);
            clone.m_LocationType = (LocationTypeEnumeration)TypeUtils.Clone(this.m_LocationType);

            return clone;
        }
        #endregion

        #region Private Fields
        protected uint m_encodingMask;
        private double m_Duration;
        private int m_Cycles;
        private bool m_DataAvailable;
        private LocationTypeEnumeration? m_LocationType;
        #endregion
    }

    #region ScanSettingsCollection class
    /// <summary>
    /// A collection of ScanSettings objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfScanSettings", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "ScanSettings")]
    public partial class ScanSettingsCollection : List<ScanSettings>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ScanSettingsCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ScanSettingsCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ScanSettingsCollection(IEnumerable<ScanSettings> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ScanSettingsCollection(ScanSettings[] values)
        {
            if (values != null)
            {
                return new ScanSettingsCollection(values);
            }

            return new ScanSettingsCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ScanSettings[](ScanSettingsCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            ScanSettingsCollection clone = new ScanSettingsCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanSettings)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region Location Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class Location : UnifiedAutomation.UaBase.Union
    {
        #region Union Type
        public enum LocationType
        {
            Null = 0,
            NMEA = 1,
            UTM = 2,
            Local = 3,
            Local1D = 4,
            WGS84 = 5,
            Name = 6,
            LCI_DHCP = 7,
            Civic_Address = 8,
        }
        #endregion

        #region Constructors
        public Location()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_switchField = LocationType.Null;
            m_value = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "SwitchField", IsRequired = false, Order = 1)]
        private uint SwitchField
        {
            get
            {
                return (uint)m_switchField;
            }
            set
            {
                m_switchField = (LocationType)value;
            }
        }

        public LocationType Type
        {
            get { return m_switchField; }
        }

        public object Value
        {
            get { return m_value; }
        }

        [DataMember(Name = "NMEA", IsRequired = false, Order = 2)]
        public string NMEA
        {
            get
            {
                if (m_switchField == LocationType.NMEA)
                {
                    return (string)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.NMEA;
            }
        }

        [DataMember(Name = "UTM", IsRequired = false, Order = 2)]
        public UtmCoordinate UTM
        {
            get
            {
                if (m_switchField == LocationType.UTM)
                {
                    return (UtmCoordinate)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.UTM;
            }
        }

        [DataMember(Name = "Local", IsRequired = false, Order = 2)]
        public LocalCoordinate Local
        {
            get
            {
                if (m_switchField == LocationType.Local)
                {
                    return (LocalCoordinate)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.Local;
            }
        }

        [DataMember(Name = "Local1D", IsRequired = false, Order = 2)]
        public Local1DCoordinate Local1D
        {
            get
            {
                if (m_switchField == LocationType.Local1D)
                {
                    return (Local1DCoordinate)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.Local1D;
            }
        }

        [DataMember(Name = "WGS84", IsRequired = false, Order = 2)]
        public WGS84Coordinate WGS84
        {
            get
            {
                if (m_switchField == LocationType.WGS84)
                {
                    return (WGS84Coordinate)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.WGS84;
            }
        }

        [DataMember(Name = "Name", IsRequired = false, Order = 2)]
        public string Name
        {
            get
            {
                if (m_switchField == LocationType.Name)
                {
                    return (string)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.Name;
            }
        }

        [DataMember(Name = "LCI_DHCP", IsRequired = false, Order = 2)]
        public DhcpGeoConfCoordinate LCI_DHCP
        {
            get
            {
                if (m_switchField == LocationType.LCI_DHCP)
                {
                    return (DhcpGeoConfCoordinate)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.LCI_DHCP;
            }
        }

        [DataMember(Name = "Civic_Address", IsRequired = false, Order = 2)]
        public CivicAddressType Civic_Address
        {
            get
            {
                if (m_switchField == LocationType.Civic_Address)
                {
                    return (CivicAddressType)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = LocationType.Civic_Address;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.Location; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.Location_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.Location_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteUInt32("SwitchField", (uint)m_switchField);

            switch (m_switchField)
            {
                case LocationType.Null:
                    break;
                case LocationType.NMEA:
                    encoder.WriteString("NMEA", (string)m_value);
                    break;
                case LocationType.UTM:
                    encoder.WriteEncodeable("UTM", (UtmCoordinate)m_value, typeof(UtmCoordinate));
                    break;
                case LocationType.Local:
                    encoder.WriteEncodeable("Local", (LocalCoordinate)m_value, typeof(LocalCoordinate));
                    break;
                case LocationType.Local1D:
                    encoder.WriteEncodeable("Local1D", (Local1DCoordinate)m_value, typeof(Local1DCoordinate));
                    break;
                case LocationType.WGS84:
                    encoder.WriteEncodeable("WGS84", (WGS84Coordinate)m_value, typeof(WGS84Coordinate));
                    break;
                case LocationType.Name:
                    encoder.WriteString("Name", (string)m_value);
                    break;
                case LocationType.LCI_DHCP:
                    encoder.WriteEncodeable("LCI_DHCP", (DhcpGeoConfCoordinate)m_value, typeof(DhcpGeoConfCoordinate));
                    break;
                case LocationType.Civic_Address:
                    encoder.WriteEncodeable("Civic_Address", (CivicAddressType)m_value, typeof(CivicAddressType));
                    break;
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);

            m_switchField = (LocationType)decoder.ReadInt32("SwitchField");

            switch (m_switchField)
            {
                case LocationType.Null:
                    m_value = null;
                    break;
                case LocationType.NMEA:
                    m_value = decoder.ReadString("NMEA");
                    break;
                case LocationType.UTM:
                    m_value = decoder.ReadEncodeable("UTM", typeof(UtmCoordinate));
                    break;
                case LocationType.Local:
                    m_value = decoder.ReadEncodeable("Local", typeof(LocalCoordinate));
                    break;
                case LocationType.Local1D:
                    m_value = decoder.ReadEncodeable("Local1D", typeof(Local1DCoordinate));
                    break;
                case LocationType.WGS84:
                    m_value = decoder.ReadEncodeable("WGS84", typeof(WGS84Coordinate));
                    break;
                case LocationType.Name:
                    m_value = decoder.ReadString("Name");
                    break;
                case LocationType.LCI_DHCP:
                    m_value = decoder.ReadEncodeable("LCI_DHCP", typeof(DhcpGeoConfCoordinate));
                    break;
                case LocationType.Civic_Address:
                    m_value = decoder.ReadEncodeable("Civic_Address", typeof(CivicAddressType));
                    break;
            }
            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            Location value = encodeable as Location;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_switchField, value.m_switchField)) return false;
            if (!TypeUtils.IsEqual(m_value, value.m_value)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            Location clone = (Location)base.Clone();

            clone.m_switchField = (LocationType)TypeUtils.Clone(this.m_switchField);
            switch (m_switchField)
            {
                case LocationType.NMEA:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.UTM:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.Local:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.Local1D:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.WGS84:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.Name:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.LCI_DHCP:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case LocationType.Civic_Address:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private LocationType m_switchField;
        private object m_value;
        #endregion
    }

    #region LocationCollection class
    /// <summary>
    /// A collection of Location objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfLocation", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "Location")]
    public partial class LocationCollection : List<Location>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public LocationCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public LocationCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public LocationCollection(IEnumerable<Location> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator LocationCollection(Location[] values)
        {
            if (values != null)
            {
                return new LocationCollection(values);
            }

            return new LocationCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator Location[](LocationCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            LocationCollection clone = new LocationCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((Location)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region ScanData Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class ScanData : UnifiedAutomation.UaBase.Union
    {
        #region Union Type
        public enum ScanDataType
        {
            Null = 0,
            ByteString = 1,
            String = 2,
            Epc = 3,
            Custom = 4,
        }
        #endregion

        #region Constructors
        public ScanData()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_switchField = ScanDataType.Null;
            m_value = null;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "SwitchField", IsRequired = false, Order = 1)]
        private uint SwitchField
        {
            get
            {
                return (uint)m_switchField;
            }
            set
            {
                m_switchField = (ScanDataType)value;
            }
        }

        public ScanDataType Type
        {
            get { return m_switchField; }
        }

        public object Value
        {
            get { return m_value; }
        }

        [DataMember(Name = "ByteString", IsRequired = false, Order = 2)]
        public byte[] ByteString
        {
            get
            {
                if (m_switchField == ScanDataType.ByteString)
                {
                    return (byte[])m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = ScanDataType.ByteString;
            }
        }

        [DataMember(Name = "String", IsRequired = false, Order = 2)]
        public string String
        {
            get
            {
                if (m_switchField == ScanDataType.String)
                {
                    return (string)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = ScanDataType.String;
            }
        }

        [DataMember(Name = "Epc", IsRequired = false, Order = 2)]
        public ScanDataEpc Epc
        {
            get
            {
                if (m_switchField == ScanDataType.Epc)
                {
                    return (ScanDataEpc)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = ScanDataType.Epc;
            }
        }

        [DataMember(Name = "Custom", IsRequired = false, Order = 2)]
        public Variant? Custom
        {
            get
            {
                if (m_switchField == ScanDataType.Custom)
                {
                    return (Variant?)m_value;
                }
                return null;
            }
            set
            {
                m_value = value;
                m_switchField = ScanDataType.Custom;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public override ExpandedNodeId TypeId
        {
            get { return DataTypeIds.ScanData; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public override ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.ScanData_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public override ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.ScanData_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public override void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteUInt32("SwitchField", (uint)m_switchField);

            switch (m_switchField)
            {
                case ScanDataType.Null:
                    break;
                case ScanDataType.ByteString:
                    encoder.WriteByteString("ByteString", (byte[])m_value);
                    break;
                case ScanDataType.String:
                    encoder.WriteString("String", (string)m_value);
                    break;
                case ScanDataType.Epc:
                    encoder.WriteEncodeable("Epc", (ScanDataEpc)m_value, typeof(ScanDataEpc));
                    break;
                case ScanDataType.Custom:
                    encoder.WriteVariant("Custom", (Variant)m_value);
                    break;
            }

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public override void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);

            m_switchField = (ScanDataType)decoder.ReadInt32("SwitchField");

            switch (m_switchField)
            {
                case ScanDataType.Null:
                    m_value = null;
                    break;
                case ScanDataType.ByteString:
                    m_value = decoder.ReadByteString("ByteString");
                    break;
                case ScanDataType.String:
                    m_value = decoder.ReadString("String");
                    break;
                case ScanDataType.Epc:
                    m_value = decoder.ReadEncodeable("Epc", typeof(ScanDataEpc));
                    break;
                case ScanDataType.Custom:
                    m_value = decoder.ReadVariant("Custom");
                    break;
            }
            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public override bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            ScanData value = encodeable as ScanData;

            if (value == null)
            {
                return false;
            }

            if (!base.IsEqual(encodeable)) return false;

            if (!TypeUtils.IsEqual(m_switchField, value.m_switchField)) return false;
            if (!TypeUtils.IsEqual(m_value, value.m_value)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public override object Clone()
        {
            ScanData clone = (ScanData)base.Clone();

            clone.m_switchField = (ScanDataType)TypeUtils.Clone(this.m_switchField);
            switch (m_switchField)
            {
                case ScanDataType.ByteString:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case ScanDataType.String:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case ScanDataType.Epc:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
                case ScanDataType.Custom:
                    clone.m_value = TypeUtils.Clone(this.m_value);
                    break;
            }

            return clone;
        }
        #endregion

        #region Private Fields
        private ScanDataType m_switchField;
        private object m_value;
        #endregion
    }

    #region ScanDataCollection class
    /// <summary>
    /// A collection of ScanData objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfScanData", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "ScanData")]
    public partial class ScanDataCollection : List<ScanData>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public ScanDataCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public ScanDataCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public ScanDataCollection(IEnumerable<ScanData> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator ScanDataCollection(ScanData[] values)
        {
            if (values != null)
            {
                return new ScanDataCollection(values);
            }

            return new ScanDataCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator ScanData[](ScanDataCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            ScanDataCollection clone = new ScanDataCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((ScanData)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region UtmCoordinate Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class UtmCoordinate : IEncodeable
    {
        #region Constructors
        public UtmCoordinate()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_UtmZone = null;
            m_Easting = 0.0;
            m_Northing = 0.0;
            m_Altitude = 0.0;
            m_Timestamp = DateTime.MinValue;
            m_DilutionOfPrecision = 0.0;
            m_UsefulPrecision = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "UtmZone", IsRequired = false, Order = 1)]
        public string UtmZone
        {
            get
            {
                return m_UtmZone;
            }
            set
            {
                m_UtmZone = value;
            }
        }
        [DataMember(Name = "Easting", IsRequired = false, Order = 2)]
        public double Easting
        {
            get
            {
                return m_Easting;
            }
            set
            {
                m_Easting = value;
            }
        }
        [DataMember(Name = "Northing", IsRequired = false, Order = 3)]
        public double Northing
        {
            get
            {
                return m_Northing;
            }
            set
            {
                m_Northing = value;
            }
        }
        [DataMember(Name = "Altitude", IsRequired = false, Order = 4)]
        public double Altitude
        {
            get
            {
                return m_Altitude;
            }
            set
            {
                m_Altitude = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 5)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 6)]
        public double DilutionOfPrecision
        {
            get
            {
                return m_DilutionOfPrecision;
            }
            set
            {
                m_DilutionOfPrecision = value;
            }
        }
        [DataMember(Name = "UsefulPrecision", IsRequired = false, Order = 7)]
        public int UsefulPrecision
        {
            get
            {
                return m_UsefulPrecision;
            }
            set
            {
                m_UsefulPrecision = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.UtmCoordinate; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.UtmCoordinate_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.UtmCoordinate_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteString("UtmZone", UtmZone);
            encoder.WriteDouble("Easting", Easting);
            encoder.WriteDouble("Northing", Northing);
            encoder.WriteDouble("Altitude", Altitude);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecision", UsefulPrecision);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            UtmZone = decoder.ReadString("UtmZone");
            Easting = decoder.ReadDouble("Easting");
            Northing = decoder.ReadDouble("Northing");
            Altitude = decoder.ReadDouble("Altitude");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecision = decoder.ReadInt32("UsefulPrecision");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            UtmCoordinate value = encodeable as UtmCoordinate;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_UtmZone, value.m_UtmZone)) return false;
            if (!TypeUtils.IsEqual(m_Easting, value.m_Easting)) return false;
            if (!TypeUtils.IsEqual(m_Northing, value.m_Northing)) return false;
            if (!TypeUtils.IsEqual(m_Altitude, value.m_Altitude)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (!TypeUtils.IsEqual(m_DilutionOfPrecision, value.m_DilutionOfPrecision)) return false;
            if (!TypeUtils.IsEqual(m_UsefulPrecision, value.m_UsefulPrecision)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            UtmCoordinate clone = (UtmCoordinate)this.MemberwiseClone();

            clone.m_UtmZone = (string)TypeUtils.Clone(this.m_UtmZone);
            clone.m_Easting = (double)TypeUtils.Clone(this.m_Easting);
            clone.m_Northing = (double)TypeUtils.Clone(this.m_Northing);
            clone.m_Altitude = (double)TypeUtils.Clone(this.m_Altitude);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_DilutionOfPrecision = (double)TypeUtils.Clone(this.m_DilutionOfPrecision);
            clone.m_UsefulPrecision = (int)TypeUtils.Clone(this.m_UsefulPrecision);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_UtmZone;
        private double m_Easting;
        private double m_Northing;
        private double m_Altitude;
        private DateTime m_Timestamp;
        private double m_DilutionOfPrecision;
        private int m_UsefulPrecision;
        #endregion
    }

    #region UtmCoordinateCollection class
    /// <summary>
    /// A collection of UtmCoordinate objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfUtmCoordinate", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "UtmCoordinate")]
    public partial class UtmCoordinateCollection : List<UtmCoordinate>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public UtmCoordinateCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public UtmCoordinateCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public UtmCoordinateCollection(IEnumerable<UtmCoordinate> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator UtmCoordinateCollection(UtmCoordinate[] values)
        {
            if (values != null)
            {
                return new UtmCoordinateCollection(values);
            }

            return new UtmCoordinateCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator UtmCoordinate[](UtmCoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            UtmCoordinateCollection clone = new UtmCoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((UtmCoordinate)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region WGS84Coordinate Class
    /// <summary>
    /// </summary>
    [DataContract(Namespace = AIM.AutoId.Namespaces.AutoId)]
    public partial class WGS84Coordinate : IEncodeable
    {
        #region Constructors
        public WGS84Coordinate()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_N_S_Hemisphere = null;
            m_Latitude = 0.0;
            m_E_W_Hemisphere = null;
            m_Longitude = 0.0;
            m_Altitude = 0.0;
            m_Timestamp = DateTime.MinValue;
            m_DilutionOfPrecision = 0.0;
            m_UsefulPrecisionLatLon = (int)0;
            m_UsefulPrecisionAlt = (int)0;
        }
        #endregion

        #region Public Properties
        [DataMember(Name = "N_S_Hemisphere", IsRequired = false, Order = 1)]
        public string N_S_Hemisphere
        {
            get
            {
                return m_N_S_Hemisphere;
            }
            set
            {
                m_N_S_Hemisphere = value;
            }
        }
        [DataMember(Name = "Latitude", IsRequired = false, Order = 2)]
        public double Latitude
        {
            get
            {
                return m_Latitude;
            }
            set
            {
                m_Latitude = value;
            }
        }
        [DataMember(Name = "E_W_Hemisphere", IsRequired = false, Order = 3)]
        public string E_W_Hemisphere
        {
            get
            {
                return m_E_W_Hemisphere;
            }
            set
            {
                m_E_W_Hemisphere = value;
            }
        }
        [DataMember(Name = "Longitude", IsRequired = false, Order = 4)]
        public double Longitude
        {
            get
            {
                return m_Longitude;
            }
            set
            {
                m_Longitude = value;
            }
        }
        [DataMember(Name = "Altitude", IsRequired = false, Order = 5)]
        public double Altitude
        {
            get
            {
                return m_Altitude;
            }
            set
            {
                m_Altitude = value;
            }
        }
        [DataMember(Name = "Timestamp", IsRequired = false, Order = 6)]
        public DateTime Timestamp
        {
            get
            {
                return m_Timestamp;
            }
            set
            {
                m_Timestamp = value;
            }
        }
        [DataMember(Name = "DilutionOfPrecision", IsRequired = false, Order = 7)]
        public double DilutionOfPrecision
        {
            get
            {
                return m_DilutionOfPrecision;
            }
            set
            {
                m_DilutionOfPrecision = value;
            }
        }
        [DataMember(Name = "UsefulPrecisionLatLon", IsRequired = false, Order = 8)]
        public int UsefulPrecisionLatLon
        {
            get
            {
                return m_UsefulPrecisionLatLon;
            }
            set
            {
                m_UsefulPrecisionLatLon = value;
            }
        }
        [DataMember(Name = "UsefulPrecisionAlt", IsRequired = false, Order = 9)]
        public int UsefulPrecisionAlt
        {
            get
            {
                return m_UsefulPrecisionAlt;
            }
            set
            {
                m_UsefulPrecisionAlt = value;
            }
        }
        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.WGS84Coordinate; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.WGS84Coordinate_Encoding_DefaultBinary; }
        }

        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.WGS84Coordinate_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.AutoIdXsd);

            encoder.WriteString("N_S_Hemisphere", N_S_Hemisphere);
            encoder.WriteDouble("Latitude", Latitude);
            encoder.WriteString("E_W_Hemisphere", E_W_Hemisphere);
            encoder.WriteDouble("Longitude", Longitude);
            encoder.WriteDouble("Altitude", Altitude);
            encoder.WriteDateTime("Timestamp", Timestamp);
            encoder.WriteDouble("DilutionOfPrecision", DilutionOfPrecision);
            encoder.WriteInt32("UsefulPrecisionLatLon", UsefulPrecisionLatLon);
            encoder.WriteInt32("UsefulPrecisionAlt", UsefulPrecisionAlt);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.AutoIdXsd);
            N_S_Hemisphere = decoder.ReadString("N_S_Hemisphere");
            Latitude = decoder.ReadDouble("Latitude");
            E_W_Hemisphere = decoder.ReadString("E_W_Hemisphere");
            Longitude = decoder.ReadDouble("Longitude");
            Altitude = decoder.ReadDouble("Altitude");
            Timestamp = decoder.ReadDateTime("Timestamp");
            DilutionOfPrecision = decoder.ReadDouble("DilutionOfPrecision");
            UsefulPrecisionLatLon = decoder.ReadInt32("UsefulPrecisionLatLon");
            UsefulPrecisionAlt = decoder.ReadInt32("UsefulPrecisionAlt");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            WGS84Coordinate value = encodeable as WGS84Coordinate;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_N_S_Hemisphere, value.m_N_S_Hemisphere)) return false;
            if (!TypeUtils.IsEqual(m_Latitude, value.m_Latitude)) return false;
            if (!TypeUtils.IsEqual(m_E_W_Hemisphere, value.m_E_W_Hemisphere)) return false;
            if (!TypeUtils.IsEqual(m_Longitude, value.m_Longitude)) return false;
            if (!TypeUtils.IsEqual(m_Altitude, value.m_Altitude)) return false;
            if (!TypeUtils.IsEqual(m_Timestamp, value.m_Timestamp)) return false;
            if (!TypeUtils.IsEqual(m_DilutionOfPrecision, value.m_DilutionOfPrecision)) return false;
            if (!TypeUtils.IsEqual(m_UsefulPrecisionLatLon, value.m_UsefulPrecisionLatLon)) return false;
            if (!TypeUtils.IsEqual(m_UsefulPrecisionAlt, value.m_UsefulPrecisionAlt)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            WGS84Coordinate clone = (WGS84Coordinate)this.MemberwiseClone();

            clone.m_N_S_Hemisphere = (string)TypeUtils.Clone(this.m_N_S_Hemisphere);
            clone.m_Latitude = (double)TypeUtils.Clone(this.m_Latitude);
            clone.m_E_W_Hemisphere = (string)TypeUtils.Clone(this.m_E_W_Hemisphere);
            clone.m_Longitude = (double)TypeUtils.Clone(this.m_Longitude);
            clone.m_Altitude = (double)TypeUtils.Clone(this.m_Altitude);
            clone.m_Timestamp = (DateTime)TypeUtils.Clone(this.m_Timestamp);
            clone.m_DilutionOfPrecision = (double)TypeUtils.Clone(this.m_DilutionOfPrecision);
            clone.m_UsefulPrecisionLatLon = (int)TypeUtils.Clone(this.m_UsefulPrecisionLatLon);
            clone.m_UsefulPrecisionAlt = (int)TypeUtils.Clone(this.m_UsefulPrecisionAlt);

            return clone;
        }
        #endregion

        #region Private Fields
        private string m_N_S_Hemisphere;
        private double m_Latitude;
        private string m_E_W_Hemisphere;
        private double m_Longitude;
        private double m_Altitude;
        private DateTime m_Timestamp;
        private double m_DilutionOfPrecision;
        private int m_UsefulPrecisionLatLon;
        private int m_UsefulPrecisionAlt;
        #endregion
    }

    #region WGS84CoordinateCollection class
    /// <summary>
    /// A collection of WGS84Coordinate objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfWGS84Coordinate", Namespace = AIM.AutoId.Namespaces.AutoId, ItemName = "WGS84Coordinate")]
    public partial class WGS84CoordinateCollection : List<WGS84Coordinate>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public WGS84CoordinateCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public WGS84CoordinateCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public WGS84CoordinateCollection(IEnumerable<WGS84Coordinate> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator WGS84CoordinateCollection(WGS84Coordinate[] values)
        {
            if (values != null)
            {
                return new WGS84CoordinateCollection(values);
            }

            return new WGS84CoordinateCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator WGS84Coordinate[](WGS84CoordinateCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            WGS84CoordinateCollection clone = new WGS84CoordinateCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((WGS84Coordinate)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion
}
