using EmployeeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EmployeeManagementApp.DAL
{
    public class DepartmentGateway
    {
     
        string connectionString = WebConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetDepartments", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Department> departmentList =new List<Department>();
            while(reader.Read())
            {
                int deptId = Convert.ToInt32(reader["DepartmentId"]);
                string code = reader["Code"].ToString();
                string name = reader["Name"].ToString();

                Department departs = new Department(deptId, code, name);
                departmentList.Add(departs);
            }
            reader.Close();
            connection.Close();
            return departmentList;
        }
    }
}