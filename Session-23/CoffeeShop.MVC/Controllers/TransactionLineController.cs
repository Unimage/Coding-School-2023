using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.MVC.Models.Transaction;
using CoffeeShop.MVC.Models.TransactionLine;
using CoffeeShop.Orm.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace CoffeeShop.MVC.Controllers {
    public class TransactionLineController : Controller {
        private IEntityRepo<Product> _prodRepo;
        private IEntityRepo<Transaction> _transRepo;
        private IEntityRepo<TransactionLine> _transLineRepo;
        public TransactionLineController(IEntityRepo<Product> prodRepo, IEntityRepo<Transaction> transRepo, IEntityRepo<TransactionLine> transLineRepo) {
            _prodRepo = prodRepo;
            _transRepo = transRepo;
            _transLineRepo = transLineRepo;
        }

        #region Index
        // GET: TransactionLineController
        public ActionResult Index() {
            var transLines = _transLineRepo.GetAll();
            
            return View(model:transLines);
        }
        #endregion
        #region Details
        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id) {
            var dbTransLine = _transLineRepo.GetById(id);
            if (id == null) {
                return NotFound();
            }
            if (dbTransLine == null) {
                return NotFound();
            }
            var viewTransLine = new TransactionLineDto {
                Id= dbTransLine.Id,
                Price= dbTransLine.Price,
                TotalPrice= dbTransLine.TotalPrice,
                Product= dbTransLine.Product,
                ProductId = dbTransLine.ProductId,
                Quantity = dbTransLine.Quantity,
                Discount= dbTransLine.Discount,
                Transaction = dbTransLine.Transaction,
                TransactionId = dbTransLine.TransactionId
            };

            return View(model: viewTransLine);
        }
        #endregion
        #region Create
        // GET: TransactionLineController/Create
        public ActionResult Create() {
            var newTransactionLine = new TransactionLineEditDto();
            var products = _prodRepo.GetAll();
            var trans = _transRepo.GetAll();
            foreach(var prod in products) {
                newTransactionLine.Products.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(prod.Description.ToString(), prod.Id.ToString()));
            }
            foreach (var tr in trans) {
                newTransactionLine.Transactions.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(tr.Id.ToString(), tr.Id.ToString()));
            }
            return View(model:newTransactionLine);
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionLineEditDto newtransline) {
            if (!ModelState.IsValid) {
                return View();
            }
            var products = _prodRepo.GetAll();
            var price = products.Where(prod => prod.Id == newtransline.ProductId).SingleOrDefault().Price;
            var totalPrice = price * newtransline.Quantity;
            var dbTransLine = new TransactionLine(newtransline.Quantity, newtransline.Discount, price, totalPrice);
            dbTransLine.ProductId = newtransline.ProductId;
            dbTransLine.TransactionId = newtransline.TransactionId;
            _transLineRepo.Create(dbTransLine);
            return RedirectToAction("Index");
        }
        #endregion
        #region Edit
        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id) {
            var dbTransLine = _transLineRepo.GetById(id);
            var dbProducts = _prodRepo.GetAll();
            var dbTransactions = _transRepo.GetAll();
            if (dbTransLine == null) {
                return NotFound();
            }
            var transline = new TransactionLineEditDto();
            foreach (var prod in dbProducts) {
                transline.Products.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(prod.Description.ToString(), prod.Id.ToString()));
            }
            foreach (var trans in dbTransactions) {
                transline.Transactions.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(trans.Id.ToString(), trans.Id.ToString()));
            }
            transline.Quantity = dbTransLine.Quantity;
            transline.Discount = dbTransLine.Discount;
            transline.Price = dbTransLine.Price;
            transline.TotalPrice = dbTransLine.TotalPrice;
            transline.TransactionId = dbTransLine.TransactionId;
            transline.ProductId = dbTransLine.ProductId;
            return View(model:transline);
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionLineEditDto transline) {
            {
                if (!ModelState.IsValid) {
                    return View();
                }
                var dbTransLine = new TransactionLine(transline.Quantity, transline.Discount, transline.Price, transline.TotalPrice);
                dbTransLine.TransactionId = transline.TransactionId;
                dbTransLine.ProductId = transline.ProductId;
                _transLineRepo.Update(transline.Id, dbTransLine);
                return RedirectToAction("Index");
            }
        }
            #endregion
            #region Delete
            // GET: TransactionLineController/Delete/5
            public ActionResult Delete(int id) {
            var dbTransactionLine = _transLineRepo.GetById(id);
            var viewTransactionLine = new TransactionLineDto {
                Id= dbTransactionLine.Id,
                Product = dbTransactionLine.Product,
                ProductId = dbTransactionLine.ProductId,
                Quantity = dbTransactionLine.Quantity,
                Discount = dbTransactionLine.Discount,
                Transaction = dbTransactionLine.Transaction,
                TransactionId = dbTransactionLine.TransactionId
            }; 
            return View(model:viewTransactionLine);
        }

        // POST: TransactionLineController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _transLineRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
        #endregion
    }
}
