using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using UnifiedAutomation.UaBase;

namespace AIM.AutoId
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the AutoIdOperationStatusEnumeration DataType.
        /// </summary>
        public const uint AutoIdOperationStatusEnumeration = 3013;

        /// <summary>
        /// The identifier for the DeviceStatusEnumeration DataType.
        /// </summary>
        public const uint DeviceStatusEnumeration = 3003;

        /// <summary>
        /// The identifier for the LocationTypeEnumeration DataType.
        /// </summary>
        public const uint LocationTypeEnumeration = 3009;

        /// <summary>
        /// The identifier for the RfidLockOperationEnumeration DataType.
        /// </summary>
        public const uint RfidLockOperationEnumeration = 3016;

        /// <summary>
        /// The identifier for the RfidLockRegionEnumeration DataType.
        /// </summary>
        public const uint RfidLockRegionEnumeration = 3015;

        /// <summary>
        /// The identifier for the RfidPasswordTypeEnumeration DataType.
        /// </summary>
        public const uint RfidPasswordTypeEnumeration = 3014;

        /// <summary>
        /// The identifier for the CodeTypeDataType DataType.
        /// </summary>
        public const uint CodeTypeDataType = 3031;

        /// <summary>
        /// The identifier for the LocationName DataType.
        /// </summary>
        public const uint LocationName = 3021;

        /// <summary>
        /// The identifier for the NmeaCoordinateString DataType.
        /// </summary>
        public const uint NmeaCoordinateString = 3012;

        /// <summary>
        /// The identifier for the AntennaNameIdPair DataType.
        /// </summary>
        public const uint AntennaNameIdPair = 3011;

        /// <summary>
        /// The identifier for the CivicAddressElement DataType.
        /// </summary>
        public const uint CivicAddressElement = 3022;

        /// <summary>
        /// The identifier for the CivicAddressType DataType.
        /// </summary>
        public const uint CivicAddressType = 3025;

        /// <summary>
        /// The identifier for the DhcpGeoConfCoordinate DataType.
        /// </summary>
        public const uint DhcpGeoConfCoordinate = 3023;

        /// <summary>
        /// The identifier for the Local1DCoordinate DataType.
        /// </summary>
        public const uint Local1DCoordinate = 3017;

        /// <summary>
        /// The identifier for the LocalCoordinate DataType.
        /// </summary>
        public const uint LocalCoordinate = 3019;

        /// <summary>
        /// The identifier for the Position DataType.
        /// </summary>
        public const uint Position = 3004;

        /// <summary>
        /// The identifier for the RfidSighting DataType.
        /// </summary>
        public const uint RfidSighting = 3006;

        /// <summary>
        /// The identifier for the Rotation DataType.
        /// </summary>
        public const uint Rotation = 3029;

        /// <summary>
        /// The identifier for the ScanDataEpc DataType.
        /// </summary>
        public const uint ScanDataEpc = 3024;

        /// <summary>
        /// The identifier for the ScanResult DataType.
        /// </summary>
        public const uint ScanResult = 3001;

        /// <summary>
        /// The identifier for the OcrScanResult DataType.
        /// </summary>
        public const uint OcrScanResult = 3002;

        /// <summary>
        /// The identifier for the OpticalScanResult DataType.
        /// </summary>
        public const uint OpticalScanResult = 3026;

        /// <summary>
        /// The identifier for the OpticalVerifierScanResult DataType.
        /// </summary>
        public const uint OpticalVerifierScanResult = 3030;

        /// <summary>
        /// The identifier for the RfidScanResult DataType.
        /// </summary>
        public const uint RfidScanResult = 3007;

        /// <summary>
        /// The identifier for the RtlsLocationResult DataType.
        /// </summary>
        public const uint RtlsLocationResult = 3028;

        /// <summary>
        /// The identifier for the ScanSettings DataType.
        /// </summary>
        public const uint ScanSettings = 3010;

        /// <summary>
        /// The identifier for the Location DataType.
        /// </summary>
        public const uint Location = 3008;

        /// <summary>
        /// The identifier for the ScanData DataType.
        /// </summary>
        public const uint ScanData = 3020;

        /// <summary>
        /// The identifier for the UtmCoordinate DataType.
        /// </summary>
        public const uint UtmCoordinate = 3018;

        /// <summary>
        /// The identifier for the WGS84Coordinate DataType.
        /// </summary>
        public const uint WGS84Coordinate = 3027;

    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint AntennaNameIdPair_Encoding_DefaultBinary = 5017;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint AntennaNameIdPair_Encoding_DefaultXml = 5018;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint CivicAddressElement_Encoding_DefaultBinary = 5032;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint CivicAddressElement_Encoding_DefaultXml = 5033;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint CivicAddressType_Encoding_DefaultBinary = 5038;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint CivicAddressType_Encoding_DefaultXml = 5039;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint DhcpGeoConfCoordinate_Encoding_DefaultBinary = 5034;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint DhcpGeoConfCoordinate_Encoding_DefaultXml = 5035;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint Local1DCoordinate_Encoding_DefaultBinary = 5019;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint Local1DCoordinate_Encoding_DefaultXml = 5020;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint LocalCoordinate_Encoding_DefaultBinary = 5028;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint LocalCoordinate_Encoding_DefaultXml = 5029;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint Position_Encoding_DefaultBinary = 5007;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint Position_Encoding_DefaultXml = 5008;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint RfidSighting_Encoding_DefaultBinary = 5009;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint RfidSighting_Encoding_DefaultXml = 5010;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint Rotation_Encoding_DefaultBinary = 5050;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint Rotation_Encoding_DefaultXml = 5051;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint ScanDataEpc_Encoding_DefaultBinary = 5036;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint ScanDataEpc_Encoding_DefaultXml = 5037;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint ScanResult_Encoding_DefaultBinary = 5002;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint ScanResult_Encoding_DefaultXml = 5003;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint OcrScanResult_Encoding_DefaultBinary = 5004;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint OcrScanResult_Encoding_DefaultXml = 5005;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint OpticalScanResult_Encoding_DefaultBinary = 5040;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint OpticalScanResult_Encoding_DefaultXml = 5041;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint OpticalVerifierScanResult_Encoding_DefaultBinary = 5052;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint OpticalVerifierScanResult_Encoding_DefaultXml = 5053;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint RfidScanResult_Encoding_DefaultBinary = 5011;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint RfidScanResult_Encoding_DefaultXml = 5012;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint RtlsLocationResult_Encoding_DefaultBinary = 5048;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint RtlsLocationResult_Encoding_DefaultXml = 5049;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint ScanSettings_Encoding_DefaultBinary = 5015;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint ScanSettings_Encoding_DefaultXml = 5016;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint Location_Encoding_DefaultBinary = 5013;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint Location_Encoding_DefaultXml = 5014;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint ScanData_Encoding_DefaultBinary = 5030;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint ScanData_Encoding_DefaultXml = 5031;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint UtmCoordinate_Encoding_DefaultBinary = 5026;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint UtmCoordinate_Encoding_DefaultXml = 5027;

        /// <summary>
        /// The identifier for the Default Binary Object.
        /// </summary>
        public const uint WGS84Coordinate_Encoding_DefaultBinary = 5046;

        /// <summary>
        /// The identifier for the Default XML Object.
        /// </summary>
        public const uint WGS84Coordinate_Encoding_DefaultXml = 5047;

        /// <summary>
        /// The identifier for the Configuration Object.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration = 5001;

        /// <summary>
        /// The identifier for the IOData Object.
        /// </summary>
        public const uint AutoIdDeviceType_IOData = 5054;

        /// <summary>
        /// The identifier for the Images Object.
        /// </summary>
        public const uint OcrReaderDeviceType_Images = 5006;

        /// <summary>
        /// The identifier for the OcrScanEventType Object.
        /// </summary>
        public const uint OcrReaderDeviceType_OcrScanEventType = 5045;

        /// <summary>
        /// The identifier for the RuntimeParameters Object.
        /// </summary>
        public const uint AutoIdDeviceType_RuntimeParameters = 5044;

        /// <summary>
        /// The identifier for the DefaultOCR Object.
        /// </summary>
        public const uint DefaultOCR = 5021;

        /// <summary>
        /// The identifier for the Configuration Object.
        /// </summary>
        public const uint DefaultOCR_Configuration = 5023;

        /// <summary>
        /// The identifier for the Images Object.
        /// </summary>
        public const uint DefaultOCR_Images = 5022;

        /// <summary>
        /// The identifier for the DefaultOptical Object.
        /// </summary>
        public const uint DefaultOptical = 5042;

        /// <summary>
        /// The identifier for the Configuration Object.
        /// </summary>
        public const uint DefaultOptical_Configuration = 5043;

        /// <summary>
        /// The identifier for the DefaultRFID Object.
        /// </summary>
        public const uint DefaultRFID = 5024;

        /// <summary>
        /// The identifier for the Configuration Object.
        /// </summary>
        public const uint DefaultRFID_Configuration = 5025;

    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the AutoIdScanEventType ObjectType.
        /// </summary>
        public const uint AutoIdScanEventType = 1004;

        /// <summary>
        /// The identifier for the OcrScanEventType ObjectType.
        /// </summary>
        public const uint OcrScanEventType = 1005;

        /// <summary>
        /// The identifier for the OpticalScanEventType ObjectType.
        /// </summary>
        public const uint OpticalScanEventType = 1009;

        /// <summary>
        /// The identifier for the OpticalVerifierScanEventType ObjectType.
        /// </summary>
        public const uint OpticalVerifierScanEventType = 1013;

        /// <summary>
        /// The identifier for the RfidScanEventType ObjectType.
        /// </summary>
        public const uint RfidScanEventType = 1006;

        /// <summary>
        /// The identifier for the RtlsLocationEventType ObjectType.
        /// </summary>
        public const uint RtlsLocationEventType = 1014;

        /// <summary>
        /// The identifier for the AutoIdDeviceType ObjectType.
        /// </summary>
        public const uint AutoIdDeviceType = 1001;

        /// <summary>
        /// The identifier for the OcrReaderDeviceType ObjectType.
        /// </summary>
        public const uint OcrReaderDeviceType = 1002;

        /// <summary>
        /// The identifier for the OpticalReaderDeviceType ObjectType.
        /// </summary>
        public const uint OpticalReaderDeviceType = 1008;

        /// <summary>
        /// The identifier for the OpticalVerifierDeviceType ObjectType.
        /// </summary>
        public const uint OpticalVerifierDeviceType = 1011;

        /// <summary>
        /// The identifier for the RfidReaderDeviceType ObjectType.
        /// </summary>
        public const uint RfidReaderDeviceType = 1003;

        /// <summary>
        /// The identifier for the RtlsDeviceType ObjectType.
        /// </summary>
        public const uint RtlsDeviceType = 1012;

    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the Close Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Close = 7002;

        /// <summary>
        /// The identifier for the GetPosition Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_GetPosition = 7003;

        /// <summary>
        /// The identifier for the Open Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Open = 7004;

        /// <summary>
        /// The identifier for the Read Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Read = 7005;

        /// <summary>
        /// The identifier for the SetPosition Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_SetPosition = 7006;

        /// <summary>
        /// The identifier for the Write Method.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Write = 7007;

        /// <summary>
        /// The identifier for the GetDeviceLocation Method.
        /// </summary>
        public const uint AutoIdDeviceType_GetDeviceLocation = 7042;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint OcrReaderDeviceType_Scan = 7001;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint OpticalReaderDeviceType_Scan = 7043;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint OpticalVerifierDeviceType_Scan = 7054;

        /// <summary>
        /// The identifier for the KillTag Method.
        /// </summary>
        public const uint RfidReaderDeviceType_KillTag = 7017;

        /// <summary>
        /// The identifier for the LockTag Method.
        /// </summary>
        public const uint RfidReaderDeviceType_LockTag = 7018;

        /// <summary>
        /// The identifier for the ReadTag Method.
        /// </summary>
        public const uint RfidReaderDeviceType_ReadTag = 7014;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint RfidReaderDeviceType_Scan = 7013;

        /// <summary>
        /// The identifier for the SetTagPassword Method.
        /// </summary>
        public const uint RfidReaderDeviceType_SetTagPassword = 7016;

        /// <summary>
        /// The identifier for the WriteTag Method.
        /// </summary>
        public const uint RfidReaderDeviceType_WriteTag = 7015;

        /// <summary>
        /// The identifier for the GetLocation Method.
        /// </summary>
        public const uint RtlsDeviceType_GetLocation = 7056;

        /// <summary>
        /// The identifier for the GetSupportedLocationTypes Method.
        /// </summary>
        public const uint RtlsDeviceType_GetSupportedLocationTypes = 7058;

        /// <summary>
        /// The identifier for the GetUnits Method.
        /// </summary>
        public const uint RtlsDeviceType_GetUnits = 7057;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint RtlsDeviceType_Scan = 7055;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint AutoIdDeviceType_Scan = 7008;

        /// <summary>
        /// The identifier for the ScanStart Method.
        /// </summary>
        public const uint AutoIdDeviceType_ScanStart = 7009;

        /// <summary>
        /// The identifier for the ScanStop Method.
        /// </summary>
        public const uint AutoIdDeviceType_ScanStop = 7010;

        /// <summary>
        /// The identifier for the Close Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_Close = 7021;

        /// <summary>
        /// The identifier for the GetPosition Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_GetPosition = 7022;

        /// <summary>
        /// The identifier for the Open Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_Open = 7023;

        /// <summary>
        /// The identifier for the Read Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_Read = 7024;

        /// <summary>
        /// The identifier for the SetPosition Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_SetPosition = 7025;

        /// <summary>
        /// The identifier for the Write Method.
        /// </summary>
        public const uint DefaultOCR_Configuration_Write = 7026;

        /// <summary>
        /// The identifier for the GetDeviceLocation Method.
        /// </summary>
        public const uint DefaultOCR_GetDeviceLocation = 7011;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint DefaultOCR_Scan = 7019;

        /// <summary>
        /// The identifier for the ScanStart Method.
        /// </summary>
        public const uint DefaultOCR_ScanStart = 7020;

        /// <summary>
        /// The identifier for the ScanStop Method.
        /// </summary>
        public const uint DefaultOCR_ScanStop = 7027;

        /// <summary>
        /// The identifier for the Close Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_Close = 7045;

        /// <summary>
        /// The identifier for the GetPosition Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_GetPosition = 7046;

        /// <summary>
        /// The identifier for the Open Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_Open = 7047;

        /// <summary>
        /// The identifier for the Read Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_Read = 7048;

        /// <summary>
        /// The identifier for the SetPosition Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_SetPosition = 7049;

        /// <summary>
        /// The identifier for the Write Method.
        /// </summary>
        public const uint DefaultOptical_Configuration_Write = 7050;

        /// <summary>
        /// The identifier for the GetDeviceLocation Method.
        /// </summary>
        public const uint DefaultOptical_GetDeviceLocation = 7012;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint DefaultOptical_Scan = 7044;

        /// <summary>
        /// The identifier for the ScanStart Method.
        /// </summary>
        public const uint DefaultOptical_ScanStart = 7051;

        /// <summary>
        /// The identifier for the ScanStop Method.
        /// </summary>
        public const uint DefaultOptical_ScanStop = 7052;

        /// <summary>
        /// The identifier for the Close Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_Close = 7035;

        /// <summary>
        /// The identifier for the GetPosition Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_GetPosition = 7036;

        /// <summary>
        /// The identifier for the Open Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_Open = 7037;

        /// <summary>
        /// The identifier for the Read Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_Read = 7038;

        /// <summary>
        /// The identifier for the SetPosition Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_SetPosition = 7039;

        /// <summary>
        /// The identifier for the Write Method.
        /// </summary>
        public const uint DefaultRFID_Configuration_Write = 7040;

        /// <summary>
        /// The identifier for the GetDeviceLocation Method.
        /// </summary>
        public const uint DefaultRFID_GetDeviceLocation = 7053;

        /// <summary>
        /// The identifier for the KillTag Method.
        /// </summary>
        public const uint DefaultRFID_KillTag = 7030;

        /// <summary>
        /// The identifier for the LockTag Method.
        /// </summary>
        public const uint DefaultRFID_LockTag = 7031;

        /// <summary>
        /// The identifier for the ReadTag Method.
        /// </summary>
        public const uint DefaultRFID_ReadTag = 7033;

        /// <summary>
        /// The identifier for the Scan Method.
        /// </summary>
        public const uint DefaultRFID_Scan = 7028;

        /// <summary>
        /// The identifier for the ScanStart Method.
        /// </summary>
        public const uint DefaultRFID_ScanStart = 7029;

        /// <summary>
        /// The identifier for the ScanStop Method.
        /// </summary>
        public const uint DefaultRFID_ScanStop = 7041;

        /// <summary>
        /// The identifier for the SetTagPassword Method.
        /// </summary>
        public const uint DefaultRFID_SetTagPassword = 7032;

        /// <summary>
        /// The identifier for the WriteTag Method.
        /// </summary>
        public const uint DefaultRFID_WriteTag = 7034;

    }
    #endregion

    #region ReferenceType Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTyped in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class ReferenceTypes
    {
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the EnumValues Variable.
        /// </summary>
        public const uint AutoIdOperationStatusEnumeration_EnumValues = 6201;

        /// <summary>
        /// The identifier for the EnumStrings Variable.
        /// </summary>
        public const uint DeviceStatusEnumeration_EnumStrings = 6029;

        /// <summary>
        /// The identifier for the EnumStrings Variable.
        /// </summary>
        public const uint LocationTypeEnumeration_EnumStrings = 6040;

        /// <summary>
        /// The identifier for the EnumStrings Variable.
        /// </summary>
        public const uint RfidLockOperationEnumeration_EnumStrings = 6067;

        /// <summary>
        /// The identifier for the EnumStrings Variable.
        /// </summary>
        public const uint RfidLockRegionEnumeration_EnumStrings = 6066;

        /// <summary>
        /// The identifier for the EnumStrings Variable.
        /// </summary>
        public const uint RfidPasswordTypeEnumeration_EnumStrings = 6061;

        /// <summary>
        /// The identifier for the AutoID Variable.
        /// </summary>
        public const uint AutoID_BinarySchema = 6016;

        /// <summary>
        /// The identifier for the AntennaNameIdPair Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_AntennaNameIdPair = 6046;

        /// <summary>
        /// The identifier for the CivicAddressElement Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_CivicAddressElement = 6146;

        /// <summary>
        /// The identifier for the CivicAddressType Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_CivicAddressType = 6191;

        /// <summary>
        /// The identifier for the DhcpGeoConfCoordinate Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_DhcpGeoConfCoordinate = 6189;

        /// <summary>
        /// The identifier for the Local1DCoordinate Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_Local1DCoordinate = 6039;

        /// <summary>
        /// The identifier for the LocalCoordinate Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_LocalCoordinate = 6122;

        /// <summary>
        /// The identifier for the Location Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_Location = 6034;

        /// <summary>
        /// The identifier for the NamespaceUri Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_NamespaceUri = 6017;

        /// <summary>
        /// The identifier for the OcrScanResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_OcrScanResult = 6022;

        /// <summary>
        /// The identifier for the OpticalScanResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_OpticalScanResult = 6142;

        /// <summary>
        /// The identifier for the OpticalVerifierScanResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_OpticalVerifierScanResult = 6229;

        /// <summary>
        /// The identifier for the Position Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_Position = 6032;

        /// <summary>
        /// The identifier for the RfidScanResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_RfidScanResult = 6037;

        /// <summary>
        /// The identifier for the RfidSighting Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_RfidSighting = 6025;

        /// <summary>
        /// The identifier for the Rotation Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_Rotation = 6222;

        /// <summary>
        /// The identifier for the RtlsLocationResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_RtlsLocationResult = 6220;

        /// <summary>
        /// The identifier for the ScanData Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_ScanData = 6131;

        /// <summary>
        /// The identifier for the ScanDataEpc Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_ScanDataEpc = 6138;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_ScanResult = 6020;

        /// <summary>
        /// The identifier for the ScanSettings Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_ScanSettings = 6044;

        /// <summary>
        /// The identifier for the UtmCoordinate Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_UtmCoordinate = 6120;

        /// <summary>
        /// The identifier for the WGS84Coordinate Variable.
        /// </summary>
        public const uint AutoID_BinarySchema_WGS84Coordinate = 6212;

        /// <summary>
        /// The identifier for the AutoID Variable.
        /// </summary>
        public const uint AutoID_XmlSchema = 6018;

        /// <summary>
        /// The identifier for the AntennaNameIdPair Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_AntennaNameIdPair = 6047;

        /// <summary>
        /// The identifier for the CivicAddressElement Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_CivicAddressElement = 6188;

        /// <summary>
        /// The identifier for the CivicAddressType Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_CivicAddressType = 6192;

        /// <summary>
        /// The identifier for the DhcpGeoConfCoordinate Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_DhcpGeoConfCoordinate = 6190;

        /// <summary>
        /// The identifier for the Local1DCoordinate Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_Local1DCoordinate = 6135;

        /// <summary>
        /// The identifier for the LocalCoordinate Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_LocalCoordinate = 6123;

        /// <summary>
        /// The identifier for the Location Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_Location = 6036;

        /// <summary>
        /// The identifier for the NamespaceUri Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_NamespaceUri = 6019;

        /// <summary>
        /// The identifier for the OcrScanResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_OcrScanResult = 6023;

        /// <summary>
        /// The identifier for the OpticalScanResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_OpticalScanResult = 6143;

        /// <summary>
        /// The identifier for the OpticalVerifierScanResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_OpticalVerifierScanResult = 6230;

        /// <summary>
        /// The identifier for the Position Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_Position = 6033;

        /// <summary>
        /// The identifier for the RfidScanResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_RfidScanResult = 6038;

        /// <summary>
        /// The identifier for the RfidSighting Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_RfidSighting = 6035;

        /// <summary>
        /// The identifier for the Rotation Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_Rotation = 6223;

        /// <summary>
        /// The identifier for the RtlsLocationResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_RtlsLocationResult = 6221;

        /// <summary>
        /// The identifier for the ScanData Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_ScanData = 6132;

        /// <summary>
        /// The identifier for the ScanDataEpc Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_ScanDataEpc = 6139;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_ScanResult = 6021;

        /// <summary>
        /// The identifier for the ScanSettings Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_ScanSettings = 6045;

        /// <summary>
        /// The identifier for the UtmCoordinate Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_UtmCoordinate = 6121;

        /// <summary>
        /// The identifier for the WGS84Coordinate Variable.
        /// </summary>
        public const uint AutoID_XmlSchema_WGS84Coordinate = 6213;

        /// <summary>
        /// The identifier for the DeviceName Variable.
        /// </summary>
        public const uint AutoIdScanEventType_DeviceName = 6049;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint OcrScanEventType_ScanResult = 6041;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint OpticalScanEventType_ScanResult = 6147;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint OpticalVerifierScanEventType_ScanResult = 6227;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint RfidScanEventType_ScanResult = 6042;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint RtlsLocationEventType_ScanResult = 6228;

        /// <summary>
        /// The identifier for the ScanResult Variable.
        /// </summary>
        public const uint AutoIdScanEventType_ScanResult = 6024;

        /// <summary>
        /// The identifier for the AutoIdModelVersion Variable.
        /// </summary>
        public const uint AutoIdDeviceType_AutoIdModelVersion = 6193;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Close_InputArguments = 6002;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_GetPosition_InputArguments = 6003;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_GetPosition_OutputArguments = 6004;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Open_InputArguments = 6005;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Open_OutputArguments = 6006;

        /// <summary>
        /// The identifier for the OpenCount Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_OpenCount = 6007;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Read_InputArguments = 6008;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Read_OutputArguments = 6009;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_SetPosition_InputArguments = 6010;

        /// <summary>
        /// The identifier for the Size Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Size = 6011;

        /// <summary>
        /// The identifier for the UserWritable Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_UserWritable = 6012;

        /// <summary>
        /// The identifier for the Writable Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Writable = 6013;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Configuration_Write_InputArguments = 6014;

        /// <summary>
        /// The identifier for the DeviceInfo Variable.
        /// </summary>
        public const uint AutoIdDeviceType_DeviceInfo = 6026;

        /// <summary>
        /// The identifier for the DeviceLocation Variable.
        /// </summary>
        public const uint AutoIdDeviceType_DeviceLocation = 6128;

        /// <summary>
        /// The identifier for the DeviceLocationName Variable.
        /// </summary>
        public const uint AutoIdDeviceType_DeviceLocationName = 6127;

        /// <summary>
        /// The identifier for the DeviceName Variable.
        /// </summary>
        public const uint AutoIdDeviceType_DeviceName = 6124;

        /// <summary>
        /// The identifier for the DeviceStatus Variable.
        /// </summary>
        public const uint AutoIdDeviceType_DeviceStatus = 6030;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_GetDeviceLocation_InputArguments = 6130;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_GetDeviceLocation_OutputArguments = 6129;

        /// <summary>
        /// The identifier for the LastScanData Variable.
        /// </summary>
        public const uint AutoIdDeviceType_LastScanData = 6055;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint OcrReaderDeviceType_Scan_InputArguments = 6027;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint OcrReaderDeviceType_Scan_OutputArguments = 6015;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint OpticalReaderDeviceType_Scan_InputArguments = 6144;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint OpticalReaderDeviceType_Scan_OutputArguments = 6145;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint OpticalVerifierDeviceType_Scan_InputArguments = 6031;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint OpticalVerifierDeviceType_Scan_OutputArguments = 6076;

        /// <summary>
        /// The identifier for the AntennaNames Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_AntennaNames = 6048;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_KillTag_InputArguments = 6062;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_KillTag_OutputArguments = 6063;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_LockTag_InputArguments = 6064;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_LockTag_OutputArguments = 6065;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_ReadTag_InputArguments = 6054;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_ReadTag_OutputArguments = 6056;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_Scan_InputArguments = 6052;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_Scan_OutputArguments = 6043;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_SetTagPassword_InputArguments = 6059;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_SetTagPassword_OutputArguments = 6060;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_WriteTag_InputArguments = 6057;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RfidReaderDeviceType_WriteTag_OutputArguments = 6058;

        /// <summary>
        /// The identifier for the GeographicalUnit Variable.
        /// </summary>
        public const uint RtlsDeviceType_GeographicalUnit = 6214;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RtlsDeviceType_GetLocation_InputArguments = 6224;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RtlsDeviceType_GetLocation_OutputArguments = 6225;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RtlsDeviceType_GetSupportedLocationTypes_OutputArguments = 6226;

        /// <summary>
        /// The identifier for the LengthUnit Variable.
        /// </summary>
        public const uint RtlsDeviceType_LengthUnit = 6217;

        /// <summary>
        /// The identifier for the RotationalUnit Variable.
        /// </summary>
        public const uint RtlsDeviceType_RotationalUnit = 6216;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint RtlsDeviceType_Scan_InputArguments = 6218;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint RtlsDeviceType_Scan_OutputArguments = 6219;

        /// <summary>
        /// The identifier for the SpeedUnit Variable.
        /// </summary>
        public const uint RtlsDeviceType_SpeedUnit = 6215;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Scan_InputArguments = 6050;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_Scan_OutputArguments = 6001;

        /// <summary>
        /// The identifier for the InputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_ScanStart_InputArguments = 6051;

        /// <summary>
        /// The identifier for the OutputArguments Variable.
        /// </summary>
        public const uint AutoIdDeviceType_ScanStart_OutputArguments = 6208;

        /// <summary>
        /// The identifier for the GeographicalUnit Variable.
        /// </summary>
        public const uint LocationVariableType_GeographicalUnit = 6199;

        /// <summary>
        /// The identifier for the LengthUnit Variable.
        /// </summary>
        public const uint LocationVariableType_LengthUnit = 6197;

        /// <summary>
        /// The identifier for the RotationalUnit Variable.
        /// </summary>
        public const uint LocationVariableType_RotationalUnit = 6198;

        /// <summary>
        /// The identifier for the SpeedUnit Variable.
        /// </summary>
        public const uint LocationVariableType_SpeedUnit = 6200;

        /// <summary>
        /// The identifier for the AutoIdModelVersion Object.
        /// </summary>
        public const uint DefaultOCR_AutoIdModelVersion = 6194;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Close_InputArguments = 6077;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_GetPosition_InputArguments = 6078;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_GetPosition_OutputArguments = 6079;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Open_InputArguments = 6080;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Open_OutputArguments = 6081;

        /// <summary>
        /// The identifier for the OpenCount Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_OpenCount = 6082;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Read_InputArguments = 6083;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Read_OutputArguments = 6084;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_SetPosition_InputArguments = 6085;

        /// <summary>
        /// The identifier for the Size Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Size = 6086;

        /// <summary>
        /// The identifier for the UserWritable Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_UserWritable = 6087;

        /// <summary>
        /// The identifier for the Writable Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Writable = 6088;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Configuration_Write_InputArguments = 6089;

        /// <summary>
        /// The identifier for the DeviceInfo Object.
        /// </summary>
        public const uint DefaultOCR_DeviceInfo = 6090;

        /// <summary>
        /// The identifier for the DeviceLocationName Object.
        /// </summary>
        public const uint DefaultOCR_DeviceLocationName = 6069;

        /// <summary>
        /// The identifier for the DeviceManual Object.
        /// </summary>
        public const uint DefaultOCR_DeviceManual = 6164;

        /// <summary>
        /// The identifier for the DeviceName Object.
        /// </summary>
        public const uint DefaultOCR_DeviceName = 6125;

        /// <summary>
        /// The identifier for the DeviceRevision Object.
        /// </summary>
        public const uint DefaultOCR_DeviceRevision = 6165;

        /// <summary>
        /// The identifier for the DeviceStatus Object.
        /// </summary>
        public const uint DefaultOCR_DeviceStatus = 6091;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_GetDeviceLocation_InputArguments = 6070;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_GetDeviceLocation_OutputArguments = 6071;

        /// <summary>
        /// The identifier for the HardwareRevision Object.
        /// </summary>
        public const uint DefaultOCR_HardwareRevision = 6166;

        /// <summary>
        /// The identifier for the Manufacturer Object.
        /// </summary>
        public const uint DefaultOCR_Manufacturer = 6167;

        /// <summary>
        /// The identifier for the Model Object.
        /// </summary>
        public const uint DefaultOCR_Model = 6168;

        /// <summary>
        /// The identifier for the RevisionCounter Object.
        /// </summary>
        public const uint DefaultOCR_RevisionCounter = 6169;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Scan_InputArguments = 6073;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_Scan_OutputArguments = 6074;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOCR_ScanStart_InputArguments = 6028;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOCR_ScanStart_OutputArguments = 6209;

        /// <summary>
        /// The identifier for the SerialNumber Object.
        /// </summary>
        public const uint DefaultOCR_SerialNumber = 6170;

        /// <summary>
        /// The identifier for the SoftwareRevision Object.
        /// </summary>
        public const uint DefaultOCR_SoftwareRevision = 6171;

        /// <summary>
        /// The identifier for the AutoIdModelVersion Object.
        /// </summary>
        public const uint DefaultOptical_AutoIdModelVersion = 6196;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Close_InputArguments = 6148;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_GetPosition_InputArguments = 6149;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_GetPosition_OutputArguments = 6150;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Open_InputArguments = 6151;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Open_OutputArguments = 6152;

        /// <summary>
        /// The identifier for the OpenCount Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_OpenCount = 6153;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Read_InputArguments = 6154;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Read_OutputArguments = 6155;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_SetPosition_InputArguments = 6156;

        /// <summary>
        /// The identifier for the Size Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Size = 6157;

        /// <summary>
        /// The identifier for the UserWritable Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_UserWritable = 6158;

        /// <summary>
        /// The identifier for the Writable Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Writable = 6159;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Configuration_Write_InputArguments = 6160;

        /// <summary>
        /// The identifier for the DeviceInfo Object.
        /// </summary>
        public const uint DefaultOptical_DeviceInfo = 6161;

        /// <summary>
        /// The identifier for the DeviceLocationName Object.
        /// </summary>
        public const uint DefaultOptical_DeviceLocationName = 6068;

        /// <summary>
        /// The identifier for the DeviceManual Object.
        /// </summary>
        public const uint DefaultOptical_DeviceManual = 6180;

        /// <summary>
        /// The identifier for the DeviceName Object.
        /// </summary>
        public const uint DefaultOptical_DeviceName = 6162;

        /// <summary>
        /// The identifier for the DeviceRevision Object.
        /// </summary>
        public const uint DefaultOptical_DeviceRevision = 6181;

        /// <summary>
        /// The identifier for the DeviceStatus Object.
        /// </summary>
        public const uint DefaultOptical_DeviceStatus = 6163;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_GetDeviceLocation_InputArguments = 6072;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_GetDeviceLocation_OutputArguments = 6075;

        /// <summary>
        /// The identifier for the HardwareRevision Object.
        /// </summary>
        public const uint DefaultOptical_HardwareRevision = 6182;

        /// <summary>
        /// The identifier for the Manufacturer Object.
        /// </summary>
        public const uint DefaultOptical_Manufacturer = 6183;

        /// <summary>
        /// The identifier for the Model Object.
        /// </summary>
        public const uint DefaultOptical_Model = 6184;

        /// <summary>
        /// The identifier for the RevisionCounter Object.
        /// </summary>
        public const uint DefaultOptical_RevisionCounter = 6185;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Scan_InputArguments = 6094;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_Scan_OutputArguments = 6133;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultOptical_ScanStart_InputArguments = 6134;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultOptical_ScanStart_OutputArguments = 6211;

        /// <summary>
        /// The identifier for the SerialNumber Object.
        /// </summary>
        public const uint DefaultOptical_SerialNumber = 6186;

        /// <summary>
        /// The identifier for the SoftwareRevision Object.
        /// </summary>
        public const uint DefaultOptical_SoftwareRevision = 6187;

        /// <summary>
        /// The identifier for the AntennaNames Object.
        /// </summary>
        public const uint DefaultRFID_AntennaNames = 6136;

        /// <summary>
        /// The identifier for the AutoIdModelVersion Object.
        /// </summary>
        public const uint DefaultRFID_AutoIdModelVersion = 6195;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Close_InputArguments = 6105;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_GetPosition_InputArguments = 6106;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_GetPosition_OutputArguments = 6107;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Open_InputArguments = 6108;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Open_OutputArguments = 6109;

        /// <summary>
        /// The identifier for the OpenCount Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_OpenCount = 6110;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Read_InputArguments = 6111;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Read_OutputArguments = 6112;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_SetPosition_InputArguments = 6113;

        /// <summary>
        /// The identifier for the Size Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Size = 6114;

        /// <summary>
        /// The identifier for the UserWritable Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_UserWritable = 6115;

        /// <summary>
        /// The identifier for the Writable Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Writable = 6116;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Configuration_Write_InputArguments = 6117;

        /// <summary>
        /// The identifier for the DeviceInfo Object.
        /// </summary>
        public const uint DefaultRFID_DeviceInfo = 6118;

        /// <summary>
        /// The identifier for the DeviceLocationName Object.
        /// </summary>
        public const uint DefaultRFID_DeviceLocationName = 6137;

        /// <summary>
        /// The identifier for the DeviceManual Object.
        /// </summary>
        public const uint DefaultRFID_DeviceManual = 6172;

        /// <summary>
        /// The identifier for the DeviceName Object.
        /// </summary>
        public const uint DefaultRFID_DeviceName = 6126;

        /// <summary>
        /// The identifier for the DeviceRevision Object.
        /// </summary>
        public const uint DefaultRFID_DeviceRevision = 6173;

        /// <summary>
        /// The identifier for the DeviceStatus Object.
        /// </summary>
        public const uint DefaultRFID_DeviceStatus = 6119;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_GetDeviceLocation_InputArguments = 6140;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_GetDeviceLocation_OutputArguments = 6141;

        /// <summary>
        /// The identifier for the HardwareRevision Object.
        /// </summary>
        public const uint DefaultRFID_HardwareRevision = 6174;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_KillTag_InputArguments = 6095;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_KillTag_OutputArguments = 6096;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_LockTag_InputArguments = 6097;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_LockTag_OutputArguments = 6098;

        /// <summary>
        /// The identifier for the Manufacturer Object.
        /// </summary>
        public const uint DefaultRFID_Manufacturer = 6175;

        /// <summary>
        /// The identifier for the Model Object.
        /// </summary>
        public const uint DefaultRFID_Model = 6176;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_ReadTag_InputArguments = 6101;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_ReadTag_OutputArguments = 6102;

        /// <summary>
        /// The identifier for the RevisionCounter Object.
        /// </summary>
        public const uint DefaultRFID_RevisionCounter = 6177;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Scan_InputArguments = 6092;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_Scan_OutputArguments = 6093;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_ScanStart_InputArguments = 6053;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_ScanStart_OutputArguments = 6210;

        /// <summary>
        /// The identifier for the SerialNumber Object.
        /// </summary>
        public const uint DefaultRFID_SerialNumber = 6178;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_SetTagPassword_InputArguments = 6099;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_SetTagPassword_OutputArguments = 6100;

        /// <summary>
        /// The identifier for the SoftwareRevision Object.
        /// </summary>
        public const uint DefaultRFID_SoftwareRevision = 6179;

        /// <summary>
        /// The identifier for the InputArguments Object.
        /// </summary>
        public const uint DefaultRFID_WriteTag_InputArguments = 6103;

        /// <summary>
        /// The identifier for the OutputArguments Object.
        /// </summary>
        public const uint DefaultRFID_WriteTag_OutputArguments = 6104;

    }
    #endregion

    #region VariableTypes Identifiers
    /// <summary>
    /// A class that declares constants for all VariableTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class VariableTypes
    {
        /// <summary>
        /// The identifier for the LocationVariableType VariableType.
        /// </summary>
        public const uint LocationVariableType = 2002;

    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdOperationStatusEnumeration = new ExpandedNodeId(DataTypes.AutoIdOperationStatusEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DeviceStatusEnumeration = new ExpandedNodeId(DataTypes.DeviceStatusEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocationTypeEnumeration = new ExpandedNodeId(DataTypes.LocationTypeEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RfidLockOperationEnumeration = new ExpandedNodeId(DataTypes.RfidLockOperationEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RfidLockRegionEnumeration = new ExpandedNodeId(DataTypes.RfidLockRegionEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RfidPasswordTypeEnumeration = new ExpandedNodeId(DataTypes.RfidPasswordTypeEnumeration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CodeTypeDataType = new ExpandedNodeId(DataTypes.CodeTypeDataType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocationName = new ExpandedNodeId(DataTypes.LocationName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NmeaCoordinateString = new ExpandedNodeId(DataTypes.NmeaCoordinateString, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId AntennaNameIdPair = new ExpandedNodeId(DataTypes.AntennaNameIdPair, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressElement = new ExpandedNodeId(DataTypes.CivicAddressElement, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressType = new ExpandedNodeId(DataTypes.CivicAddressType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate = new ExpandedNodeId(DataTypes.DhcpGeoConfCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Local1DCoordinate = new ExpandedNodeId(DataTypes.Local1DCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocalCoordinate = new ExpandedNodeId(DataTypes.LocalCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Position = new ExpandedNodeId(DataTypes.Position, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RfidSighting = new ExpandedNodeId(DataTypes.RfidSighting, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Rotation = new ExpandedNodeId(DataTypes.Rotation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ScanDataEpc = new ExpandedNodeId(DataTypes.ScanDataEpc, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ScanResult = new ExpandedNodeId(DataTypes.ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OcrScanResult = new ExpandedNodeId(DataTypes.OcrScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalScanResult = new ExpandedNodeId(DataTypes.OpticalScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierScanResult = new ExpandedNodeId(DataTypes.OpticalVerifierScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RfidScanResult = new ExpandedNodeId(DataTypes.RfidScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId RtlsLocationResult = new ExpandedNodeId(DataTypes.RtlsLocationResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ScanSettings = new ExpandedNodeId(DataTypes.ScanSettings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Location = new ExpandedNodeId(DataTypes.Location, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ScanData = new ExpandedNodeId(DataTypes.ScanData, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UtmCoordinate = new ExpandedNodeId(DataTypes.UtmCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the BaseDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId WGS84Coordinate = new ExpandedNodeId(DataTypes.WGS84Coordinate, Namespaces.AutoId);

    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Close = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_Close, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_GetPosition = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_GetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Open = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_Open, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Read = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_Read, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_SetPosition = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_SetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Write = new ExpandedNodeId(Methods.AutoIdDeviceType_Configuration_Write, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_GetDeviceLocation Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation = new ExpandedNodeId(Methods.AutoIdDeviceType_GetDeviceLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan = new ExpandedNodeId(Methods.OcrReaderDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalReaderDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan = new ExpandedNodeId(Methods.OpticalReaderDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan = new ExpandedNodeId(Methods.OpticalVerifierDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_KillTag Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag = new ExpandedNodeId(Methods.RfidReaderDeviceType_KillTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_LockTag Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag = new ExpandedNodeId(Methods.RfidReaderDeviceType_LockTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_ReadTag Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag = new ExpandedNodeId(Methods.RfidReaderDeviceType_ReadTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan = new ExpandedNodeId(Methods.RfidReaderDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_SetTagPassword Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword = new ExpandedNodeId(Methods.RfidReaderDeviceType_SetTagPassword, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_WriteTag Method.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag = new ExpandedNodeId(Methods.RfidReaderDeviceType_WriteTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetLocation Method.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation = new ExpandedNodeId(Methods.RtlsDeviceType_GetLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetSupportedLocationTypes Method.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetSupportedLocationTypes = new ExpandedNodeId(Methods.RtlsDeviceType_GetSupportedLocationTypes, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetUnits Method.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetUnits = new ExpandedNodeId(Methods.RtlsDeviceType_GetUnits, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_Scan = new ExpandedNodeId(Methods.RtlsDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan = new ExpandedNodeId(Methods.AutoIdDeviceType_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_ScanStart Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart = new ExpandedNodeId(Methods.AutoIdDeviceType_ScanStart, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_ScanStop Method.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStop = new ExpandedNodeId(Methods.AutoIdDeviceType_ScanStop, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Close = new ExpandedNodeId(Methods.DefaultOCR_Configuration_Close, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_GetPosition = new ExpandedNodeId(Methods.DefaultOCR_Configuration_GetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Open = new ExpandedNodeId(Methods.DefaultOCR_Configuration_Open, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Read = new ExpandedNodeId(Methods.DefaultOCR_Configuration_Read, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_SetPosition = new ExpandedNodeId(Methods.DefaultOCR_Configuration_SetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Write = new ExpandedNodeId(Methods.DefaultOCR_Configuration_Write, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_GetDeviceLocation Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_GetDeviceLocation = new ExpandedNodeId(Methods.DefaultOCR_GetDeviceLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Scan = new ExpandedNodeId(Methods.DefaultOCR_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_ScanStart Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_ScanStart = new ExpandedNodeId(Methods.DefaultOCR_ScanStart, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_ScanStop Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_ScanStop = new ExpandedNodeId(Methods.DefaultOCR_ScanStop, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Close = new ExpandedNodeId(Methods.DefaultOptical_Configuration_Close, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_GetPosition = new ExpandedNodeId(Methods.DefaultOptical_Configuration_GetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Open = new ExpandedNodeId(Methods.DefaultOptical_Configuration_Open, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Read = new ExpandedNodeId(Methods.DefaultOptical_Configuration_Read, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_SetPosition = new ExpandedNodeId(Methods.DefaultOptical_Configuration_SetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Write = new ExpandedNodeId(Methods.DefaultOptical_Configuration_Write, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_GetDeviceLocation Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_GetDeviceLocation = new ExpandedNodeId(Methods.DefaultOptical_GetDeviceLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Scan = new ExpandedNodeId(Methods.DefaultOptical_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_ScanStart Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_ScanStart = new ExpandedNodeId(Methods.DefaultOptical_ScanStart, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_ScanStop Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_ScanStop = new ExpandedNodeId(Methods.DefaultOptical_ScanStop, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Close = new ExpandedNodeId(Methods.DefaultRFID_Configuration_Close, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_GetPosition = new ExpandedNodeId(Methods.DefaultRFID_Configuration_GetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Open = new ExpandedNodeId(Methods.DefaultRFID_Configuration_Open, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Read = new ExpandedNodeId(Methods.DefaultRFID_Configuration_Read, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_SetPosition = new ExpandedNodeId(Methods.DefaultRFID_Configuration_SetPosition, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Write = new ExpandedNodeId(Methods.DefaultRFID_Configuration_Write, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_GetDeviceLocation Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_GetDeviceLocation = new ExpandedNodeId(Methods.DefaultRFID_GetDeviceLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_KillTag Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_KillTag = new ExpandedNodeId(Methods.DefaultRFID_KillTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_LockTag Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_LockTag = new ExpandedNodeId(Methods.DefaultRFID_LockTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ReadTag Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ReadTag = new ExpandedNodeId(Methods.DefaultRFID_ReadTag, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Scan Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Scan = new ExpandedNodeId(Methods.DefaultRFID_Scan, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ScanStart Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ScanStart = new ExpandedNodeId(Methods.DefaultRFID_ScanStart, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ScanStop Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ScanStop = new ExpandedNodeId(Methods.DefaultRFID_ScanStop, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_SetTagPassword Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_SetTagPassword = new ExpandedNodeId(Methods.DefaultRFID_SetTagPassword, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_WriteTag Method.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_WriteTag = new ExpandedNodeId(Methods.DefaultRFID_WriteTag, Namespaces.AutoId);

    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the AntennaNameIdPair_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId AntennaNameIdPair_Encoding_DefaultBinary = new ExpandedNodeId(Objects.AntennaNameIdPair_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AntennaNameIdPair_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId AntennaNameIdPair_Encoding_DefaultXml = new ExpandedNodeId(Objects.AntennaNameIdPair_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the CivicAddressElement_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressElement_Encoding_DefaultBinary = new ExpandedNodeId(Objects.CivicAddressElement_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the CivicAddressElement_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressElement_Encoding_DefaultXml = new ExpandedNodeId(Objects.CivicAddressElement_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the CivicAddressType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressType_Encoding_DefaultBinary = new ExpandedNodeId(Objects.CivicAddressType_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the CivicAddressType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId CivicAddressType_Encoding_DefaultXml = new ExpandedNodeId(Objects.CivicAddressType_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DhcpGeoConfCoordinate_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Objects.DhcpGeoConfCoordinate_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DhcpGeoConfCoordinate_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId DhcpGeoConfCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Objects.DhcpGeoConfCoordinate_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Local1DCoordinate_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId Local1DCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Objects.Local1DCoordinate_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Local1DCoordinate_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId Local1DCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Objects.Local1DCoordinate_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocalCoordinate_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId LocalCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Objects.LocalCoordinate_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocalCoordinate_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId LocalCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Objects.LocalCoordinate_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Position_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId Position_Encoding_DefaultBinary = new ExpandedNodeId(Objects.Position_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Position_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId Position_Encoding_DefaultXml = new ExpandedNodeId(Objects.Position_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidSighting_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId RfidSighting_Encoding_DefaultBinary = new ExpandedNodeId(Objects.RfidSighting_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidSighting_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId RfidSighting_Encoding_DefaultXml = new ExpandedNodeId(Objects.RfidSighting_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Rotation_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId Rotation_Encoding_DefaultBinary = new ExpandedNodeId(Objects.Rotation_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Rotation_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId Rotation_Encoding_DefaultXml = new ExpandedNodeId(Objects.Rotation_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanDataEpc_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanDataEpc_Encoding_DefaultBinary = new ExpandedNodeId(Objects.ScanDataEpc_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanDataEpc_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanDataEpc_Encoding_DefaultXml = new ExpandedNodeId(Objects.ScanDataEpc_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.ScanResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.ScanResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrScanResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OcrScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.OcrScanResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrScanResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OcrScanResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.OcrScanResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalScanResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OpticalScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.OpticalScanResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalScanResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OpticalScanResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.OpticalScanResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierScanResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.OpticalVerifierScanResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierScanResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierScanResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.OpticalVerifierScanResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidScanResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId RfidScanResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.RfidScanResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidScanResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId RfidScanResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.RfidScanResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsLocationResult_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId RtlsLocationResult_Encoding_DefaultBinary = new ExpandedNodeId(Objects.RtlsLocationResult_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsLocationResult_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId RtlsLocationResult_Encoding_DefaultXml = new ExpandedNodeId(Objects.RtlsLocationResult_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanSettings_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanSettings_Encoding_DefaultBinary = new ExpandedNodeId(Objects.ScanSettings_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanSettings_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanSettings_Encoding_DefaultXml = new ExpandedNodeId(Objects.ScanSettings_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Location_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId Location_Encoding_DefaultBinary = new ExpandedNodeId(Objects.Location_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the Location_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId Location_Encoding_DefaultXml = new ExpandedNodeId(Objects.Location_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanData_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanData_Encoding_DefaultBinary = new ExpandedNodeId(Objects.ScanData_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the ScanData_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ScanData_Encoding_DefaultXml = new ExpandedNodeId(Objects.ScanData_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the UtmCoordinate_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId UtmCoordinate_Encoding_DefaultBinary = new ExpandedNodeId(Objects.UtmCoordinate_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the UtmCoordinate_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId UtmCoordinate_Encoding_DefaultXml = new ExpandedNodeId(Objects.UtmCoordinate_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the WGS84Coordinate_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId WGS84Coordinate_Encoding_DefaultBinary = new ExpandedNodeId(Objects.WGS84Coordinate_Encoding_DefaultBinary, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the WGS84Coordinate_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId WGS84Coordinate_Encoding_DefaultXml = new ExpandedNodeId(Objects.WGS84Coordinate_Encoding_DefaultXml, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration = new ExpandedNodeId(Objects.AutoIdDeviceType_Configuration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_IOData Object.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_IOData = new ExpandedNodeId(Objects.AutoIdDeviceType_IOData, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType_Images Object.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType_Images = new ExpandedNodeId(Objects.OcrReaderDeviceType_Images, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType_OcrScanEventType Object.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType_OcrScanEventType = new ExpandedNodeId(Objects.OcrReaderDeviceType_OcrScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_RuntimeParameters Object.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_RuntimeParameters = new ExpandedNodeId(Objects.AutoIdDeviceType_RuntimeParameters, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR = new ExpandedNodeId(Objects.DefaultOCR, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration = new ExpandedNodeId(Objects.DefaultOCR_Configuration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Images Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Images = new ExpandedNodeId(Objects.DefaultOCR_Images, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical = new ExpandedNodeId(Objects.DefaultOptical, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration = new ExpandedNodeId(Objects.DefaultOptical_Configuration, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID = new ExpandedNodeId(Objects.DefaultRFID, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration = new ExpandedNodeId(Objects.DefaultRFID_Configuration, Namespaces.AutoId);

    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the AutoIdScanEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdScanEventType = new ExpandedNodeId(ObjectTypes.AutoIdScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrScanEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OcrScanEventType = new ExpandedNodeId(ObjectTypes.OcrScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalScanEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalScanEventType = new ExpandedNodeId(ObjectTypes.OpticalScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierScanEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierScanEventType = new ExpandedNodeId(ObjectTypes.OpticalVerifierScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidScanEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RfidScanEventType = new ExpandedNodeId(ObjectTypes.RfidScanEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsLocationEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RtlsLocationEventType = new ExpandedNodeId(ObjectTypes.RtlsLocationEventType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType = new ExpandedNodeId(ObjectTypes.AutoIdDeviceType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType = new ExpandedNodeId(ObjectTypes.OcrReaderDeviceType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalReaderDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalReaderDeviceType = new ExpandedNodeId(ObjectTypes.OpticalReaderDeviceType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierDeviceType = new ExpandedNodeId(ObjectTypes.OpticalVerifierDeviceType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType = new ExpandedNodeId(ObjectTypes.RfidReaderDeviceType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType = new ExpandedNodeId(ObjectTypes.RtlsDeviceType, Namespaces.AutoId);

    }
    #endregion

    #region ReferenceType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ReferenceTypes in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class ReferenceTypeIds
    {
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the AutoIdOperationStatusEnumeration_EnumValues Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdOperationStatusEnumeration_EnumValues = new ExpandedNodeId(Variables.AutoIdOperationStatusEnumeration_EnumValues, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DeviceStatusEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId DeviceStatusEnumeration_EnumStrings = new ExpandedNodeId(Variables.DeviceStatusEnumeration_EnumStrings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocationTypeEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationTypeEnumeration_EnumStrings = new ExpandedNodeId(Variables.LocationTypeEnumeration_EnumStrings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidLockOperationEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidLockOperationEnumeration_EnumStrings = new ExpandedNodeId(Variables.RfidLockOperationEnumeration_EnumStrings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidLockRegionEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidLockRegionEnumeration_EnumStrings = new ExpandedNodeId(Variables.RfidLockRegionEnumeration_EnumStrings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidPasswordTypeEnumeration_EnumStrings Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidPasswordTypeEnumeration_EnumStrings = new ExpandedNodeId(Variables.RfidPasswordTypeEnumeration_EnumStrings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema = new ExpandedNodeId(Variables.AutoID_BinarySchema, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_AntennaNameIdPair Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_AntennaNameIdPair = new ExpandedNodeId(Variables.AutoID_BinarySchema_AntennaNameIdPair, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_CivicAddressElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_CivicAddressElement = new ExpandedNodeId(Variables.AutoID_BinarySchema_CivicAddressElement, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_CivicAddressType Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_CivicAddressType = new ExpandedNodeId(Variables.AutoID_BinarySchema_CivicAddressType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_DhcpGeoConfCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_DhcpGeoConfCoordinate = new ExpandedNodeId(Variables.AutoID_BinarySchema_DhcpGeoConfCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_Local1DCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_Local1DCoordinate = new ExpandedNodeId(Variables.AutoID_BinarySchema_Local1DCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_LocalCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_LocalCoordinate = new ExpandedNodeId(Variables.AutoID_BinarySchema_LocalCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_Location Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_Location = new ExpandedNodeId(Variables.AutoID_BinarySchema_Location, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_NamespaceUri = new ExpandedNodeId(Variables.AutoID_BinarySchema_NamespaceUri, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_OcrScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_OcrScanResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_OcrScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_OpticalScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_OpticalScanResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_OpticalScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_OpticalVerifierScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_OpticalVerifierScanResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_OpticalVerifierScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_Position Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_Position = new ExpandedNodeId(Variables.AutoID_BinarySchema_Position, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_RfidScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_RfidScanResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_RfidScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_RfidSighting Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_RfidSighting = new ExpandedNodeId(Variables.AutoID_BinarySchema_RfidSighting, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_Rotation Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_Rotation = new ExpandedNodeId(Variables.AutoID_BinarySchema_Rotation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_RtlsLocationResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_RtlsLocationResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_RtlsLocationResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_ScanData Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_ScanData = new ExpandedNodeId(Variables.AutoID_BinarySchema_ScanData, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_ScanDataEpc Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_ScanDataEpc = new ExpandedNodeId(Variables.AutoID_BinarySchema_ScanDataEpc, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_ScanResult = new ExpandedNodeId(Variables.AutoID_BinarySchema_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_ScanSettings Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_ScanSettings = new ExpandedNodeId(Variables.AutoID_BinarySchema_ScanSettings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_UtmCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_UtmCoordinate = new ExpandedNodeId(Variables.AutoID_BinarySchema_UtmCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_BinarySchema_WGS84Coordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_BinarySchema_WGS84Coordinate = new ExpandedNodeId(Variables.AutoID_BinarySchema_WGS84Coordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema = new ExpandedNodeId(Variables.AutoID_XmlSchema, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_AntennaNameIdPair Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_AntennaNameIdPair = new ExpandedNodeId(Variables.AutoID_XmlSchema_AntennaNameIdPair, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_CivicAddressElement Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_CivicAddressElement = new ExpandedNodeId(Variables.AutoID_XmlSchema_CivicAddressElement, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_CivicAddressType Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_CivicAddressType = new ExpandedNodeId(Variables.AutoID_XmlSchema_CivicAddressType, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_DhcpGeoConfCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_DhcpGeoConfCoordinate = new ExpandedNodeId(Variables.AutoID_XmlSchema_DhcpGeoConfCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_Local1DCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_Local1DCoordinate = new ExpandedNodeId(Variables.AutoID_XmlSchema_Local1DCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_LocalCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_LocalCoordinate = new ExpandedNodeId(Variables.AutoID_XmlSchema_LocalCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_Location Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_Location = new ExpandedNodeId(Variables.AutoID_XmlSchema_Location, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_NamespaceUri = new ExpandedNodeId(Variables.AutoID_XmlSchema_NamespaceUri, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_OcrScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_OcrScanResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_OcrScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_OpticalScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_OpticalScanResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_OpticalScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_OpticalVerifierScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_OpticalVerifierScanResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_OpticalVerifierScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_Position Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_Position = new ExpandedNodeId(Variables.AutoID_XmlSchema_Position, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_RfidScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_RfidScanResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_RfidScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_RfidSighting Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_RfidSighting = new ExpandedNodeId(Variables.AutoID_XmlSchema_RfidSighting, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_Rotation Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_Rotation = new ExpandedNodeId(Variables.AutoID_XmlSchema_Rotation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_RtlsLocationResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_RtlsLocationResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_RtlsLocationResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_ScanData Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_ScanData = new ExpandedNodeId(Variables.AutoID_XmlSchema_ScanData, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_ScanDataEpc Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_ScanDataEpc = new ExpandedNodeId(Variables.AutoID_XmlSchema_ScanDataEpc, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_ScanResult = new ExpandedNodeId(Variables.AutoID_XmlSchema_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_ScanSettings Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_ScanSettings = new ExpandedNodeId(Variables.AutoID_XmlSchema_ScanSettings, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_UtmCoordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_UtmCoordinate = new ExpandedNodeId(Variables.AutoID_XmlSchema_UtmCoordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoID_XmlSchema_WGS84Coordinate Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoID_XmlSchema_WGS84Coordinate = new ExpandedNodeId(Variables.AutoID_XmlSchema_WGS84Coordinate, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdScanEventType_DeviceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdScanEventType_DeviceName = new ExpandedNodeId(Variables.AutoIdScanEventType_DeviceName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrScanEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OcrScanEventType_ScanResult = new ExpandedNodeId(Variables.OcrScanEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalScanEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalScanEventType_ScanResult = new ExpandedNodeId(Variables.OpticalScanEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierScanEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierScanEventType_ScanResult = new ExpandedNodeId(Variables.OpticalVerifierScanEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidScanEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidScanEventType_ScanResult = new ExpandedNodeId(Variables.RfidScanEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsLocationEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsLocationEventType_ScanResult = new ExpandedNodeId(Variables.RtlsLocationEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdScanEventType_ScanResult Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdScanEventType_ScanResult = new ExpandedNodeId(Variables.AutoIdScanEventType_ScanResult, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_AutoIdModelVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_AutoIdModelVersion = new ExpandedNodeId(Variables.AutoIdDeviceType_AutoIdModelVersion, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Close_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Close_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_GetPosition_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_GetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_GetPosition_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_GetPosition_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Open_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Open_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Open_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Open_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_OpenCount = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_OpenCount, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Read_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Read_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Read_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Read_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_SetPosition_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_SetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Size = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Size, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_UserWritable = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_UserWritable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Writable = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Writable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Configuration_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Configuration_Write_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Configuration_Write_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_DeviceInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceInfo = new ExpandedNodeId(Variables.AutoIdDeviceType_DeviceInfo, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_DeviceLocation Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceLocation = new ExpandedNodeId(Variables.AutoIdDeviceType_DeviceLocation, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_DeviceLocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceLocationName = new ExpandedNodeId(Variables.AutoIdDeviceType_DeviceLocationName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_DeviceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceName = new ExpandedNodeId(Variables.AutoIdDeviceType_DeviceName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_DeviceStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_DeviceStatus = new ExpandedNodeId(Variables.AutoIdDeviceType_DeviceStatus, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_GetDeviceLocation_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_GetDeviceLocation_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_GetDeviceLocation_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_GetDeviceLocation_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_LastScanData Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_LastScanData = new ExpandedNodeId(Variables.AutoIdDeviceType_LastScanData, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.OcrReaderDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OcrReaderDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OcrReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.OcrReaderDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalReaderDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.OpticalReaderDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalReaderDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.OpticalReaderDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.OpticalVerifierDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the OpticalVerifierDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId OpticalVerifierDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.OpticalVerifierDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_AntennaNames Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_AntennaNames = new ExpandedNodeId(Variables.RfidReaderDeviceType_AntennaNames, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_KillTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_KillTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_KillTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_KillTag_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_KillTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_LockTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_LockTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_LockTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_LockTag_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_LockTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_ReadTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_ReadTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_ReadTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_ReadTag_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_ReadTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_SetTagPassword_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_SetTagPassword_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_SetTagPassword_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_SetTagPassword_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_SetTagPassword_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_WriteTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag_InputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_WriteTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RfidReaderDeviceType_WriteTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RfidReaderDeviceType_WriteTag_OutputArguments = new ExpandedNodeId(Variables.RfidReaderDeviceType_WriteTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GeographicalUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GeographicalUnit = new ExpandedNodeId(Variables.RtlsDeviceType_GeographicalUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetLocation_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation_InputArguments = new ExpandedNodeId(Variables.RtlsDeviceType_GetLocation_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetLocation_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetLocation_OutputArguments = new ExpandedNodeId(Variables.RtlsDeviceType_GetLocation_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_GetSupportedLocationTypes_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_GetSupportedLocationTypes_OutputArguments = new ExpandedNodeId(Variables.RtlsDeviceType_GetSupportedLocationTypes_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_LengthUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_LengthUnit = new ExpandedNodeId(Variables.RtlsDeviceType_LengthUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_RotationalUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_RotationalUnit = new ExpandedNodeId(Variables.RtlsDeviceType_RotationalUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.RtlsDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.RtlsDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the RtlsDeviceType_SpeedUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId RtlsDeviceType_SpeedUnit = new ExpandedNodeId(Variables.RtlsDeviceType_SpeedUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_Scan_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_ScanStart_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart_InputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_ScanStart_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the AutoIdDeviceType_ScanStart_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId AutoIdDeviceType_ScanStart_OutputArguments = new ExpandedNodeId(Variables.AutoIdDeviceType_ScanStart_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocationVariableType_GeographicalUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationVariableType_GeographicalUnit = new ExpandedNodeId(Variables.LocationVariableType_GeographicalUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocationVariableType_LengthUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationVariableType_LengthUnit = new ExpandedNodeId(Variables.LocationVariableType_LengthUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocationVariableType_RotationalUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationVariableType_RotationalUnit = new ExpandedNodeId(Variables.LocationVariableType_RotationalUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the LocationVariableType_SpeedUnit Variable.
        /// </summary>
        public static readonly ExpandedNodeId LocationVariableType_SpeedUnit = new ExpandedNodeId(Variables.LocationVariableType_SpeedUnit, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_AutoIdModelVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_AutoIdModelVersion = new ExpandedNodeId(Variables.DefaultOCR_AutoIdModelVersion, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Close_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Close_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_GetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_GetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_GetPosition_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_GetPosition_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Open_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Open_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Open_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Open_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_OpenCount = new ExpandedNodeId(Variables.DefaultOCR_Configuration_OpenCount, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Read_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Read_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Read_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Read_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_SetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_SetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Size = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Size, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_UserWritable = new ExpandedNodeId(Variables.DefaultOCR_Configuration_UserWritable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Writable = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Writable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Configuration_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Configuration_Write_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Configuration_Write_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceInfo = new ExpandedNodeId(Variables.DefaultOCR_DeviceInfo, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceLocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceLocationName = new ExpandedNodeId(Variables.DefaultOCR_DeviceLocationName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceManual = new ExpandedNodeId(Variables.DefaultOCR_DeviceManual, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceName = new ExpandedNodeId(Variables.DefaultOCR_DeviceName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceRevision = new ExpandedNodeId(Variables.DefaultOCR_DeviceRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_DeviceStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_DeviceStatus = new ExpandedNodeId(Variables.DefaultOCR_DeviceStatus, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_GetDeviceLocation_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_GetDeviceLocation_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_GetDeviceLocation_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_GetDeviceLocation_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_GetDeviceLocation_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_HardwareRevision = new ExpandedNodeId(Variables.DefaultOCR_HardwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Manufacturer = new ExpandedNodeId(Variables.DefaultOCR_Manufacturer, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Model = new ExpandedNodeId(Variables.DefaultOCR_Model, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_RevisionCounter = new ExpandedNodeId(Variables.DefaultOCR_RevisionCounter, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Scan_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_Scan_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_ScanStart_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_ScanStart_InputArguments = new ExpandedNodeId(Variables.DefaultOCR_ScanStart_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_ScanStart_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_ScanStart_OutputArguments = new ExpandedNodeId(Variables.DefaultOCR_ScanStart_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_SerialNumber = new ExpandedNodeId(Variables.DefaultOCR_SerialNumber, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOCR_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOCR_SoftwareRevision = new ExpandedNodeId(Variables.DefaultOCR_SoftwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_AutoIdModelVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_AutoIdModelVersion = new ExpandedNodeId(Variables.DefaultOptical_AutoIdModelVersion, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Close_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Close_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_GetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_GetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_GetPosition_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_GetPosition_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Open_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Open_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Open_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Open_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_OpenCount = new ExpandedNodeId(Variables.DefaultOptical_Configuration_OpenCount, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Read_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Read_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Read_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Read_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_SetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_SetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Size = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Size, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_UserWritable = new ExpandedNodeId(Variables.DefaultOptical_Configuration_UserWritable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Writable = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Writable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Configuration_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Configuration_Write_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Configuration_Write_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceInfo = new ExpandedNodeId(Variables.DefaultOptical_DeviceInfo, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceLocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceLocationName = new ExpandedNodeId(Variables.DefaultOptical_DeviceLocationName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceManual = new ExpandedNodeId(Variables.DefaultOptical_DeviceManual, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceName = new ExpandedNodeId(Variables.DefaultOptical_DeviceName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceRevision = new ExpandedNodeId(Variables.DefaultOptical_DeviceRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_DeviceStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_DeviceStatus = new ExpandedNodeId(Variables.DefaultOptical_DeviceStatus, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_GetDeviceLocation_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_GetDeviceLocation_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_GetDeviceLocation_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_GetDeviceLocation_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_GetDeviceLocation_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_HardwareRevision = new ExpandedNodeId(Variables.DefaultOptical_HardwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Manufacturer = new ExpandedNodeId(Variables.DefaultOptical_Manufacturer, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Model = new ExpandedNodeId(Variables.DefaultOptical_Model, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_RevisionCounter = new ExpandedNodeId(Variables.DefaultOptical_RevisionCounter, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Scan_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_Scan_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_ScanStart_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_ScanStart_InputArguments = new ExpandedNodeId(Variables.DefaultOptical_ScanStart_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_ScanStart_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_ScanStart_OutputArguments = new ExpandedNodeId(Variables.DefaultOptical_ScanStart_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_SerialNumber = new ExpandedNodeId(Variables.DefaultOptical_SerialNumber, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultOptical_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultOptical_SoftwareRevision = new ExpandedNodeId(Variables.DefaultOptical_SoftwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_AntennaNames Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_AntennaNames = new ExpandedNodeId(Variables.DefaultRFID_AntennaNames, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_AutoIdModelVersion Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_AutoIdModelVersion = new ExpandedNodeId(Variables.DefaultRFID_AutoIdModelVersion, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Close_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Close_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_GetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_GetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_GetPosition_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_GetPosition_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Open_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Open_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Open_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Open_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_OpenCount = new ExpandedNodeId(Variables.DefaultRFID_Configuration_OpenCount, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Read_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Read_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Read_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Read_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_SetPosition_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_SetPosition_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Size = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Size, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_UserWritable = new ExpandedNodeId(Variables.DefaultRFID_Configuration_UserWritable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Writable = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Writable, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Configuration_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Configuration_Write_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Configuration_Write_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceInfo Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceInfo = new ExpandedNodeId(Variables.DefaultRFID_DeviceInfo, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceLocationName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceLocationName = new ExpandedNodeId(Variables.DefaultRFID_DeviceLocationName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceManual = new ExpandedNodeId(Variables.DefaultRFID_DeviceManual, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceName = new ExpandedNodeId(Variables.DefaultRFID_DeviceName, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceRevision = new ExpandedNodeId(Variables.DefaultRFID_DeviceRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_DeviceStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_DeviceStatus = new ExpandedNodeId(Variables.DefaultRFID_DeviceStatus, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_GetDeviceLocation_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_GetDeviceLocation_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_GetDeviceLocation_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_GetDeviceLocation_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_GetDeviceLocation_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_GetDeviceLocation_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_HardwareRevision = new ExpandedNodeId(Variables.DefaultRFID_HardwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_KillTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_KillTag_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_KillTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_KillTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_KillTag_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_KillTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_LockTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_LockTag_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_LockTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_LockTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_LockTag_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_LockTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Manufacturer = new ExpandedNodeId(Variables.DefaultRFID_Manufacturer, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Model = new ExpandedNodeId(Variables.DefaultRFID_Model, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ReadTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ReadTag_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_ReadTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ReadTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ReadTag_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_ReadTag_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_RevisionCounter = new ExpandedNodeId(Variables.DefaultRFID_RevisionCounter, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Scan_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Scan_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_Scan_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_Scan_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_Scan_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_Scan_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ScanStart_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ScanStart_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_ScanStart_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_ScanStart_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_ScanStart_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_ScanStart_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_SerialNumber = new ExpandedNodeId(Variables.DefaultRFID_SerialNumber, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_SetTagPassword_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_SetTagPassword_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_SetTagPassword_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_SetTagPassword_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_SetTagPassword_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_SetTagPassword_OutputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_SoftwareRevision = new ExpandedNodeId(Variables.DefaultRFID_SoftwareRevision, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_WriteTag_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_WriteTag_InputArguments = new ExpandedNodeId(Variables.DefaultRFID_WriteTag_InputArguments, Namespaces.AutoId);

        /// <summary>
        /// The identifier for the DefaultRFID_WriteTag_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId DefaultRFID_WriteTag_OutputArguments = new ExpandedNodeId(Variables.DefaultRFID_WriteTag_OutputArguments, Namespaces.AutoId);

    }
    #endregion

    #region VariableType Node Identifiers
    /// <summary>
    /// A class that declares constants for all VariableType in the Model.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("UaModeler", "1.5.1")]
    public static partial class VariableTypeIds
    {
        /// <summary>
        /// The identifier for the LocationVariableType VariableType.
        /// </summary>
        public static readonly ExpandedNodeId LocationVariableType = new ExpandedNodeId(VariableTypes.LocationVariableType, Namespaces.AutoId);

    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AntennaNameIdPair component.
        /// </summary>
        public const string AntennaNameIdPair = "AntennaNameIdPair";
        /// <summary>
        /// The BrowseName for the AntennaNames component.
        /// </summary>
        public const string AntennaNames = "AntennaNames";
        /// <summary>
        /// The BrowseName for the AutoID component.
        /// </summary>
        public const string AutoID = "AutoID";
        /// <summary>
        /// The BrowseName for the AutoIdDeviceType component.
        /// </summary>
        public const string AutoIdDeviceType = "AutoIdDeviceType";
        /// <summary>
        /// The BrowseName for the AutoIdModelVersion component.
        /// </summary>
        public const string AutoIdModelVersion = "AutoIdModelVersion";
        /// <summary>
        /// The BrowseName for the AutoIdOperationStatusEnumeration component.
        /// </summary>
        public const string AutoIdOperationStatusEnumeration = "AutoIdOperationStatusEnumeration";
        /// <summary>
        /// The BrowseName for the AutoIdScanEventType component.
        /// </summary>
        public const string AutoIdScanEventType = "AutoIdScanEventType";
        /// <summary>
        /// The BrowseName for the CivicAddressElement component.
        /// </summary>
        public const string CivicAddressElement = "CivicAddressElement";
        /// <summary>
        /// The BrowseName for the CivicAddressType component.
        /// </summary>
        public const string CivicAddressType = "CivicAddressType";
        /// <summary>
        /// The BrowseName for the CodeTypeDataType component.
        /// </summary>
        public const string CodeTypeDataType = "CodeTypeDataType";
        /// <summary>
        /// The BrowseName for the Configuration component.
        /// </summary>
        public const string Configuration = "Configuration";
        /// <summary>
        /// The BrowseName for the DefaultOCR component.
        /// </summary>
        public const string DefaultOCR = "DefaultOCR";
        /// <summary>
        /// The BrowseName for the DefaultOptical component.
        /// </summary>
        public const string DefaultOptical = "DefaultOptical";
        /// <summary>
        /// The BrowseName for the DefaultRFID component.
        /// </summary>
        public const string DefaultRFID = "DefaultRFID";
        /// <summary>
        /// The BrowseName for the DeviceInfo component.
        /// </summary>
        public const string DeviceInfo = "DeviceInfo";
        /// <summary>
        /// The BrowseName for the DeviceLocation component.
        /// </summary>
        public const string DeviceLocation = "DeviceLocation";
        /// <summary>
        /// The BrowseName for the DeviceLocationName component.
        /// </summary>
        public const string DeviceLocationName = "DeviceLocationName";
        /// <summary>
        /// The BrowseName for the DeviceName component.
        /// </summary>
        public const string DeviceName = "DeviceName";
        /// <summary>
        /// The BrowseName for the DeviceStatus component.
        /// </summary>
        public const string DeviceStatus = "DeviceStatus";
        /// <summary>
        /// The BrowseName for the DeviceStatusEnumeration component.
        /// </summary>
        public const string DeviceStatusEnumeration = "DeviceStatusEnumeration";
        /// <summary>
        /// The BrowseName for the DhcpGeoConfCoordinate component.
        /// </summary>
        public const string DhcpGeoConfCoordinate = "DhcpGeoConfCoordinate";
        /// <summary>
        /// The BrowseName for the GeographicalUnit component.
        /// </summary>
        public const string GeographicalUnit = "GeographicalUnit";
        /// <summary>
        /// The BrowseName for the GetDeviceLocation component.
        /// </summary>
        public const string GetDeviceLocation = "GetDeviceLocation";
        /// <summary>
        /// The BrowseName for the GetLocation component.
        /// </summary>
        public const string GetLocation = "GetLocation";
        /// <summary>
        /// The BrowseName for the GetSupportedLocationTypes component.
        /// </summary>
        public const string GetSupportedLocationTypes = "GetSupportedLocationTypes";
        /// <summary>
        /// The BrowseName for the GetUnits component.
        /// </summary>
        public const string GetUnits = "GetUnits";
        /// <summary>
        /// The BrowseName for the IOData component.
        /// </summary>
        public const string IOData = "IOData";
        /// <summary>
        /// The BrowseName for the Images component.
        /// </summary>
        public const string Images = "Images";
        /// <summary>
        /// The BrowseName for the KillTag component.
        /// </summary>
        public const string KillTag = "KillTag";
        /// <summary>
        /// The BrowseName for the LastScanData component.
        /// </summary>
        public const string LastScanData = "LastScanData";
        /// <summary>
        /// The BrowseName for the LengthUnit component.
        /// </summary>
        public const string LengthUnit = "LengthUnit";
        /// <summary>
        /// The BrowseName for the Local1DCoordinate component.
        /// </summary>
        public const string Local1DCoordinate = "Local1DCoordinate";
        /// <summary>
        /// The BrowseName for the LocalCoordinate component.
        /// </summary>
        public const string LocalCoordinate = "LocalCoordinate";
        /// <summary>
        /// The BrowseName for the Location component.
        /// </summary>
        public const string Location = "Location";
        /// <summary>
        /// The BrowseName for the LocationName component.
        /// </summary>
        public const string LocationName = "LocationName";
        /// <summary>
        /// The BrowseName for the LocationTypeEnumeration component.
        /// </summary>
        public const string LocationTypeEnumeration = "LocationTypeEnumeration";
        /// <summary>
        /// The BrowseName for the LocationVariableType component.
        /// </summary>
        public const string LocationVariableType = "LocationVariableType";
        /// <summary>
        /// The BrowseName for the LockTag component.
        /// </summary>
        public const string LockTag = "LockTag";
        /// <summary>
        /// The BrowseName for the NmeaCoordinateString component.
        /// </summary>
        public const string NmeaCoordinateString = "NmeaCoordinateString";
        /// <summary>
        /// The BrowseName for the OcrReaderDeviceType component.
        /// </summary>
        public const string OcrReaderDeviceType = "OcrReaderDeviceType";
        /// <summary>
        /// The BrowseName for the OcrScanEventType component.
        /// </summary>
        public const string OcrScanEventType = "OcrScanEventType";
        /// <summary>
        /// The BrowseName for the OcrScanResult component.
        /// </summary>
        public const string OcrScanResult = "OcrScanResult";
        /// <summary>
        /// The BrowseName for the OpticalReaderDeviceType component.
        /// </summary>
        public const string OpticalReaderDeviceType = "OpticalReaderDeviceType";
        /// <summary>
        /// The BrowseName for the OpticalScanEventType component.
        /// </summary>
        public const string OpticalScanEventType = "OpticalScanEventType";
        /// <summary>
        /// The BrowseName for the OpticalScanResult component.
        /// </summary>
        public const string OpticalScanResult = "OpticalScanResult";
        /// <summary>
        /// The BrowseName for the OpticalVerifierDeviceType component.
        /// </summary>
        public const string OpticalVerifierDeviceType = "OpticalVerifierDeviceType";
        /// <summary>
        /// The BrowseName for the OpticalVerifierScanEventType component.
        /// </summary>
        public const string OpticalVerifierScanEventType = "OpticalVerifierScanEventType";
        /// <summary>
        /// The BrowseName for the OpticalVerifierScanResult component.
        /// </summary>
        public const string OpticalVerifierScanResult = "OpticalVerifierScanResult";
        /// <summary>
        /// The BrowseName for the Position component.
        /// </summary>
        public const string Position = "Position";
        /// <summary>
        /// The BrowseName for the ReadTag component.
        /// </summary>
        public const string ReadTag = "ReadTag";
        /// <summary>
        /// The BrowseName for the RfidLockOperationEnumeration component.
        /// </summary>
        public const string RfidLockOperationEnumeration = "RfidLockOperationEnumeration";
        /// <summary>
        /// The BrowseName for the RfidLockRegionEnumeration component.
        /// </summary>
        public const string RfidLockRegionEnumeration = "RfidLockRegionEnumeration";
        /// <summary>
        /// The BrowseName for the RfidPasswordTypeEnumeration component.
        /// </summary>
        public const string RfidPasswordTypeEnumeration = "RfidPasswordTypeEnumeration";
        /// <summary>
        /// The BrowseName for the RfidReaderDeviceType component.
        /// </summary>
        public const string RfidReaderDeviceType = "RfidReaderDeviceType";
        /// <summary>
        /// The BrowseName for the RfidScanEventType component.
        /// </summary>
        public const string RfidScanEventType = "RfidScanEventType";
        /// <summary>
        /// The BrowseName for the RfidScanResult component.
        /// </summary>
        public const string RfidScanResult = "RfidScanResult";
        /// <summary>
        /// The BrowseName for the RfidSighting component.
        /// </summary>
        public const string RfidSighting = "RfidSighting";
        /// <summary>
        /// The BrowseName for the Rotation component.
        /// </summary>
        public const string Rotation = "Rotation";
        /// <summary>
        /// The BrowseName for the RotationalUnit component.
        /// </summary>
        public const string RotationalUnit = "RotationalUnit";
        /// <summary>
        /// The BrowseName for the RtlsDeviceType component.
        /// </summary>
        public const string RtlsDeviceType = "RtlsDeviceType";
        /// <summary>
        /// The BrowseName for the RtlsLocationEventType component.
        /// </summary>
        public const string RtlsLocationEventType = "RtlsLocationEventType";
        /// <summary>
        /// The BrowseName for the RtlsLocationResult component.
        /// </summary>
        public const string RtlsLocationResult = "RtlsLocationResult";
        /// <summary>
        /// The BrowseName for the RuntimeParameters component.
        /// </summary>
        public const string RuntimeParameters = "RuntimeParameters";
        /// <summary>
        /// The BrowseName for the Scan component.
        /// </summary>
        public const string Scan = "Scan";
        /// <summary>
        /// The BrowseName for the ScanData component.
        /// </summary>
        public const string ScanData = "ScanData";
        /// <summary>
        /// The BrowseName for the ScanDataEpc component.
        /// </summary>
        public const string ScanDataEpc = "ScanDataEpc";
        /// <summary>
        /// The BrowseName for the ScanResult component.
        /// </summary>
        public const string ScanResult = "ScanResult";
        /// <summary>
        /// The BrowseName for the ScanSettings component.
        /// </summary>
        public const string ScanSettings = "ScanSettings";
        /// <summary>
        /// The BrowseName for the ScanStart component.
        /// </summary>
        public const string ScanStart = "ScanStart";
        /// <summary>
        /// The BrowseName for the ScanStop component.
        /// </summary>
        public const string ScanStop = "ScanStop";
        /// <summary>
        /// The BrowseName for the SetTagPassword component.
        /// </summary>
        public const string SetTagPassword = "SetTagPassword";
        /// <summary>
        /// The BrowseName for the SpeedUnit component.
        /// </summary>
        public const string SpeedUnit = "SpeedUnit";
        /// <summary>
        /// The BrowseName for the UtmCoordinate component.
        /// </summary>
        public const string UtmCoordinate = "UtmCoordinate";
        /// <summary>
        /// The BrowseName for the WGS84Coordinate component.
        /// </summary>
        public const string WGS84Coordinate = "WGS84Coordinate";
        /// <summary>
        /// The BrowseName for the WriteTag component.
        /// </summary>
        public const string WriteTag = "WriteTag";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the Model.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the AutoId namespace.
        /// </summary>
        public const string AutoId = "http://opcfoundation.org/UA/AutoID/";

        /// <summary>
        /// The URI for the AutoIdXsd namespace.
        /// </summary>
        public const string AutoIdXsd = "http://opcfoundation.org/UA/AutoID/Types.xsd";
    }
    #endregion
}