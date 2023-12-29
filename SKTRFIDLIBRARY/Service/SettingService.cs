using SKTDATABASE;
using SKTRFIDLIBRARY.Interface;
using SKTRFIDLIBRARY.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDLIBRARY.Service
{
    public class SettingService : ISetting
    {
        string connectionString = "";
        public SettingService(int phase)
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
        public SettingModel GetSetting()
        {
            SettingModel setting = new SettingModel();
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT no,area_id,crop_year,ip1,ip2,ip_plc,ip_plc_common FROM tb_setting", cn);
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
                            setting.ip_plc_common = dr["ip_plc_common"].ToString();
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
