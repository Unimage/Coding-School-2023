using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

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
                CustomerCardNumber = _customerRepo.GetById(transaction.CustomerID).CardNumber,
                EmployeeName = _employeeRepo.GetById(transaction.EmployeeID).Name + " " + _employeeRepo.GetById(transaction.EmployeeID).Surname,
                TransLines = transaction.TransactionLines.Select(transactionLine => new TransactionLineViewModel {
                    ID = transactionLine.ID,
                    ItemID = transactionLine.ItemID,
                    ItemName = transactionLine.Item.Description,
                    Quantity = transactionLine.Quantity,
                    NetValue= transactionLine.NetValue
                    
                }).ToList()
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
                transToAdd.ID= trans.ID;
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

        [HttpGet("{id}")]
        public async Task<TransactionListViewModel?> Get(Guid id) {
            TransactionListViewModel trans = new();
            try {
                if (id != Guid.Empty) {
                    var result = _transactionRepo.GetById(id);
                    trans.ID = result.ID;
                    trans.TotalValue = result.TotalValue;
                    trans.Date = result.Date;
                    
                    trans.PaymentMethod= result.PaymentMethod;
                    trans.TransLines = result.TransactionLines.Select(transactionLine => new TransactionLineViewModel {
                        ID = transactionLine.ID,
                        ItemName = transactionLine.Item.Description,
                        Quantity = transactionLine.Quantity,
                        ItemPrice= transactionLine.ItemPrice,
                        TotalValue = transactionLine.TotalValue,
                        TransactionID = transactionLine.TransactionID,
                        NetValue = transactionLine.NetValue,
                    }).ToList();
                }
                return trans;
            }
            catch (Exception) {
                return null;
            }

        }
        public async Task<ActionResult> Put(TransactionListViewModel trans) {
            try {
                Transaction transToAdd = _transactionRepo.GetById(trans.ID);
                transToAdd.TotalValue = trans.TotalValue;
                _transactionRepo.Update(transToAdd.ID,transToAdd);
                return Ok();
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status406NotAcceptable,
               "Some Problem with transactionLine");

            }
        }


    }

}
