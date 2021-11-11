using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP1_ASPNETCORE.Models;
using TP1_ASPNETCORE.Models.Repositories;

namespace TP1_ASPNETCORE.Controllers
{
    public class EmployeeController : Controller
    {
        //injection de dépendance
        readonly IRepository<Employee> employeeRepository;
      
       public EmployeeController(IRepository<Employee> empRepository)
        {
            employeeRepository = empRepository;
        }
        
        // GET: Employee
        public ActionResult Index()
        {
            var employees = employeeRepository.GetAll();

            ViewData["EmployeesCount"] = employees.Count();
            ViewData["SalaryAverage"] = employeeRepository.SalaryAverage();
            ViewData["MaxSalary"] = employeeRepository.MaxSalary();
            ViewData["HREmployeesCount"] = employeeRepository.HrEmployeesCount();
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var employee = employeeRepository.FindByID(id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee e)
        {
            try
            {
                employeeRepository.Add(e);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = employeeRepository.FindByID(id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee newemployee)
        {
            try
            {
                employeeRepository.Update(id, newemployee);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var employee = employeeRepository.FindByID(id);
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee e)
        {
            try
            {
                employeeRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Search(string term)
        {
            var result = employeeRepository.Search(term);

            return View("Index", result);
        }

        public ViewResult Exemple_Viewbag()
        {
            Employee emp = employeeRepository.FindByID(1); 
            ViewBag.PageTitle = "Employee Details"; 
            ViewBag.Employee = emp;
            return View();
        }
    }
}