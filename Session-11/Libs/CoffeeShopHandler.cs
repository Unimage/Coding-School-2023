using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs {
    public class CoffeeShopHandler {

        ///Summary Nikos kai giannis 
        ///exete na kanete treis listes apo antikeimena 
        ///ProductCategory , Prodcut , Emplyees
        ///kai oi treis 8a exoun ta e3is pragmata :
        ///1. checkaroun an exoun json arxeia. 
        ///2. diavazoun apo json an iparxei kai fortwnoun stis listes
        ///2.1 an ta stoixeia einai swsta tote teleiwnei i methodos 
        ///2.2 an oxi kalei mia me8odos pou eisagei default times sto ka8ena
        ///3. Oles oi listes 8a prepei na mporoun na apo8ikeutoun sta antisoixa json arxeia tous.
        ///

        public List<Employee> Employees { get; set; } = new List<Employee>;

        public List<Product> Products { get; set; } = new List<Product>;
        public List<ProductCategory> ProductCategories {get; set;} = new List<ProductCategory>();   


        public void SetDefaultEmployees() {
            Employees.Add(new Employee { Name = "Stratos Chalkopiadis", Surname = "Employee 1 Surname", Salary = 4000, EmployeeType = EmployeeType.Manager });
            Employees.Add(new Employee { Name = "Giorgos Zacharidis", Surname = "Employee 2 Surname", Salary = 3000, EmployeeType = EmployeeType.Cashier });
            Employees.Add(new Employee { Name = "Anestis Kountoyrgiannis", Surname = "Employee 3 Surname", Salary = 2000, EmployeeType = EmployeeType.Barista });
            Employees.Add(new Employee { Name = "Ioannis Koukotzilas", Surname = "Employee 4 Surname", Salary = 1000, EmployeeType = EmployeeType.Waiter });
        }

        public void SetDefaultProducts() {
            Products.Add(new Product { Code = "Product 1 code", Description = "Product 1 description", Price = 0, Cost = 0 });
            Products.Add(new Product { Code = "Product 2 code", Description = "Product 2 description", Price = 0, Cost = 0 });
            Products.Add(new Product { Code = "Product 3 code", Description = "Product 3 description", Price = 0, Cost = 0 });
        }

        public void SetDefaultProductCategories() {
            ProductCategories.Add(new ProductCategory { Code = "Product category 1 code", Description = "Product category 1 description", ProductType = ProductType.Coffee });
            ProductCategories.Add(new ProductCategory { Code = "Product category 2 code", Description = "Product category 2 description", ProductType = ProductType.Beverages });
            ProductCategories.Add(new ProductCategory { Code = "Product category 3 code", Description = "Product category 3 description", ProductType = ProductType.Food });
        }



    }
}


