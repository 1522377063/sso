using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sso.service;
using sso.service.impl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace sso
{
    /// <summary>
    /// sso 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class sso : System.Web.Services.WebService
    {
        private ISsoService ssoService = new SsoService();

        [WebMethod(Description = @"<h3>method: CreateDept</h3>
        <p>方法描述：<strong>创建dept</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID|</strong><strong>hy_deptname<=>部门名称|</strong><strong>hy_deptsort<=>部门排序|</strong><strong>hy_isenabled<=>是否启用(0:否;1:是;)</strong>}</p>
        <p style='color:green'>成功结果：<strong>创建成功</strong></p>
        <p style='color:red'>失败结果：<strong>创建失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string CreateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled)
        {            
            return ssoService.CreateDept(hy_deptid, hy_deptname, hy_deptsort, hy_isenabled);
        }

        [WebMethod(Description = @"<h3>method: UpdateDept</h3>
        <p>方法描述：<strong>修改dept</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID|</strong><strong>hy_deptname<=>部门名称|</strong><strong>hy_deptsort<=>部门排序|</strong><strong>hy_isenabled<=>是否启用(0:否;1:是;)</strong>}</p>
        <p style='color:green'>成功结果：<strong>修改成功</strong></p>
        <p style='color:red'>失败结果：<strong>修改失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string UpdateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled)
        {
            return ssoService.UpdateDept(hy_deptid, hy_deptname, hy_deptsort, hy_isenabled);
        }

        [WebMethod(Description = @"<h3>method: DeleteDept</h3>
        <p>方法描述：<strong>删除dept</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID</strong>}</p>
        <p style='color:green'>成功结果：<strong>删除成功</strong></p>
        <p style='color:red'>失败结果：<strong>删除失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string DeleteDept(string hy_deptid)
        {
            return ssoService.DeleteDept(hy_deptid);
        }

        [WebMethod(Description = @"<h3>method: CreateUser</h3>
        <p>方法描述：<strong>创建user</strong></p> 
        <p>参数：{<strong>hy_userid<=>用户ID</strong><strong>hy_deptid<=>部门ID|</strong><strong>hy_username<=>用户名称|</strong><strong>hy_post<=>职务|</strong>
        <strong>hy_ifleader<=>是否领导|</strong><strong>hy_officetel<=>办公室电话|</strong><strong>hy_hometel<=>住宅电话|</strong><strong>hy_mobile<=>手机号码|</strong>
        <strong>hy_virtualnumber<=>短号|</strong><strong>hy_sort<=>排序号|</strong><strong>hy_isenabled<=>是否启用|</strong><strong>hy_birthday<=>生日|</strong>
        <strong>hy_officenumber<=>房间号|</strong><strong>hy_sex<=>性别|</strong><strong>hy_politicallandscape<=>政治面貌|</strong><strong>hy_education<=>学历|</strong>
        <strong>hy_university<=>毕业院校|</strong><strong>hy_jointime<=>进单位时间|</strong><strong>hy_address<=>家庭住址|</strong><strong>hy_identitycardnumber<=>身份证号码</strong>}</p>
        <p style='color:green'>成功结果：<strong>创建成功</strong></p>
        <p style='color:red'>失败结果：<strong>创建失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string CreateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post,
            string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber,
            string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex,
            string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime,
            string hy_address, string hy_identitycardnumber)
        {
            return ssoService.CreateUser(hy_userid, hy_deptid, hy_username, hy_post,
            hy_ifleader, hy_officetel, hy_hometel, hy_mobile, hy_virtualnumber,
            hy_sort, hy_isenabled, hy_birthday, hy_officenumber, hy_sex,
            hy_politicallandscape, hy_education, hy_university, hy_jointime,
            hy_address, hy_identitycardnumber);
        }

        [WebMethod(Description = @"<h3>method: UpdateUser</h3>
        <p>方法描述：<strong>修改user</strong></p> 
        <p>参数：{<strong>hy_userid<=>用户ID</strong><strong>hy_deptid<=>部门ID|</strong><strong>hy_username<=>用户名称|</strong><strong>hy_post<=>职务|</strong>
        <strong>hy_ifleader<=>是否领导|</strong><strong>hy_officetel<=>办公室电话|</strong><strong>hy_hometel<=>住宅电话|</strong><strong>hy_mobile<=>手机号码|</strong>
        <strong>hy_virtualnumber<=>短号|</strong><strong>hy_sort<=>排序号|</strong><strong>hy_isenabled<=>是否启用|</strong><strong>hy_birthday<=>生日|</strong>
        <strong>hy_officenumber<=>房间号|</strong><strong>hy_sex<=>性别|</strong><strong>hy_politicallandscape<=>政治面貌|</strong><strong>hy_education<=>学历|</strong>
        <strong>hy_university<=>毕业院校|</strong><strong>hy_jointime<=>进单位时间|</strong><strong>hy_address<=>家庭住址|</strong><strong>hy_identitycardnumber<=>身份证号码</strong>}</p>
        <p style='color:green'>成功结果：<strong>修改成功</strong></p>
        <p style='color:red'>失败结果：<strong>修改失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string UpdateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post,
            string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber,
            string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex,
            string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime,
            string hy_address, string hy_identitycardnumber)
        {
            return ssoService.UpdateUser(hy_userid, hy_deptid, hy_username, hy_post,
                hy_ifleader, hy_officetel, hy_hometel, hy_mobile, hy_virtualnumber,
                hy_sort, hy_isenabled, hy_birthday, hy_officenumber, hy_sex,
                hy_politicallandscape, hy_education, hy_university, hy_jointime,
                hy_address, hy_identitycardnumber);
        }

        [WebMethod(Description = @"<h3>method: DeleteUser</h3>
        <p>方法描述：<strong>删除user</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID</strong>}</p>
        <p style='color:green'>成功结果：<strong>删除成功</strong></p>
        <p style='color:red'>失败结果：<strong>删除失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public string DeleteUser(string hy_userid)
        {
            return ssoService.DeleteUser(hy_userid);
        }

        [WebMethod(Description = @"<h3>method: DeleteUser</h3>
        <p>方法描述：<strong>删除user</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID</strong>}</p>
        <p style='color:green'>成功结果：<strong>删除成功</strong></p>
        <p style='color:red'>失败结果：<strong>删除失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void GetUserPermission()
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.getReportList());
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: getReportList</h3>
        <p>方法描述：<strong>删除user</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID</strong>}</p>
        <p style='color:green'>成功结果：<strong>{'status':200,'message':'获取列表成功','result':[{'id':1,'report_person':'1','reportdate':'1','phone':'1','content':'1','type':'1','pid':1,'pic':[{'id':131879593684158846,'pid':1,'typeid':6,'filetype':'poi','filename':'01','filepath':'/service/upload/1/131879593684158846.xlsx','totalbytes':18920,'ext':'xlsx','note':'18.48 K','createtime':'2018-11-29T18:02:48','creatorid':1,'creator':'1','delflag':false,'fileblob':null,'rid':1}]}]}</strong></p>
        <p style='color:red'>失败结果：<strong>删除失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void GetReportList()
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.getReportList());
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: getReportList</h3>
        <p>方法描述：<strong>删除user</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID</strong>}</p>
        <p style='color:green'>成功结果：<strong>{'status':200,'message':'获取列表成功','result':[{'id':1,'report_person':'1','reportdate':'1','phone':'1','content':'1','type':'1','pid':1,'pic':[{'id':131879593684158846,'pid':1,'typeid':6,'filetype':'poi','filename':'01','filepath':'/service/upload/1/131879593684158846.xlsx','totalbytes':18920,'ext':'xlsx','note':'18.48 K','createtime':'2018-11-29T18:02:48','creatorid':1,'creator':'1','delflag':false,'fileblob':null,'rid':1}]}]}</strong></p>
        <p style='color:red'>失败结果：<strong>删除失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void GetReportListById(int id)
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.getReportListById(id));
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: CreateDept</h3>
        <p>方法描述：<strong>创建dept</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID|</strong><strong>hy_deptname<=>部门名称|</strong><strong>hy_deptsort<=>部门排序|</strong><strong>hy_isenabled<=>是否启用(0:否;1:是;)</strong>}</p>
        <p style='color:green'>成功结果：<strong>创建成功</strong></p>
        <p style='color:red'>失败结果：<strong>创建失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void AddReport(int id, string report_person, string reportdate, string phone, string content, string type,int pid)
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.AddReport(id, report_person, reportdate, phone, content, type, pid));
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: UpdateDept</h3>
        <p>方法描述：<strong>修改dept</strong></p> 
        <p>参数：{<strong>hy_deptid<=>部门ID|</strong><strong>hy_deptname<=>部门名称|</strong><strong>hy_deptsort<=>部门排序|</strong><strong>hy_isenabled<=>是否启用(0:否;1:是;)</strong>}</p>
        <p style='color:green'>成功结果：<strong>修改成功</strong></p>
        <p style='color:red'>失败结果：<strong>修改失败</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void UpdateReport(int id, string report_person, string reportdate, string phone, string content, string type, int pid)
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.UpdateReport(id, report_person, reportdate, phone, content, type, pid));
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: GetUserPermissionList</h3>
        <p>方法描述：<strong>查询用户权限列表</strong></p> 
        <p>参数：{<strong>page<=>当前页|</strong><strong>rows<=>分页每页大小|</strong>}</p>
        <p style='color:green'>成功结果：<strong>{'total':2,'rows':[{'username':'张三','cunzhuang':1,'cesuo':0,'minsu':0,'jingqu':1,'addtuceng':1,'shouhuiditu':0,'addimage':0,'ninghaimaoyucun':0,'ninghai':1,'addmodel':0,'addpanorama':1}]}</strong></p>
        <p>输出格式：<strong>json</strong></p></br>")]
        public void GetUserPermissionList(int page,int rows)
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.GetUserPermissionList(page,rows));
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: EditUserPermission</h3>
        <p>方法描述：<strong>修改用户权限列表</strong></p> 
        <p>参数：{<strong>json<=>要编辑的数据以json格式传送</strong>}</p>
        <p style='color:green'>成功结果：<strong>{status: '200', message: '修改成功', result: null}</strong></p>
        < p>输出格式：<strong>json</strong></p></br>")]
        public void EditUserPermission(string json)
        {
            //HttpRequest request = HttpContext.Current.Request;
            //Stream stream = request.InputStream;
            //StreamReader streamReader = new StreamReader(stream);
            //string json = string.Empty;
            //json = streamReader.ReadToEnd();
            ////{"username":"张三","cunzhuang":0,"cesuo":0,"minsu":1,"jingqu":1,"addtuceng":1,"shouhuiditu":0,"addimage":1,"ninghaimaoyucun":0,"ninghai":1,"addmodel":1,"addpanorama":1}
            //json = HttpUtility.UrlDecode(json);

            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.EditUserPermission(json));
            Context.Response.End();
        }

        [WebMethod(Description = @"<h3>method: DeleteUserPermission</h3>
        <p>方法描述：<strong>删除用户权限列表</strong></p> 
        <p>参数：{<strong>username<=>用户名</strong>}</p>
        <p style='color:green'>成功结果：<strong>{status: '200', message: '删除成功', result: null}</strong></p>
        < p>输出格式：<strong>json</strong></p></br>")]
        public void DeleteUserPermission(string username)
        {
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ssoService.DeleteUserPermission(username));
            Context.Response.End();
        }
        
    }
}
