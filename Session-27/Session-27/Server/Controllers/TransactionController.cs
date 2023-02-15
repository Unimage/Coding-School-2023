﻿using Microsoft.AspNetCore.Http;
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






        //[HttpGet("{id}")]




        //[HttpPut]



        //[HttpDelete("{id}")]






    }



}
