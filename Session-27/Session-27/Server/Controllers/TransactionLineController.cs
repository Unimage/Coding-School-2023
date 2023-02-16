using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {
 
            private readonly IEntityRepo<Transaction> _transactionRepo;
            private readonly IEntityRepo<Customer> _customerRepo;
            private readonly IEntityRepo<Manager> _managerRepo;
            private readonly IEntityRepo<Car> _carRepo;
            private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
            private readonly IEntityRepo<Engineer> _engineerRepo;

            public TransactionLineController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo)
            {

                _transactionRepo = transactionRepo;
                _customerRepo = customerRepo;
                _managerRepo = managerRepo;
                _carRepo = carRepo;
                _serviceTaskRepo = serviceTaskRepo;
                _engineerRepo = engineerRepo;
            }



        [HttpGet]
        [HttpGet("{id}")]

        [HttpPost]

        [HttpPut]

        [HttpDelete("{id}")]
























    }
}
