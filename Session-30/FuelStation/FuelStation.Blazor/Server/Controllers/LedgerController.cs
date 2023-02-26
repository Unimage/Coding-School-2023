using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly LedgerHandler _ledgerHandler;

        public LedgerController(IEntityRepo<Transaction> transactionRepo,IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo, LedgerHandler ledgerHandler) {
            _ledgerHandler = ledgerHandler;
            _transactionRepo = transactionRepo;
            _employeeRepo = employeeRepo;
            _itemRepo = itemRepo;
        }

        [HttpGet("{year}/{month}")]
        public async Task<LedgerViewModel> Get(int year, int month) {

            var transactions =  _transactionRepo.GetAll();
            var employees =  _employeeRepo.GetAll();
            _ledgerHandler._employees = employees.ToList();
            _ledgerHandler._transactions = transactions.ToList();
            return _ledgerHandler.CreateLedger(year, month);
        }

    }
}
