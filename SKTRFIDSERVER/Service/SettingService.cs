﻿using SKTDATABASE;
using SKTRFIDSERVER.Interface;
using SKTRFIDSERVER.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDSERVER.Service
{
    class SettingService : ISetting
    {
        public SettingModel GetSetting()
        {
            SettingModel setting = new SettingModel();
            try
            {
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT no,area_id,crop_year,ip1,ip2,ip_plc FROM tb_setting", cn);
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            setting.no = Convert.ToInt32(dr["no"].ToString());
                            setting.area_id = Convert.ToInt32(dr["area_id"].ToString());
                            setting.crop_year = dr["crop_year"].ToString();
                            setting.ip1 = dr["ip1"].ToString();
                            setting.ip2 = dr["ip2"].ToString();
                            setting.ip_plc = dr["ip_plc"].ToString();
                        }
                    }
                    dr.Close();
                }
                return setting;
            }
            catch
            {
                return setting;
            }
        }

        public string UpdateSetting(SettingModel setting)
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

                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_setting SET area_id=N'{setting.area_id}',
                                                                          crop_year=N'{setting.crop_year}'
                                                                          WHERE no='{setting.no}' ", cn);
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
