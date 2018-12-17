using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sso.service
{
    interface ISsoService
    {
        string CreateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled);
        string UpdateDept(string hy_deptid, string hy_deptname, string hy_deptsort, string hy_isenabled);
        string DeleteDept(string hy_deptid);
        string CreateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post, string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber, string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex, string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime, string hy_address, string hy_identitycardnumber);
        string UpdateUser(string hy_userid, string hy_deptid, string hy_username, string hy_post, string hy_ifleader, string hy_officetel, string hy_hometel, string hy_mobile, string hy_virtualnumber, string hy_sort, string hy_isenabled, string hy_birthday, string hy_officenumber, string hy_sex, string hy_politicallandscape, string hy_education, string hy_university, string hy_jointime, string hy_address, string hy_identitycardnumber);
        string DeleteUser(string hy_userid);
        string getReportList();
        string getReportListById(int id);
        string AddReport(int id, string report_person, string reportdate, string phone, string content, string type, int pid);
        string UpdateReport(int id, string report_person, string reportdate, string phone, string content, string type, int pid);
        string GetUserPermissionList();
        string EditUserPermission(string json);
        string DeleteUserPermission(string json);
    }
}
