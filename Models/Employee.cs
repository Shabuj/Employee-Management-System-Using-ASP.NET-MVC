using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string NID { set; get; }
        public DateTime JoiningDate { get; set; }
        public int DepartmentId { set; get; }

        public string BloodGroup { set; get; }
        public Employee()
        {

        }

        public Employee(string name, string designation, string NID, DateTime joiningDate, int dept, string bloodGroup)
        {
            Name = name;
            Designation = designation;
            this.NID = NID;
            JoiningDate = joiningDate;
            DepartmentId = dept;
            BloodGroup = bloodGroup;
        }
    }
}