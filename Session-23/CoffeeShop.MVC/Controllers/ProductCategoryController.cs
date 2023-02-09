using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using CoffeeShop.MVC.Models.ProductCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.MVC.Controllers {
    public class ProductCategoryController : Controller {
        private IEntityRepo<ProductCategory> _productCategoryRepo;
        public ProductCategoryController(IEntityRepo<ProductCategory> productCategoryRepo) {
            _productCategoryRepo = productCategoryRepo;
        }

        // GET: ProductCategoryController
        public ActionResult Index() {
            var tmp = _productCategoryRepo.GetAll();
            var productCategories = tmp.ToList();
            return View(model: productCategories);
        }

        // GET: ProductCategoryController/Details/5
        public ActionResult Details(int? id) {
            if(id == null) { return NotFound(); }
            var prodCatLookup = _productCategoryRepo.GetById(id.Value);
            if (prodCatLookup == null) {
                return NotFound();
            }
            var viewProductCategory = new ProductCategoryDto {
                Id = prodCatLookup.Id,
                Code = prodCatLookup.Code,
                Description = prodCatLookup.Description,
                ProductType = prodCatLookup.ProductType,
                Products = prodCatLookup.Products.ToList()
            };

            return View(model:viewProductCategory);
        }

        // GET: ProductCategoryController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ProductCategoryController/Create
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

        // GET: ProductCategoryController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: ProductCategoryController/Edit/5
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

        // GET: ProductCategoryController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: ProductCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }
    }
}
