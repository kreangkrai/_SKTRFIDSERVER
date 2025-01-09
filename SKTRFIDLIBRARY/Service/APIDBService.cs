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
    public class APIDBService : IAPIDB
    {
        string connectionString = "";
        public APIDBService(int phase)
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
        public DataAPIModel GetAPIByDump(string dump)
        {
            DataAPIModel data = new DataAPIModel();
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT dump_id,barcode,date FROM tb_api where dump_id='{dump}'", cn);
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            data.dump_id = dr["dump_id"].ToString();
                            data.barcode = dr["barcode"].ToString();
                            data.date = Convert.ToDateTime(dr["date"].ToString());
                        }
                    }
                    dr.Close();
                }
                return data;
            }
            catch
            {
                return data;
            }
        }

        public string UpdateAPI(DataAPIModel data)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlCommand cmd = new SqlCommand($@"UPDATE tb_api SET barcode=N'{data.barcode}',
                                                                          date='{data.date}'       
                                                                          WHERE dump_id='{data.dump_id}'", cn);
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
