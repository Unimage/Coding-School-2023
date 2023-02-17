using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.Client.Pages.Transaction;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Session_27.Shared.MintoAkoumpate;
using System.Drawing;

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
        private readonly TransactionHandler _transHandler;

        public TransactionLineController(TransactionHandler transHandler, IEntityRepo<TransactionLine> transactionLineRepo, IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo, IEntityRepo<Car> carRepo, IEntityRepo<ServiceTask> serviceTaskRepo, IEntityRepo<Engineer> engineerRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
            _serviceTaskRepo = serviceTaskRepo;
            _engineerRepo = engineerRepo;
            _transactionLineRepo = transactionLineRepo;
            _transHandler = transHandler;
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            try {
                var tr = _transactionLineRepo.GetById(id).TransactionId;
                _transactionLineRepo.Delete(id);
                _transHandler.CalculateTotalCost(_transactionRepo.GetById(tr));
            }catch(Exception ex) { }
        }
        public async Task<ActionResult> Put(TransactionLineEditDto transLine) {
            var trans = _transactionRepo.GetById(transLine.TransactionId);
            var itemToUpdate = _transactionLineRepo.GetById(transLine.Id);
            itemToUpdate.Id = transLine.Id;
            itemToUpdate.EngineerId = transLine.EngineerId;
            itemToUpdate.Hours = transLine.Hours;
            itemToUpdate.PricePerHour = 44.5m;
            itemToUpdate.Price = 0;
            itemToUpdate.Hours = _serviceTaskRepo.GetById(transLine.ServiceTaskId).Hours;
            itemToUpdate.ServiceTaskId = transLine.ServiceTaskId;
            if (_transHandler.ValidateUpdateTransactionLine(trans, transLine)) {
                if (_transHandler.ValidateMaxWorkLoad(trans, itemToUpdate, _engineerRepo.GetAll().Count())) {
                    _transactionLineRepo.Update(transLine.Id, itemToUpdate);
                    var tmpTrans = _transactionRepo.GetById(itemToUpdate.TransactionId);
                    tmpTrans.TotalPrice = (_transHandler.CalculateTotalCost(tmpTrans));
                    _transactionRepo.Update(itemToUpdate.TransactionId, tmpTrans);
                    return Ok();
                }
                else {
                    return StatusCode(StatusCodes.Status409Conflict,
                    "Max WorkLoad Reached");
                }
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
               "Either Engineer Or Task exists in another TransactionLine");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(TransactionLineEditDto transLine) {
            var trans = _transactionRepo.GetById(transLine.TransactionId);
            var newTransactionLine = new TransactionLine(0, 44.5m, 0);
            newTransactionLine.EngineerId = transLine.EngineerId;
            newTransactionLine.ServiceTaskId = transLine.ServiceTaskId;
            newTransactionLine.TransactionId = transLine.TransactionId;
            newTransactionLine.Hours = _serviceTaskRepo.GetById(transLine.ServiceTaskId).Hours;
            if (_transHandler.ValidateInsertTransactionLine(trans, transLine)) {
                if (_transHandler.ValidateMaxWorkLoad(trans, newTransactionLine, _engineerRepo.GetAll().Count())) {
                    _transactionLineRepo.Add(newTransactionLine);
                    var tmpTrans = _transactionRepo.GetById(newTransactionLine.TransactionId);
                    tmpTrans.TotalPrice = (_transHandler.CalculateTotalCost(tmpTrans));
                    _transactionRepo.Update(transLine.TransactionId, tmpTrans);
                    return Ok();

                }
                else {
                    return StatusCode(StatusCodes.Status409Conflict,
                    "Max WorkLoad Reached");
                }
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
               "Either Engineer Or Task exists in another TransactionLine");
            }
        }
    }
}
