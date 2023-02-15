using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo){ 
       
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
        }



        // [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get() {
            var trans = _transactionRepo.GetAll();

            return trans.Select(trans => new TransactionListDto {
                Id = trans.Id,
                Date = trans.Date,
                TotalPrice = trans.TotalPrice,
                CustomerId = trans.CustomerId,
                ManagerId = trans.ManagerId,
                CarId = trans.CarId,
                TransactionLines = trans.TransactionLines,
                Car = trans.Car,
                Manager= trans.Manager,
                Customer= trans.Customer

            });
        }

        //[HttpGet("{id}")]
        [HttpGet("{id}")]
        public async Task<TransactionListDto> GetById(int id)
        {
            var transaction = _transactionRepo.GetById(id);
            var customers = _customerRepo.GetAll();
            var managers = _managerRepo.GetAll();
            var cars = _carRepo.GetAll();
            return new TransactionListDto
            {
                Customer = customers.Select(customer => new Customer()
                {
                    Id = customer.Id,
                    Name = customer.Name
                }).ToList().SingleOrDefault(),
                Car = cars.Select(car => new Car()
                {
                    Id = car.Id,
                    Brand = car.Brand
                }).ToList().FirstOrDefault(),
                Manager = managers.Select(manager => new Manager
                {
                    Id = manager.Id,
                    Name = manager.Name
                }).ToList().FirstOrDefault()
            };
        }





        //[HttpGet("{id}")]




        //[HttpPut]



        //[HttpDelete("{id}")]






    }



}
