using FuelStation.Blazor.Shared.Etc;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        public TransactionLineController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<TransactionLine> transactionLineRepo) {
            _transactionLineRepo= transactionLineRepo;
            _transactionRepo = transactionRepo;
        }

        [HttpPost]
        public async Task<ActionResult> Post(TransactionLineViewModel transLine) {
            try { 
            TransactionLine transLineToAdd = new();
            transLineToAdd.TransactionID = transLine.TransactionID;
            transLineToAdd.ItemID = transLine.ItemID;
            transLineToAdd.ItemPrice = transLine.ItemPrice;
            transLineToAdd.Quantity = transLine.Quantity;
            transLineToAdd.NetValue = transLine.NetValue;
            transLineToAdd.DiscountPercent = transLine.DiscountPercent;
            transLineToAdd.DiscountValue = transLine.DiscountValue;
            _transactionLineRepo.Add(transLineToAdd);
                return Ok();
            }
            catch(Exception e) {
                return StatusCode(StatusCodes.Status406NotAcceptable,
               "Some Problem with transactionLine");

            }
        }
        }
}
