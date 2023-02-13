﻿using CoffeeShop.Model;
using CoffeeShop.Model.Enums;

namespace CoffeeShop.MVC.Models.Employee {
    public class EmployeeDetailsDto {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public List<CoffeeShop.Model.Transaction> Transactions { get; set; } =new List<CoffeeShop.Model.Transaction>();
    }
}
