using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

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

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {

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
                    Name = manager.FullName
                }).ToList()
            };
        }





        //[HttpGet("{id}")]




        //[HttpPut]



        //[HttpDelete("{id}")]






    }



}
