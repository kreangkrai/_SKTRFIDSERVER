using SKTDATABASE;
using SKTRFIDTAG.Interface;
using SKTRFIDTAG.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKTRFIDTAG.Service
{
    class TagLogService : ITagLog
    {
        public List<TagLogModel> GetTagLogByRFID(string rfid)
        {
            List<TagLogModel> tags = new List<TagLogModel>();
            if (rfid.Trim() == "")
            {
                return tags;
            }
            try
            {
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT tag,rfid,tag_date FROM tb_tag WHERE rfid LIKE '%{rfid}%' ORDER BY tag_date DESC ", cn);
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            TagLogModel tag = new TagLogModel()
                            {
                                tag = dr["tag"].ToString(),
                                rfid = dr["rfid"].ToString(),
                                tag_date = Convert.ToDateTime(dr["tag_date"].ToString())
                            };
                            tags.Add(tag);
                        }
                    }
                    dr.Close();
                }
                return tags;
            }
            catch
            {
                return tags;
            }
        }
    }
}
