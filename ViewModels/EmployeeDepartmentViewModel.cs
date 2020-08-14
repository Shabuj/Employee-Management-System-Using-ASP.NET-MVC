using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementApp.ViewModels
{
    public class EmployeeDepartmentViewModel
    {
       
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string NID { set; get; }
        public DateTime JoiningDate { get; set; }
        public int DepartmentId { set; get; }
        public string BloodGroup { set; get; }
        public string Code { get; set; }
        public string DepartmentName { get; set; }

        public EmployeeDepartmentViewModel(int employeeId,string name, string designation, string nid, DateTime joiningDate, string bloodGroup, int departmentId,string code,string departmentName)
        {
            EmployeeId = employeeId;
            EmployeeName = name;
            Designation = designation;
            NID = nid;
            JoiningDate = joiningDate;
            BloodGroup = bloodGroup;
            DepartmentId = departmentId;
            Code = code;
            DepartmentName = departmentName;

        }

    }
}