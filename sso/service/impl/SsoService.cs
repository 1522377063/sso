using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using sso.utils;
using sso.enums;
using sso.model;
using System.Text;
using Newtonsoft.Json;

namespace sso.service.impl
{
    public class SsoService : ISsoService
    {
        private string strSql;
        private MySqlParameter[] mySqlParameters;
        public string CreateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled)
        {
            try
            {
                strSql = "SELECT * from dept WHERE hy_deptid=@hy_deptid";
                mySqlParameters=new MySqlParameter[]
                {
                    new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                };
                List<Dept> listDept=ResultUtil.getResultList<Dept>(strSql, mySqlParameters);
                if (listDept==null)
                {
                    strSql = "INSERT INTO dept VALUES(@hy_deptid,@hy_deptname,@hy_deptsort,@hy_isenabled)";
                    mySqlParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                        new MySqlParameter("@hy_deptname",MySqlDbType.VarChar,50) {Value = hy_deptname},
                        new MySqlParameter("@hy_deptsort",MySqlDbType.VarChar,50) {Value = hy_deptsort},
                        new MySqlParameter("@hy_isenabled",MySqlDbType.VarChar,10) {Value = hy_isenabled},
                    };
                    ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                    return "[{\"status\": \"1\"}]";
                }
                else
                {
                    return "[{\"status\":\" 1\"}]";
                }                           
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
            }
            
        }

        public string CreateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post, string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber, string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex, string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime, string hy_address, string hy_identitycardnumber)
        {
            try
            {
                strSql = "SELECT * from `user` WHERE hy_userid=@hy_userid";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@hy_userid",MySqlDbType.VarChar,50) {Value = hy_userid},
                };
                List<User> listUsers = ResultUtil.getResultList<User>(strSql, mySqlParameters);
                if (listUsers==null)
                {
                    strSql = "INSERT INTO `user` VALUES(@hy_userid, @hy_deptid, @hy_username, @hy_post,@hy_ifleader, @hy_officetel, @hy_hometel, @hy_mobile, @hy_virtualnumber,@hy_sort, @hy_isenabled, @hy_birthday, @hy_officenumber, @hy_sex,@hy_politicallandscape, @hy_education, @hy_university, @hy_jointime,@hy_address, @hy_identitycardnumber)";
                    mySqlParameters = new MySqlParameter[]
                    {
                    new MySqlParameter("@hy_userid",MySqlDbType.VarChar,50) {Value = hy_userid},
                    new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                    new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value = hy_username},
                    new MySqlParameter("@hy_post",MySqlDbType.VarChar,20) {Value = hy_post},
                    new MySqlParameter("@hy_ifleader",MySqlDbType.VarChar,10) {Value = hy_ifleader},
                    new MySqlParameter("@hy_officetel",MySqlDbType.VarChar,20) {Value = hy_officetel},
                    new MySqlParameter("@hy_hometel",MySqlDbType.VarChar,20) {Value = hy_hometel},

                    new MySqlParameter("@hy_mobile",MySqlDbType.VarChar,50) {Value = hy_mobile},
                    new MySqlParameter("@hy_virtualnumber",MySqlDbType.VarChar,20) {Value = hy_virtualnumber},
                    new MySqlParameter("@hy_sort",MySqlDbType.VarChar,20) {Value = hy_sort},
                    new MySqlParameter("@hy_isenabled",MySqlDbType.VarChar,10) {Value = hy_isenabled},
                    new MySqlParameter("@hy_birthday",MySqlDbType.VarChar,20) {Value = hy_birthday},
                    new MySqlParameter("@hy_officenumber",MySqlDbType.VarChar,20) {Value = hy_officenumber},
                    new MySqlParameter("@hy_sex",MySqlDbType.VarChar,10) {Value = hy_sex},
                    new MySqlParameter("@hy_politicallandscape",MySqlDbType.VarChar,20) {Value = hy_politicallandscape},

                    new MySqlParameter("@hy_education",MySqlDbType.VarChar,20) {Value = hy_education},
                    new MySqlParameter("@hy_university",MySqlDbType.VarChar,50) {Value = hy_university},
                    new MySqlParameter("@hy_jointime",MySqlDbType.VarChar,50) {Value = hy_jointime},
                    new MySqlParameter("@hy_address",MySqlDbType.VarChar,50) {Value = hy_address},
                    new MySqlParameter("@hy_identitycardnumber",MySqlDbType.VarChar,20) {Value = hy_identitycardnumber},
                    };
                    ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                    return "[{\"status\":\" 1\"}]";
                }
                else
                {
                    return "[{\"status\":\" 1\"}]";
                }   
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
            }
        }

        public string DeleteDept(string hy_deptid)
        {
            try
            {
                strSql = "DELETE FROM dept WHERE dept.hy_deptid=@hy_deptid";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                };
                int result = ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                if (result > 0)
                {
                    return "[{\"status\":\" 1\"}]";
                }
                return "[{\"status\":\" 0\"}]";
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
                throw;
            }
        }

        public string DeleteUser(string hy_userid)
        {
            try
            {
                strSql = "DELETE FROM `user` WHERE `user`.hy_userid=@hy_userid";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@hy_userid",MySqlDbType.VarChar,50) {Value = hy_userid},
                };
                int result = ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                if (result > 0)
                {
                    return "[{\"status\":\" 1\"}]";
                }
                return "[{\"status\":\" 0\"}]";
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
                throw;
            }
        }

        public string UpdateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled)
        {
            try
            {
                strSql = "UPDATE dept SET dept.hy_deptid=@hy_deptid,dept.hy_deptname=@hy_deptname,dept.hy_deptsort=@hy_deptsort,dept.hy_isenabled=@hy_isenabled WHERE dept.hy_deptid=@hy_deptid";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                    new MySqlParameter("@hy_deptname",MySqlDbType.VarChar,50) {Value = hy_deptname},
                    new MySqlParameter("@hy_deptsort",MySqlDbType.VarChar,50) {Value = hy_deptsort},
                    new MySqlParameter("@hy_isenabled",MySqlDbType.VarChar,10) {Value = hy_isenabled},
                };
                int result = ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                if (result > 0)
                {
                    return "[{\"status\":\" 1\"}]";
                }
                return "[{\"status\":\" 0\"}]";
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
                throw;
            }
        }

        public string UpdateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post, string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber, string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex, string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime, string hy_address, string hy_identitycardnumber)
        {
            try
            {
                strSql = "UPDATE `user` SET hy_userid=@hy_userid, hy_deptid=@hy_deptid, hy_username=@hy_username, hy_post=@hy_post,hy_ifleader=@hy_ifleader, hy_officetel=@hy_officetel, hy_hometel=@hy_hometel, hy_mobile=@hy_mobile, hy_virtualnumber=@hy_virtualnumber,hy_sort=@hy_sort, hy_isenabled=@hy_isenabled, hy_birthday=@hy_birthday, hy_officenumber=@hy_officenumber, hy_sex=@hy_sex,hy_politicallandscape=@hy_politicallandscape, hy_education=@hy_education, hy_university=@hy_university, hy_jointime=@hy_jointime,hy_address=@hy_address, hy_identitycardnumber=@hy_identitycardnumber";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@hy_userid",MySqlDbType.VarChar,50) {Value = hy_userid},
                    new MySqlParameter("@hy_deptid",MySqlDbType.VarChar,50) {Value = hy_deptid},
                    new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value = hy_username},
                    new MySqlParameter("@hy_post",MySqlDbType.VarChar,20) {Value = hy_post},
                    new MySqlParameter("@hy_ifleader",MySqlDbType.VarChar,10) {Value = hy_ifleader},
                    new MySqlParameter("@hy_officetel",MySqlDbType.VarChar,20) {Value = hy_officetel},
                    new MySqlParameter("@hy_hometel",MySqlDbType.VarChar,20) {Value = hy_hometel},

                    new MySqlParameter("@hy_mobile",MySqlDbType.VarChar,50) {Value = hy_mobile},
                    new MySqlParameter("@hy_virtualnumber",MySqlDbType.VarChar,20) {Value = hy_virtualnumber},
                    new MySqlParameter("@hy_sort",MySqlDbType.VarChar,20) {Value = hy_sort},
                    new MySqlParameter("@hy_isenabled",MySqlDbType.VarChar,10) {Value = hy_isenabled},
                    new MySqlParameter("@hy_birthday",MySqlDbType.VarChar,20) {Value = hy_birthday},
                    new MySqlParameter("@hy_officenumber",MySqlDbType.VarChar,20) {Value = hy_officenumber},
                    new MySqlParameter("@hy_sex",MySqlDbType.VarChar,10) {Value = hy_sex},
                    new MySqlParameter("@hy_politicallandscape",MySqlDbType.VarChar,20) {Value = hy_politicallandscape},

                    new MySqlParameter("@hy_education",MySqlDbType.VarChar,20) {Value = hy_education},
                    new MySqlParameter("@hy_university",MySqlDbType.VarChar,50) {Value = hy_university},
                    new MySqlParameter("@hy_jointime",MySqlDbType.VarChar,50) {Value = hy_jointime},
                    new MySqlParameter("@hy_address",MySqlDbType.VarChar,50) {Value = hy_address},
                    new MySqlParameter("@hy_identitycardnumber",MySqlDbType.VarChar,20) {Value = hy_identitycardnumber},
                };
                int result = ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                if (result > 0)
                {
                    return "[{\"status\":\" 1\"}]";
                }
                return "[{\"status\":\" 0\"}]";
            }
            catch (Exception e)
            {
                return "[{\"status\":\" 0\"}]";
                throw;
            }
        }

        public string getReportList()
        {
            strSql =
                "SELECT * FROM report";
            JObject jo2=new JObject();
            jo2.Add("status",(int)Status.Normal);
            jo2.Add("message","获取列表成功");
            List< Report> listReport=ResultUtil.getResultList<Report>(strSql);
            JArray ja1 = new JArray();
            if (listReport != null && listReport.Count != 0)
            {                
                foreach (Report report in listReport)
                {
                    JObject jo1 = new JObject();
                    strSql = "SELECT * FROM t_file WHERE rid=@rid";
                    mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@rid",MySqlDbType.Int32) {Value = report.id}, 
                };
                    List<TFile> listFiles = ResultUtil.getResultList<TFile>(strSql, mySqlParameters);
                    jo1.Add("id", report.id);
                    jo1.Add("report_person", report.report_person);
                    jo1.Add("reportdate", report.reportdate);
                    jo1.Add("phone", report.phone);
                    jo1.Add("content", report.content);
                    jo1.Add("type", report.type);
                    jo1.Add("pid", report.pid);
                    JArray ja = new JArray();
                    if (listFiles != null && listFiles.Count != 0)
                    {
                        foreach (TFile file in listFiles)
                        {
                            JObject jo = new JObject();
                            jo.Add("id", file.id);
                            jo.Add("pid", file.pid);
                            jo.Add("typeid", file.typeid);
                            jo.Add("filetype", file.filetype);
                            jo.Add("filename", file.filename);
                            jo.Add("filepath", file.filepath);
                            jo.Add("totalbytes", file.totalbytes);
                            jo.Add("ext", file.ext);
                            jo.Add("note", file.note);
                            jo.Add("createtime", file.createtime);
                            jo.Add("creatorid", file.creatorid);
                            jo.Add("creator", file.creator);
                            jo.Add("delflag", file.delflag);
                            jo.Add("fileblob", file.fileblob);
                            jo.Add("rid", file.rid);
                            ja.Add(jo);
                        }
                    }

                    jo1.Add("pic", ja);
                    ja1.Add(jo1);
                }
            }
            
            jo2.Add("result",ja1);
            //string result = ResultUtil.getStandardResult((int) Status.Normal, "获取数据成功", list);
            return jo2.ToString();
        }

        public string getReportListById(int id)
        {
            strSql =
                "SELECT * FROM report WHERE id=@id";
            mySqlParameters = new MySqlParameter[]
            {
                new MySqlParameter("@id",MySqlDbType.Int32) {Value = id}, 
            };
            JObject jo2 = new JObject();
            jo2.Add("status", (int)Status.Normal);
            jo2.Add("message", "获取列表成功");
            List<Report> listReport = ResultUtil.getResultList<Report>(strSql,mySqlParameters);          
            JArray ja1 = new JArray();
            if (listReport != null && listReport.Count != 0)
            {
                Report report = listReport[0];
                JObject jo1 = new JObject();
                strSql = "SELECT * FROM t_file WHERE rid=@rid";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@rid",MySqlDbType.Int32) {Value = report.id}, 
                };
                List<TFile> listFiles = ResultUtil.getResultList<TFile>(strSql, mySqlParameters);
                jo1.Add("id", report.id);
                jo1.Add("report_person", report.report_person);
                jo1.Add("reportdate", report.reportdate);
                jo1.Add("phone", report.phone);
                jo1.Add("content", report.content);
                jo1.Add("type", report.type);
                jo1.Add("pid", report.pid);
                JArray ja = new JArray();
                if (listFiles != null && listFiles.Count != 0)
                {
                    foreach (TFile file in listFiles)
                    {
                        JObject jo = new JObject();
                        jo.Add("id", file.id);
                        jo.Add("pid", file.pid);
                        jo.Add("typeid", file.typeid);
                        jo.Add("filetype", file.filetype);
                        jo.Add("filename", file.filename);
                        jo.Add("filepath", file.filepath);
                        jo.Add("totalbytes", file.totalbytes);
                        jo.Add("ext", file.ext);
                        jo.Add("note", file.note);
                        jo.Add("createtime", file.createtime);
                        jo.Add("creatorid", file.creatorid);
                        jo.Add("creator", file.creator);
                        jo.Add("delflag", file.delflag);
                        jo.Add("fileblob", file.fileblob);
                        jo.Add("rid", file.rid);
                        ja.Add(jo);
                    }
                }
                
                jo1.Add("pic", ja);
                ja1.Add(jo1);
            }
            
            jo2.Add("result", ja1);
            //string result = ResultUtil.getStandardResult((int) Status.Normal, "获取数据成功", list);
            return jo2.ToString();
        }

        public string AddReport(int id, string report_person, string reportdate, string phone, string content, string type, int pid)
        {
            try
            {
                strSql = "INSERT INTO report VALUES(@id,@report_person,@reportdate,@phone,@content,@type,@pid)";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id",MySqlDbType.Int32){Value=id},
                    new MySqlParameter("@report_person",MySqlDbType.VarChar,20){Value=report_person},
                    new MySqlParameter("@reportdate",MySqlDbType.VarChar,20){Value=reportdate},
                    new MySqlParameter("@phone",MySqlDbType.VarChar,20){Value=phone},
                    new MySqlParameter("@content",MySqlDbType.VarChar,255){Value=content},
                    new MySqlParameter("@type",MySqlDbType.VarChar,10){Value=type},
                    new MySqlParameter("@pid",MySqlDbType.Int32){Value=pid},
                };
                ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                return ResultUtil.getStandardResult((int)Status.Normal, "添加成功", null);
            }
            catch (Exception ex)
            {
                return ResultUtil.getStandardResult((int)Status.Error, "添加失败", null);
            }
        }
        public string UpdateReport(int id, string report_person, string reportdate, string phone, string content, string type, int pid)
        {
            try
            {
                strSql = "UPDATE report SET id=@id ,report_person=@report_person,reportdate=@reportdate,phone=@phone,content=@content,type=@type,pid=@pid WHERE id=@id";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id",MySqlDbType.Int32){Value=id},
                    new MySqlParameter("@report_person",MySqlDbType.VarChar,20){Value=report_person},
                    new MySqlParameter("@reportdate",MySqlDbType.VarChar,20){Value=reportdate},
                    new MySqlParameter("@phone",MySqlDbType.VarChar,20){Value=phone},
                    new MySqlParameter("@content",MySqlDbType.VarChar,255){Value=content},
                    new MySqlParameter("@type",MySqlDbType.VarChar,10){Value=type},
                    new MySqlParameter("@pid",MySqlDbType.Int32){Value=pid},
                };
                ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                return ResultUtil.getStandardResult((int)Status.Normal, "更新成功", null);
            }
            catch (Exception ex)
            {
                return ResultUtil.getStandardResult((int)Status.Error, "更新失败", null);
            }
        }

        public string GetUserPermissionList(int page, int rows)
        {
            int total = int.Parse(ResultUtil.getResultString("SELECT count(1) FROM `user`"));
            //获取每一个用户
            strSql = "SELECT * FROM `user` LIMIT @begin,@rows";
            mySqlParameters = new MySqlParameter[]
            {
                new MySqlParameter("@begin",MySqlDbType.Int32) {Value=((page-1)*Convert.ToInt32(rows)) },
                new MySqlParameter("@rows",MySqlDbType.Int32) {Value=Convert.ToInt32(rows) }
            };
            List<User> userList = ResultUtil.getResultList<User>(strSql,mySqlParameters);
            JObject jo1=new JObject();
            jo1.Add("total", total);
            if (userList!=null)
            {
                JArray ja = new JArray();
                
                foreach (User user in userList)
                {

                    strSql =@"SELECT u.hy_username as username,p.p_name as pname,up.p_value as pvalue FROM user_permission up RIGHT JOIN (SELECT * FROM `user` WHERE `user`.hy_userid=@hy_userid) u ON up.uid=u.hy_userid RIGHT JOIN permission p ON up.pid=p.p_id";
                    mySqlParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@hy_userid",MySqlDbType.Int32) {Value = user.hy_userid},
                    };
                    //获取每一个用户对应的权限
                    List<PartPermission> partPermissionList = ResultUtil.getResultList<PartPermission>(strSql, mySqlParameters);
                    if (partPermissionList != null)
                    {
                        JObject jo = new JObject();
                        jo.Add("username", user.hy_username);
                        foreach (PartPermission partPermission in partPermissionList)
                        {
                            jo.Add(partPermission.pname,partPermission.pvalue);
                        }
                        ja.Add(jo);
                    }

                }

                jo1.Add("rows",ja);

            }

            return jo1.ToString();
        }

        public string EditUserPermission(string json)
        {
            JObject jo = JsonConvert.DeserializeObject(json) as JObject;
            string username = jo["username"].ToString();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("cunzhuang", (int)jo["cunzhuang"]);
            dic.Add("cesuo", (int)jo["cesuo"]);
            dic.Add("minsu", (int)jo["minsu"]);
            dic.Add("jingqu", (int)jo["jingqu"]);
            dic.Add("addtuceng", (int)jo["addtuceng"]);
            dic.Add("shouhuiditu", (int)jo["shouhuiditu"]);
            dic.Add("addimage", (int)jo["addimage"]);
            dic.Add("ninghaimaoyucun", (int)jo["ninghaimaoyucun"]);
            dic.Add("ninghai", (int)jo["ninghai"]);
            dic.Add("addmodel", (int)jo["addmodel"]);
            dic.Add("addpanorama", (int)jo["addpanorama"]);
            strSql = @"SELECT u.hy_username as username,p.p_name as pname,up.p_value as pvalue FROM user_permission up RIGHT JOIN (SELECT * FROM `user` WHERE `user`.hy_username=@hy_username) u ON up.uid=u.hy_userid RIGHT JOIN permission p ON up.pid=p.p_id";
            mySqlParameters = new MySqlParameter[]
            {
                new MySqlParameter("@hy_userid",MySqlDbType.Int32) {Value = username},
            };
            //获取每一个用户对应的权限
            List<PartPermission> partPermissionList = ResultUtil.getResultList<PartPermission>(strSql, mySqlParameters);
            foreach (PartPermission pp in partPermissionList)
            {
                if (pp.pvalue == null && pp.username==null)
                {
                    strSql =
                        @"SELECT COUNT(1) FROM user_permission up WHERE up.uid=(SELECT u.hy_userid FROM `user` u WHERE u.hy_username=@hy_username) AND up.pid=(SELECT p.p_id FROM permission p WHERE p.p_name=@p_name)";
                    mySqlParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value=username },
                        new MySqlParameter("@p_name",MySqlDbType.VarChar,50) {Value=pp.pname }
                    };
                    int num = int.Parse(ResultUtil.getResultString(strSql, mySqlParameters));
                    if (num > 0)
                    {
                        continue;
                    }
                    strSql =
                        @"INSERT INTO user_permission (uid,pid,p_value) VALUES((SELECT u.hy_userid FROM `user` u WHERE u.hy_username=@hy_username),(SELECT p.p_id FROM permission p WHERE p.p_name=@p_name),@p_value)";
                    mySqlParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value=username },
                        new MySqlParameter("@p_name",MySqlDbType.VarChar,50) {Value=pp.pname },
                        new MySqlParameter("@p_value",MySqlDbType.Int32) {Value=pp.pvalue }
                    };
                    ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
                }
            }
            foreach (KeyValuePair<string,int> kv in dic)
            {
                strSql = "UPDATE user_permission up SET up.p_value=@p_value WHERE up.uid=(SELECT `user`.hy_userid FROM `user` WHERE `user`.hy_username=@hy_username) AND up.pid=(SELECT permission.p_id FROM permission WHERE permission.p_name=@p_name)";
                mySqlParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@p_value",MySqlDbType.Int32) {Value=kv.Value },
                    new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value=username },
                    new MySqlParameter("@p_name",MySqlDbType.VarChar,50) {Value=kv.Key }
                };
                int row=ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);

            }
            return ResultUtil.getStandardResult((int)Status.Normal, EnumUtil.getMessageStr((int)Message.Update), null);
        }

        public string DeleteUserPermission(string username)
        {
            strSql = "DELETE FROM user_permission WHERE user_permission.uid=(SELECT `user`.hy_userid FROM `user` WHERE `user`.hy_username=@hy_username)";
            mySqlParameters = new MySqlParameter[]
            {
                new MySqlParameter("@hy_username",MySqlDbType.VarChar,50) {Value=username }
            };
            ResultUtil.insOrUpdOrDel(strSql, mySqlParameters);
            return ResultUtil.getStandardResult((int)Status.Normal, EnumUtil.getMessageStr((int)Message.Delete), null);
        }
    }
}