using EmployeeManagementApp.BLL;
using EmployeeManagementApp.Models;
using EmployeeManagementApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeManager em = new EmployeeManager();
        EmployeeDepartmentManager edm = new EmployeeDepartmentManager();
        public ActionResult Index()
        {
            List<EmployeeDepartmentViewModel> employeeDepartmentList = edm.GetAllEmployeeDepartment();
            return View(employeeDepartmentList);
        }
        public ActionResult Create()
        {
            DepartmentManager dm = new DepartmentManager();
            var departments=dm.GetDepartments();
            return View(departments);
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            Employee emp = new Employee(employee.Name, employee.Designation, employee.NID,employee.JoiningDate, employee.DepartmentId, employee.BloodGroup);
           string isSaved= em.SaveEmployee(emp);
              ViewBag.IsSaved = isSaved;
             DepartmentManager dm = new DepartmentManager();
             var departments = dm.GetDepartments();
            // return RedirectToAction("Index");
            return View(departments);
        }
    }
}