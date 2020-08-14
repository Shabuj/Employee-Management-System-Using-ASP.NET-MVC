using EmployeeManagementApp.DAL;
using EmployeeManagementApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagementApp.BLL
{
    public class EmployeeDepartmentManager
    {
        EmployeeDepartmentGateway edg = new EmployeeDepartmentGateway();
        public List<EmployeeDepartmentViewModel> GetAllEmployeeDepartment()
        {
            return edg.GetEmployeeDepartment();
        }
    }
}