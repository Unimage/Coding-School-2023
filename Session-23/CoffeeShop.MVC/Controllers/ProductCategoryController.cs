using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.Model.Enums;
using CoffeeShop.MVC.Models.ProductCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;

namespace CoffeeShop.MVC.Controllers {
    public class ProductCategoryController : Controller {
        private IEntityRepo<ProductCategory> _prodCatRepo;
        public ProductCategoryController(IEntityRepo<ProductCategory> prodCatRepo) {
            _prodCatRepo = prodCatRepo;
        }
        // GET: ProductCategoryCustomer
        public ActionResult Index() {
            var prodCats = _prodCatRepo.GetAll();
            var prodCategories = prodCats.ToList();
            return View(model: prodCategories);
        }

        // GET: ProductCategoryCustomer/Details/5
        public ActionResult Details(int? id) {
            var prodCat = _prodCatRepo.GetById(id.Value);
            if (id == null) {
                return NotFound();
            }
            if (prodCat == null) {
                return NotFound();
            }
            var viewProductCategory = new ProductCategoryDetailsDto {
                Id=prodCat.Id,
                Description=prodCat.Description,
                Code=prodCat.Code
    };
            return View(model: viewProductCategory);
        } 

        // GET: ProductCategoryCustomer/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ProductCategoryCustomer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ProductCategoryCustomer/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: ProductCategoryCustomer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

        // GET: ProductCategoryCustomer/Delete/5
        public ActionResult Delete(int id) {
            var dbProductCategory = _prodCatRepo.GetById(id);
            if(dbProductCategory == null) {
                return NotFound();
            }
            var viewProductCategory = new ProductCategoryDeleteDto {
                Id = dbProductCategory.Id,
                Description = dbProductCategory.Description,
                Code = dbProductCategory.Code
            };
            return View(model:viewProductCategory);
        }

        // POST: ProductCategoryCustomer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            _prodCatRepo.Delete(id);
            return RedirectToAction(nameof(Index));
            
        }
    }
}
