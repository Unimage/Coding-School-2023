using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class MonthlyLedgerController : ControllerBase {

        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MonthlyLedgerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo, IEntityRepo<Transaction> transactionRepo) {
            _managerRepo = managerRepo;
            _engineerRepo = engineerRepo;
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<List<MonthlyLedgerDto>> Get() {
            List<MonthlyLedgerDto> monthlyLedgerList = new();
            var engineers = _engineerRepo.GetAll();
            var managers = _managerRepo.GetAll();
            var trans = _transactionRepo.GetAll();            
            for (int i = 1; i <= 12; i++) {                
                monthlyLedgerList.Add(new MonthlyLedgerDto {
                    Year = 2023,
                    Month = i
                });
            }
            foreach (MonthlyLedgerDto obj in monthlyLedgerList) {
                if (obj.Month <= DateTime.Now.Month) {
                    MonthlyLedgerIncome(obj, trans);
                    MonthlyLedgerExpenses(obj, engineers, managers);
                    obj.Total = obj.Income - obj.Expenses;
                }
            }

            return monthlyLedgerList;
        }

        private static void MonthlyLedgerIncome(MonthlyLedgerDto monthlyLedger, IList<Transaction> transactions) {
            monthlyLedger.Income = 0;
            foreach (Transaction tran in transactions) {
                int year = tran.Date.Year;
                int month = tran.Date.Month;
                if (monthlyLedger.Year == year && monthlyLedger.Month == month) {
                    monthlyLedger.Income += tran.TotalPrice;
                }
            }
        }

        private static void MonthlyLedgerExpenses(MonthlyLedgerDto monthlyLedger, IList<Engineer> engineers, IList<Manager> managers) {
            monthlyLedger.Expenses = 0;
            foreach (Engineer engineer in engineers)
                monthlyLedger.Expenses += engineer.SalaryPerMonth;
            foreach (Manager manager in managers)
                monthlyLedger.Expenses += manager.SalaryPerMonth;

        }
    }
}