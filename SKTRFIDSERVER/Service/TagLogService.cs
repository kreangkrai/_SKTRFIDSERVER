using SKTDATABASE;
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
    class TagLogService : ITagLog
    {
        public List<TagLogModel> GetTagByRfid(string rfid)
        {
            List<TagLogModel> tags = new List<TagLogModel>();
            try
            {
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT tag,rfid,tag_date FROM tb_tag WHERE rfid LIKE '%{rfid}%'", cn);
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

        public List<TagLogModel> GetTags()
        {
            List<TagLogModel> tags = new List<TagLogModel>();
            try
            {
                string connectionString = DBConnectService.data_source();
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand($@"SELECT tag,rfid,tag_date FROM tb_tag", cn);
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

        public string InsertTag(TagLogModel tag)
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

                    SqlCommand cmd = new SqlCommand($@"INSERT INTO tb_tag VALUES('{tag.tag}','{tag.rfid}','{tag.tag_date}')", cn);
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
