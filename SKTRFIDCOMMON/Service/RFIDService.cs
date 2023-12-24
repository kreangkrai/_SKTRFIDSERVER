﻿using SKTDATABASE;
using SKTRFIDCOMMON.Interface;
using SKTRFIDCOMMON.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SKTRFIDCOMMON.Service
{
    public class RFIDService : IRFID
    {
        public string InsertRFIDLog(DataModel data)
        {
            try
            {
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand cmd = new SqlCommand($@"INSERT INTO tb_rfid_log VALUES('{data.dump_id}','{data.area_id}',
                                                                                      '{data.crop_year}','{data.rfid}','{data.barcode}',
                                                                                      '{data.cane_type}','{data.allergen}','{data.truck_number}',
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
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_rfid SET rfid=N'{data.rfid}',
                                                                          barcode=N'{data.barcode}',
                                                                          cane_type='{data.cane_type}',
                                                                          allergen='{data.allergen}',
                                                                          truck_number=N'{data.truck_number}', 
                                                                          rfid_lastdate='{data.rfid_lastdate}',
                                                                          truck_type='{data.truck_type}',
                                                                          weight_type='{data.weight_type}',
                                                                          queue_status='{data.queue_status}'
                                                                          WHERE dump_id='{data.dump_id}' ", cn);
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
