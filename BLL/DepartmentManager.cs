using EmployeeManagementApp.DAL;
using EmployeeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();
        public  List<Department> GetDepartments()
        {
            return gateway.GetAllDepartments();
        }
    }
}