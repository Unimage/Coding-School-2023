﻿using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Item> _itemRepo;


        public TransactionController(IEntityRepo<Transaction> transactionRepo,
           IEntityRepo<Employee> employeeRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Item> itemRepo) {
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _customerRepo = customerRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get() {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionListViewModel {
                ID = transaction.ID,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                EmployeeID = transaction.EmployeeID,
                CustomerID = transaction.CustomerID,
                TotalValue = transaction.TotalValue,
                CustomerCardNumber = transaction.Customer.CardNumber,
                EmployeeName = transaction.Employee.Name +" "+ transaction.Employee.Surname
            }) ;
        }
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<ItemViewModel>> Delete(Guid id) {
            try {
                var itemToDelete = _transactionRepo.GetById(id);

                if (itemToDelete is null) return NotFound($"Item with Id = {id} not found");
                _itemRepo.Delete(id);
                return Ok();
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post(TransactionListViewModel trans) {
            try {
                Transaction transToAdd = new();
                transToAdd.TotalValue = trans.TotalValue;
                transToAdd.CustomerID = trans.CustomerID;
                transToAdd.EmployeeID = trans.EmployeeID;
                transToAdd.Date = trans.Date;
                transToAdd.PaymentMethod = trans.PaymentMethod;
                _transactionRepo.Add(transToAdd);
                return Ok();
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status406NotAcceptable,
               "Some Problem with transactionLine");

            }
        }


    }

}
