using SKTRFIDLIBRARY.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Service
{
    public class CodeTypeService : ICodeType
    {
        public string CaneType(int n)
        {
            if (n < 0)
            {
                return "";
            }
            List<string> canes_type = new List<string>();
            canes_type.Add("สดลำ");
            canes_type.Add("ไฟไหม้ลำ");
            canes_type.Add("สดท่อน");
            canes_type.Add("ไฟไหม้ท่อน");

            return canes_type[n];
        }
        public string truckType(int n)
        {
            if (n < 0)
            {
                return "";
            }
            List<string> trucks_type = new List<string>();
            trucks_type.Add("");
            trucks_type.Add("รถเดี่ยว");
            trucks_type.Add("พ่วงแม่");
            trucks_type.Add("พ่วงลูก");
            return trucks_type[n];
        }

        public string weightType(int n)
        {
            if (n < 0)
            {
                return "";
            }
            List<string> weights_type = new List<string>();
            weights_type.Add("");
            weights_type.Add("ชั่งรวม");
            weights_type.Add("ชั่งแยก");
            return weights_type[n];
        }
        public string queueStatus(int n)
        {
            if (n < 0)
            {
                return "";
            }
            List<string> queues_status = new List<string>();
            queues_status.Add("");
            queues_status.Add("แจ้งคิวแล้ว");
            queues_status.Add("ชั่งเข้าแล้ว");
            queues_status.Add("ดัมพ์แล้ว");
            return queues_status[n];
        }

        public string allergenType(string n)
        {
            if (n == "No" || n.Trim() == "")
            {
                return "ไม่มี";
            }
            else
            {
                return "มี";
            }
        }
    }
}

