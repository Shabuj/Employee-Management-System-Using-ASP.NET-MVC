using EmployeeManagementApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EmployeeManagementApp.DAL
{
    public class EmployeeDepartmentGateway
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
       
        public List<EmployeeDepartmentViewModel> GetEmployeeDepartment()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetEmployeeDepartments", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<EmployeeDepartmentViewModel> employeeDepartmentList = new List<EmployeeDepartmentViewModel>(); 
            while(reader.Read())
            {
                int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                string employeeName = reader["EmployeeName"].ToString();
                string Designation = reader["Designation"].ToString();
                string NID = reader["NID"].ToString();
                string BloodGroup = reader["BloodGroup"].ToString();
                DateTime JoiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                int DepartmentId = Convert.ToInt32(reader["Departmentid"]);
                string code = reader["Code"].ToString();
                string departmentName = reader["DepartmentName"].ToString();

                EmployeeDepartmentViewModel em = new EmployeeDepartmentViewModel(employeeId, employeeName, Designation, NID, JoiningDate, BloodGroup, DepartmentId,code,departmentName );
                employeeDepartmentList.Add(em);
            }
            reader.Close();
            connection.Close();
            return employeeDepartmentList;
        }
    }
}