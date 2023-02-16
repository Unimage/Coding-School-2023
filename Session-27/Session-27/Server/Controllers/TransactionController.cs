using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Session_27.Shared.MintoAkoumpate;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private TransactionHandler _transHandler;

        public TransactionController(TransactionHandler transHandler, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
            _transHandler= transHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var result = _transactionRepo.GetAll();
            foreach(var tr in result) { tr.TotalPrice = _transHandler.CalculateTotalCost(tr); }
            var transList = result.Select(transaction => new TransactionListDto {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalPrice = transaction.TotalPrice,
                CustomerId = transaction.CustomerId,
                ManagerId = transaction.ManagerId,
                CarId = transaction.CarId,

                Manager = new ManagerEditDto() {
                    Id = transaction.Manager.Id,
                    Name = transaction.Manager.Name,
                    Surname = transaction.Manager.Surname,
                    SalaryPerMonth = transaction.Manager.SalaryPerMonth
                },

                Customer = new CustomerEditDto() {
                    Id = transaction.Customer.Id,
                    Name = transaction.Customer.Name,
                    Surname = transaction.Customer.Surname,
                    Phone = transaction.Customer.Phone,
                    Tin = transaction.Customer.Tin
                },

                Car = new CarEditDto() {
                    Id = transaction.Car.Id,
                    Model = transaction.Car.Model,
                    Brand = transaction.Car.Brand,
                    CarRegistrationNumber = transaction.Car.CarRegistrationNumber
                },
            });

            return transList;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _transactionRepo.Delete(id);
        }

        //Create - Post
        [HttpPost]
        public async Task<ActionResult> Post(TransactionEditDto transaction) {

            var transactionList = _transactionRepo.GetAll().ToList();
            if (_transHandler.ValidateInsertTransaction(transactionList,transaction)){
                var newTransaction = new Transaction();
                newTransaction.CustomerId = transaction.CustomerId;
                newTransaction.ManagerId = transaction.ManagerId;
                newTransaction.CarId = transaction.CarId;
                newTransaction.TotalPrice = 0;
                newTransaction.TransactionLines = new();
                _transactionRepo.Add(newTransaction);
                return Ok();
            }
            return StatusCode(StatusCodes.Status406NotAcceptable,
               "Either Customer or Car Exists in another Transaction");
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditDto transaction) {
            var transactionList = _transactionRepo.GetAll().ToList();
           if(_transHandler.ValidateUpdateTransaction(transactionList, transaction)) {
                var transactionUpdate = _transactionRepo.GetById(transaction.Id);
                transactionUpdate.Date = transaction.Date;
                transactionUpdate.TotalPrice = transaction.TotalPrice;
                transactionUpdate.CustomerId = transaction.CustomerId;
                transactionUpdate.ManagerId = transaction.ManagerId;
                transactionUpdate.CarId = transaction.CarId;
                _transactionRepo.Update(transaction.Id, transactionUpdate);
                return Ok();
            }
            return StatusCode(StatusCodes.Status406NotAcceptable,
               "Either Customer or Car Exists in another Transaction");
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id) {

            var result = _transactionRepo.GetById(id); 
            result.TotalPrice = _transHandler.CalculateTotalCost(result);
            var resultManager = _managerRepo.GetAll();
            var resultCar = _carRepo.GetAll();
            var resultCustomer = _customerRepo.GetAll();
            var transaction = new TransactionEditDto {
                Id = id,
                Date = result.Date,
                CustomerId = result.CustomerId,
                ManagerId = result.ManagerId,
                CarId = result.CarId,
                TotalPrice = result.TotalPrice,

                /*     Managers = resultManager.Select(manager => new ManagerEditDto {
                         Id = manager.Id,
                         Name = manager.Name,
                         SalaryPerMonth = manager.SalaryPerMonth,
                         Surname = manager.Surname,
                     }).ToList(),
                     Cars = resultCar.Select(car => new CarEditDto {
                         Brand = car.Brand,
                         Model = car.Model,
                         CarRegistrationNumber = car.CarRegistrationNumber,
                     }).ToList(),
                     Customers = resultCustomer.Select(customer => new CustomerEditDto {
                         Id = customer.Id,
                         Name = customer.Name,
                         Surname = customer.Surname,
                         Phone = customer.Phone,
                         Tin = customer.Tin,
                     }).ToList(),*/
                TransactionLines = result.TransactionLines.Select(transactionLine => new TransactionLineEditDto {
                    Id = transactionLine.Id,
                    Hours = transactionLine.Hours,
                    PricePerHour = transactionLine.PricePerHour,
                    Price = transactionLine.Price,
                    TransactionId = transactionLine.TransactionId,
                    ServiceTaskId = transactionLine.ServiceTaskId,
                    EngineerId = transactionLine.EngineerId
                }).ToList()
            };
            return transaction;
        }
    }

}
