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
    public class EmployeeGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public List<Employee> GetAllEmployee()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sPGetEmployees", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            var employeeList = new List<Employee>();
            while (reader.Read())
            {
          
               int  employeeId = Convert.ToInt32(reader["EmployeeId"]);
               string Name = reader["Name"].ToString();
               string Designation = reader["Designation"].ToString();
               string NID = reader["NID"].ToString();
               string BloodGroup = reader["BloodGroup"].ToString();
               DateTime JoiningDate = Convert.ToDateTime(reader["JoiningDate"]);
               int DepartmentId = Convert.ToInt32(reader["Departmentid"]);

                Employee em = new Employee(Name, Designation, NID, JoiningDate, DepartmentId, BloodGroup);
                em.EmployeeId = employeeId;
                employeeList.Add(em);

            }
            reader.Close();
            connection.Close();
            return employeeList;
        }

        public  string SaveEmployees( Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"INSERT INTO Employees(Name,Designation,NID,JoiningDate,BloodGroup,CreatedDate,DepartmentId) VALUES('" + employee.Name+"','"+employee.Designation+"','"+employee.NID+"','"+employee.JoiningDate+"','"+employee.BloodGroup+ "',GETDATE(),'" + employee.DepartmentId+"')";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowEffect = command.ExecuteNonQuery();
            connection.Close();

            if(rowEffect>0)
            {
               return "SuccessFull";
            }
            return "Failed";
        }
    }

}
         
