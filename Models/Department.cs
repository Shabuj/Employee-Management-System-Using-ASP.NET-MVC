using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementApp.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string  Name { get; set; }

        public Department(int deptId, string code, string name)
        {
            DepartmentId = deptId;
            Code = code;
            Name = name;
        }

    }
}