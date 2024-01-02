using SKTRFIDLIBRARY.Interface;
using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Service
{
    public class AccessoryService : IAccessory
    {
        public string decodeLicensePlate(string code)
        {
            int ascii_char_license1 = Int32.Parse(code.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int ascii_char_license2 = Int32.Parse(code.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte[] charLicense = new byte[2];
            charLicense[0] = (byte)ascii_char_license1;
            charLicense[1] = (byte)ascii_char_license2;

            string ch = Encoding.ASCII.GetString(charLicense);
            string license1 = LicensePlateEngToTh(ch);

            string license2 = code.Substring(4, 2).Replace("F", "");
            string license3 = code.Substring(6, 4).Replace("F", "");

            string license = "";
            if (license2 == "")
            {
                license = license1 + license3;
            }
            else
            {
                license = license1 + license2 + "-" + license3;
            }
            return license;
        }
        public string LicensePlateEngToTh(string code)
        {
            try
            {
                Dictionary<string, string> license = new Dictionary<string, string>();
                license.Add("BK", "กท");
                license.Add("KP", "กพ");
                license.Add("CP", "ชย");
                license.Add("NT", "นฐ");
                license.Add("NS", "นว");
                license.Add("PR", "พร");
                license.Add("PL", "พล");
                license.Add("RM", "รม");
                license.Add("LP", "ลป");
                license.Add("LN", "ลพ");
                license.Add("SK", "สท");
                license.Add("SR", "สบ");
                license.Add("SP", "สพ");
                license.Add("SB", "สห");
                license.Add("UT", "อต");
                license.Add("AY", "อย");

                return license[code];
            }
            catch
            {
                return "";
            }
        }

        public DataModel ReadDataRFIDCard(string tag)
        {           
            string rfid_code = string.Empty;
            string license_plate = string.Empty;
            string truck_type = string.Empty;
            string weight_code = string.Empty;
            string cane_type = string.Empty;
            string weight_type = string.Empty;
            string queue_status = string.Empty;
            string dump_no = string.Empty;

            rfid_code = int.Parse(tag.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');
            license_plate = decodeLicensePlate(tag.Substring(4, 10));
            truck_type = tag.Substring(14, 1);
            weight_code = tag.Substring(15, 5);
            cane_type = tag.Substring(20, 1);
            weight_type = tag.Substring(21, 1);
            queue_status = tag.Substring(22, 1);
            dump_no = tag.Substring(23, 1);

            DataModel data = new DataModel()
            {
                rfid = rfid_code,
                truck_number = license_plate,
                truck_type = Int32.Parse(truck_type),
                weight_type = Int32.Parse(weight_type),
                cane_type = Int32.Parse(cane_type),
                barcode = int.Parse(weight_code, System.Globalization.NumberStyles.HexNumber).ToString(),
                queue_status = Int32.Parse(queue_status),
                dump_id = Int32.Parse(dump_no)
            };
            return data;
        }

        public RFIDModel ReadRFIDCard(string tag)
        {
            RFIDModel rfid = new RFIDModel();
            rfid.Data = new List<Data>();
            string rfid_code = string.Empty;
            string license_plate = string.Empty;
            string truck_type = string.Empty;
            string weight_code = string.Empty;
            string cane_type = string.Empty;
            string weight_type = string.Empty;
            string queue_status = string.Empty;
            string dump_no = string.Empty;

            rfid_code = int.Parse(tag.Substring(0, 4), System.Globalization.NumberStyles.HexNumber).ToString().PadLeft(6, '0');
            license_plate = decodeLicensePlate(tag.Substring(4, 10));
            truck_type = tag.Substring(14, 1);
            weight_code = tag.Substring(15, 5);
            cane_type = tag.Substring(20, 1);
            weight_type = tag.Substring(21, 1);
            queue_status = tag.Substring(22, 1);
            dump_no = tag.Substring(23, 1);

            Data data = new Data()
            {
                Barcode = int.Parse(weight_code, System.Globalization.NumberStyles.HexNumber).ToString(),
                FarmerName = "",
                Allergen = "No",
                CaneType = cane_type,
                TruckNumber = license_plate,
                
            };
            rfid.Data.Add(data);
            return rfid;
        }
    }
}
