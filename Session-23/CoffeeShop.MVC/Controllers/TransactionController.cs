using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.MVC.Models.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace CoffeeShop.MVC.Controllers {
    public class TransactionController : Controller {
        private IEntityRepo<Product> _prodRepo;
        private IEntityRepo<Customer> _customerRepo;
        private IEntityRepo<Employee> _employeeRepo;
        private IEntityRepo<Transaction> _transRepo;
        private IEntityRepo<TransactionLine> _transLineRepo;
        public TransactionController(IEntityRepo<Product> prodRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transRepo, IEntityRepo<TransactionLine> transLineRepo) {
            _prodRepo = prodRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transRepo = transRepo;
            _transRepo = transRepo;
            _transLineRepo = transLineRepo;
        }
        #region Index
        // GET: TransactionController
        public ActionResult Index() {
            var trans = _transRepo.GetAll().ToList();
            return View(model: trans);
        }
        #endregion

        #region Details
        // GET: TransactionController/Details/5
        public ActionResult Details(int id) {
            var dbtrans = _transRepo.GetById(id);
            if (id == null) {
                return NotFound();
            }
            if (dbtrans == null) {
                return NotFound();
            }
            var viewTransaction = new TransactionDetailsDto {
                Id = dbtrans.Id,
                CustomerId = dbtrans.CustomerId,
                Customer = dbtrans.Customer,
                EmployeeId = dbtrans.EmployeeId,
                Employee = dbtrans.Employee,
                Date = dbtrans.Date,
                TransactionLines = dbtrans.TransactionLines,
                TotalPrice = dbtrans.TotalPrice,
                PaymentMethod = dbtrans.PaymentMethod
            };
            return View(model: viewTransaction);
        }
        #endregion
        #region Create
        // GET: TransactionController/Create
        public ActionResult Create() {
            var newTransaction = new TransactionCreateDto();
            var employees = _employeeRepo.GetAll();
            var customers = _customerRepo.GetAll();
            foreach (var emp in employees) {
                newTransaction.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(emp.Surname + " " + emp.Name, emp.Id.ToString()));
            }
            foreach (var cus in customers) {
                newTransaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Description, cus.Id.ToString()));
            }
            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto newtrans) {
            if (!ModelState.IsValid) {
                return View();
            }
            var dbTransaction = new Transaction(newtrans.TotalPrice, newtrans.PaymentMethod);
            dbTransaction.TransactionLines = newtrans.TransactionLines;
            dbTransaction.CustomerId = newtrans.CustomerId;
            dbTransaction.EmployeeId = newtrans.EmployeeId;
            dbTransaction.Date = newtrans.Date;
            _transRepo.Create(dbTransaction);
            return RedirectToAction("Index");
        }
        #endregion
        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {
            var transaction = _transRepo.GetById(id);
            var employees = _employeeRepo.GetAll();
            var customers = _customerRepo.GetAll();
            if (id == null) {
                return NotFound();
            }
            if (transaction == null) {
                return NotFound();
            }
            var viewTransactionDto = new TransactionEditDto {
                Id= transaction.Id,
                CustomerId= transaction.CustomerId,
                EmployeeId= transaction.EmployeeId,
                Date = transaction.Date,
                TotalPrice= transaction.TotalPrice,
                PaymentMethod= transaction.PaymentMethod,
                TransactionLines = transaction.TransactionLines

            };
            foreach (var emp in employees) {
                viewTransactionDto.Employees.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(emp.Surname + " " + emp.Name, emp.Id.ToString()));
            }
            foreach (var cus in customers) {
                viewTransactionDto.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Description, cus.Id.ToString()));
            }

            return View(model:viewTransactionDto);
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionEditDto transaction) {
            if (!ModelState.IsValid) {
                return View();
            }
            var dbTransaction = _transRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }
            dbTransaction.PaymentMethod = transaction.PaymentMethod;
            dbTransaction.CustomerId = transaction.CustomerId;
            dbTransaction.EmployeeId = transaction.EmployeeId;
            dbTransaction.Date = transaction.Date;
            _transRepo.Update(id,dbTransaction);
            return RedirectToAction(nameof(Index));
        }
        #region Delete
        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {
            var dbTransaction = _transRepo.GetById(id);
            if (dbTransaction == null) {
                return NotFound();
            }
            var viewTransaction = new TransactionDeleteDto {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                TotalPrice = dbTransaction.TotalPrice,
                PaymentMethod = dbTransaction.PaymentMethod,
                Customer = dbTransaction.Customer,
                Employee = dbTransaction.Employee,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                TransactionLines = dbTransaction.TransactionLines
            };
            return View(model:viewTransaction);
        }

        // POST: TransactionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _transRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
        #endregion
    }
}
