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
    public class TagLogService : ITagLog
    {
        string connectionString = "";
        public TagLogService(int phase)
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
        public List<TagLogModel> GetTagByRfid(string rfid)
        {
            List<TagLogModel> tags = new List<TagLogModel>();
            try
            {
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
        public List<TagLogModel> GetTagLogByRFID(string rfid)
        {
            List<TagLogModel> tags = new List<TagLogModel>();
            if (rfid.Trim() == "")
            {
                return tags;
            }
            try
            {
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
