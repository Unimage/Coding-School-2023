using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using CoffeeShop.MVC.Models.Employee;
using CoffeeShop.MVC.Models.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Pkcs;

namespace CoffeeShop.MVC.Controllers {
    public class EmployeeController : Controller {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo) {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;

        }
        // GET: EmployeeController
        public ActionResult Index() {
            var emp = _employeeRepo.GetAll();
            var employees = emp.ToList();
            return View(model: employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int? id) {
            var employee = _employeeRepo.GetById(id.Value);
            if (id == null) {
                return NotFound();
            }
            if (employee == null) {
                return NotFound();
            }
            var viewEmployee = new EmployeeDetailsDto {
                EmployeeType = employee.EmployeeType,
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                SalaryPerMonth = employee.SalaryPerMonth

            };
            var transList = _transactionRepo.GetAll().ToList();
            foreach (var tr in transList) {
                if (tr.EmployeeId == viewEmployee.Id) {
                    viewEmployee.Transactions.Add(tr);
                }
            }
            return View(model: viewEmployee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create() {
            var newEmployee = new EmployeeCreateDto();
            return View(model: newEmployee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDto employee) {
            if (!ModelState.IsValid) {
                //  if (!CheckStaffLimits(employee)) { return View(); }
                return View();

            }
            var dbEmployee = new Employee(employee.Name, employee.Surname, employee.SalaryPerMonth, employee.EmployeeType);
            try {
                _employeeRepo.Create(dbEmployee);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id) {
            if (id == null) {
                return NotFound();
            }
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }
            var editEmployee = new EmployeeEditDto {
                Id = dbEmployee.Id
            };

            return View(model: editEmployee);
        }


        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEditDto employee) {
            if (!ModelState.IsValid) {

                // if (!CheckStaffLimits(employee)) { return View(); }
                return View();
            }
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }
            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.EmployeeType = employee.EmployeeType;
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id) {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) {
                return NotFound();
            }
            
            var deleteEmployee = new EmployeeDeleteDto {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname
            };
            return View(model: deleteEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
           // if (!CheckStaffLimits(collection)) { return View(); }
            _employeeRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        #region Handlers
        public bool CheckStaffLimits(object employeeToBeHandled) {
            var Employees = _employeeRepo.GetAll().ToList();
            if (employeeToBeHandled.GetType() == typeof(EmployeeCreateDto)) {
                var create = employeeToBeHandled as EmployeeCreateDto;
                Employee inserted = new Employee(create.Name, create.Surname, create.SalaryPerMonth, create.EmployeeType);
                Employees.Add(inserted);
            }
            else if (employeeToBeHandled.GetType() == typeof(EmployeeDeleteDto)) {
                var delete = employeeToBeHandled as EmployeeDeleteDto;
                Employee deleted = new Employee(delete.Name, delete.Surname, 0, 0);
                Employees.Remove(deleted);
            }
            else if (employeeToBeHandled.GetType() == typeof(EmployeeEditDto)) {
                var update = employeeToBeHandled as EmployeeEditDto;
                Employee updated = new Employee(update.Name, update.Surname, update.SalaryPerMonth, update.EmployeeType);
                foreach (var emp in Employees)
                    if (emp.Id == update.Id) {
                        emp.Surname = update.Surname;
                        emp.Name = update.Name;
                        emp.SalaryPerMonth = update.SalaryPerMonth;
                        emp.EmployeeType = update.EmployeeType;
                    }
            }
            bool ok = true;
            int managers = 0;
            int cashiers = 0;
            int baristas = 0;
            int waiters = 0;
            foreach (var employee in Employees) {
                switch (employee.EmployeeType) {
                    case EmployeeType.Manager:
                        managers++;
                        break;
                    case EmployeeType.Cashier:
                        cashiers++;
                        break;
                    case EmployeeType.Barista:
                        baristas++;
                        break;
                    case EmployeeType.Waiter:
                        waiters++;
                        break;
                }
            }
            if (managers != 1)
                ok= false;
            ;
            if (cashiers < 1 || cashiers > 2)
                ok= false;
            if (baristas < 1 || baristas > 2)
                ok= false;
            if (waiters < 1 || waiters > 2)
                ok= false; ;
            return ok;
        }
    }
}

#endregion