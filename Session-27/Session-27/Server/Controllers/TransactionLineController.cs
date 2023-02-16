using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;
        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo,IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {

            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
            _transactionLineRepo= transactionLineRepo;
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _transactionLineRepo.Delete(id);
      }
        public async Task Put(TransactionLineEditDto transLine) {
            var itemToUpdate = _transactionLineRepo.GetById(transLine.Id);
            itemToUpdate.Id = transLine.Id;
            itemToUpdate.EngineerId = transLine.EngineerId;
            itemToUpdate.Hours = transLine.Hours;
            itemToUpdate.PricePerHour = 44;
            itemToUpdate.Price = transLine.Hours * 44;
            itemToUpdate.ServiceTaskId = transLine.ServiceTaskId;
            _transactionLineRepo.Update(transLine.Id, itemToUpdate);
        }

        [HttpPost]
        public async Task Post(TransactionLineEditDto transLine) {
            var newTransactionLine = new TransactionLine(transLine.Hours , 44,transLine.Hours*44);
            newTransactionLine.EngineerId = transLine.EngineerId;
            newTransactionLine.ServiceTaskId = transLine.ServiceTaskId;
            newTransactionLine.TransactionId= transLine.TransactionId;
            _transactionLineRepo.Add(newTransactionLine);
        }
    }
    
}
