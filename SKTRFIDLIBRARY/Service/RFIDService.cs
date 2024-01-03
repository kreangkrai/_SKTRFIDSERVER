using SKTDATABASE;
using SKTRFIDLIBRARY.Interface;
using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SKTRFIDLIBRARY.Service
{
    public class RFIDService : IRFID
    {
        string connectionString = "";
        public RFIDService(int phase)
        {
            if (phase == 1)
            {
                connectionString = DBPHASE1ConnectService.data_source();
            }
            if (phase == 2)
            {
                connectionString = DBPHASE2ConnectService.data_source();
            }
        }
        public string InsertRFIDLog(DataModel data)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand cmd = new SqlCommand($@"INSERT INTO tb_rfid_log VALUES('{data.queue1}','{data.dump_id}','{data.area_id}',
                                                                                      '{data.crop_year}','{data.rfid}','{data.barcode}',N'{data.farmer_name}',
                                                                                      '{data.cane_type}','{data.allergen}',N'{data.truck_number}',
                                                                                      '{data.truck_type}','{data.weight_type}','{data.queue_status}','{data.rfid_lastdate}')", cn);
                    cmd.ExecuteNonQuery();
                }
                return "Success";
            }
            catch
            {
                return "Fail";
            }
        }

        public string UpdateRFID(DataModel data)
        {
                     
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_rfid SET rfid=N'{data.rfid}',
                                                                          barcode=N'{data.barcode}',
                                                                          farmer_name=N'{data.farmer_name}',
                                                                          cane_type='{data.cane_type}',
                                                                          allergen='{data.allergen}',
                                                                          truck_number=N'{data.truck_number}', 
                                                                          rfid_lastdate='{data.rfid_lastdate}',
                                                                          truck_type='{data.truck_type}',
                                                                          weight_type='{data.weight_type}',
                                                                          queue_status='{data.queue_status}'
                                                                          WHERE dump_id='{data.dump_id}' AND area_id='{data.area_id}' AND crop_year='{data.crop_year}' ", cn);
                    cmd.ExecuteNonQuery();
                }
                return "Success";
            }
            catch
            {
                return "Fail";
            }
        }

        public string UpdateRFIDAllergen(DataModel data)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_rfid SET allergen='{data.allergen}'
                                                                          WHERE dump_id='{data.dump_id}', barcode=N'{data.barcode}' AND area_id='{data.area_id}' AND crop_year='{data.crop_year}' ", cn);
                    cmd.ExecuteNonQuery();
                }
                return "Success";
            }
            catch
            {
                return "Fail";
            }
        }

        public string UpdateRFIDAllergenLog(DataModel data)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_rfid_log SET allergen='{data.allergen}'
                                                                          WHERE dump_id='{data.dump_id}', barcode=N'{data.barcode}' AND area_id='{data.area_id}' AND crop_year='{data.crop_year}' ", cn);
                    cmd.ExecuteNonQuery();
                }
                return "Success";
            }
            catch
            {
                return "Fail";
            }
        }
    }
}
