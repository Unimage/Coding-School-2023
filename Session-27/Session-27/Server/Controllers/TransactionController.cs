using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        //private readonly IEntityRepo<>

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo)
        {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
        }



        // [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var trans = _transactionRepo.GetAll();

            return trans.Select(trans => new TransactionListDto
            {
                Id = trans.Id,
                Date = trans.Date,
                TotalPrice = trans.TotalPrice,
                CustomerId = trans.CustomerId,
                ManagerId = trans.ManagerId,
                CarId = trans.CarId,
                TransactionLines = trans.TransactionLines,
                Car = trans.Car,
                Manager = trans.Manager,
                Customer = trans.Customer

            });
        }

        //[HttpGet("{id}")]
        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var transaction = _transactionRepo.GetById(id);
            var customers = _customerRepo.GetAll();
            var managers = _managerRepo.GetAll();
            var cars = _carRepo.GetAll();
            return new TransactionEditDto
            {
                Customers = customers.Select(customer => new CustomerListDto
                {
                    Id = customer.Id,
                    Name = customer.FullName
                }).ToList(),
                Cars = cars.Select(car => new CarListDto
                {
                    Id = car.Id,
                    Brand = car.Brand
                }).ToList(),
                Managers = managers.Select(manager => new ManagerListDto
                {
                    Id = manager.Id,
                    Name = manager.Name
                }).ToList()
            };
        }

        [HttpPost]
        public async Task Post(TransactionListDto transaction)
        {
            var newTransaction = new Transaction(transaction.TotalPrice);
            newTransaction.Id = transaction.Id;
            newTransaction.Date = transaction.Date;
            newTransaction.TotalPrice = transaction.TotalPrice;
            newTransaction.CustomerId = transaction.CustomerId;
            newTransaction.ManagerId = transaction.ManagerId;
            newTransaction.CarId = transaction.CarId;
            //list of transaction lines
            newTransaction.TransactionLines = transaction.TransactionLines; //TransactionLines = new List<TransactionLine>();

            _transactionRepo.Add(newTransaction);
        }



        [HttpPut]
        public async Task Put(TransactionEditDto trans)
        {
            var transactionToUpdate = _transactionRepo.GetById(trans.Id);

             transactionToUpdate.CustomerId = trans.CustomerId;
             transactionToUpdate.ManagerId = trans.ManagerId;
             transactionToUpdate.CarId = trans.CarId;
             transactionToUpdate.TotalPrice = trans.TotalPrice;
             transactionToUpdate.Date = trans.Date;
             transactionToUpdate.TransactionLines = trans.TransactionLines.Select(transline => new TransactionLine(transline.Hours, transline.PricePerHour, transline.Price)
            { 
       
            }
            ).ToList();
   

            _transactionRepo.Update(trans.Id, transactionToUpdate);
        }


        //[HttpDelete("{id}")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _transactionRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                return BadRequest("This todo cannot be deleted!");
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest($"Todo with id {id} not found!");
            }
        }





    }



}
