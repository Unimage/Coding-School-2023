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


        public List<Employee> Employees { get; set; } = new List<Employee>();

        public List<Product> Products { get; set; } = new List<Product>();
        public List<ProductCategory> ProductCategories {get; set;} = new List<ProductCategory>();   


        public void SetDefaultEmployees() {
            Employees.Add(new Employee { Name = "Stratos ", Surname = "Chalkopiadis", Salary = 4000, EmployeeType = EmployeeType.Manager });
            Employees.Add(new Employee { Name = "Giorgos", Surname = " Zacharidis", Salary = 3000, EmployeeType = EmployeeType.Cashier });
            Employees.Add(new Employee { Name = "Anestis", Surname = " Kountoyrgiannis", Salary = 2000, EmployeeType = EmployeeType.Barista });
            Employees.Add(new Employee { Name = "Ioannis", Surname = " Koukotzilas", Salary = 1000, EmployeeType = EmployeeType.Waiter });
        }

        public void SetDefaultProducts() {
            Products.Add(new Product { Code = "Product 1 code", Description = "Espresso", Price = 1.9m, Cost = 1.5m });
            Products.Add(new Product { Code = "Product 2 code", Description = "Cola", Price = 1.5m, Cost = 0.5m });
            Products.Add(new Product { Code = "Product 3 code", Description = "Toast", Price = 1.5m, Cost = 0.5m });
        }

        public void SetDefaultProductCategories() {
            ProductCategories.Add(new ProductCategory { Code = "Product category 1 code", Description = "Coffee", ProductType = ProductType.Coffee });
            ProductCategories.Add(new ProductCategory { Code = "Product category 2 code", Description = "Beverage", ProductType = ProductType.Beverages });
            ProductCategories.Add(new ProductCategory { Code = "Product category 3 code", Description = "Food", ProductType = ProductType.Food });
        }

        // Serializer Methods

        public void SerializeEmployee() {
            Serializer serializer = new Serializer();
            
            foreach (var employee in Employees) {
                serializer.SerializeToFile(employee, "employee.json");
            }

        }
        //public void SerializeEmployee() {
        //  Serializer serializer = new Serializer();
        //  foreac(var sr in Employees ){
        //       serializer.SerializeToFile(sr, "employee.json");}
        //  


        public void DeserializeEmployee() {
            Serializer serializer = new Serializer();
            Employee tmpEmployee = serializer.DeserializeFromFile<Employee>("employee.json");
            Employees.Add(tmpEmployee); 
        }

        public void SerializeProduct() {
            Serializer serializer = new Serializer();
            
            foreach (var product in Products) {
                serializer.SerializeToFile(product, "product.json");
            }

        }

        public void DeserializeProduct() {
            Serializer serializer = new Serializer();
            product = serializer.DeserializeFromFile<Product>("product.json");
            
        }

        public void SerializeProductCategory() {
            Serializer serializer = new Serializer();
            
            foreach (var productCategory in ProductCategories) {
                serializer.SerializeToFile(productCategory, "product-category.json");
            }

        }

        public void DeserializeProduct() {
            Serializer serializer = new Serializer();
            productCategory = serializer.DeserializeFromFile<ProductCategory>("product-category.json");
           
        }

    


    }
}


