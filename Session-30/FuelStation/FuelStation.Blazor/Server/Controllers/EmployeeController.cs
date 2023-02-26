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
    public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly DataValidator _dataValidator;
        private readonly Limits _limits;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, DataValidator datavalidator, Limits limits) {
            _employeeRepo = employeeRepo;
            _dataValidator = datavalidator;
            _limits = limits;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeListViewModel>> Get() {
            var result = _employeeRepo.GetAll();
            return result.Select(employee => new EmployeeListViewModel {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                HireDateEnd = employee.HireDateEnd,
                HireDateStart = employee.HireDateStart,
                SallaryPerMonth = employee.SallaryPerMonth
            });
        }
        [HttpPost]
        //validations done 
        public async Task<ActionResult> Post(EmployeeViewModel employee) {
            if (_dataValidator.ValidateEmployeeData(employee)) {
                if (_dataValidator.CheckRosterPlus(_employeeRepo.GetAll().ToList(), employee)) {
                    Employee toAdd = new Employee();
                    toAdd.Name = employee.Name;
                    toAdd.Surname = employee.Surname;
                    toAdd.EmployeeType = employee.EmployeeType;
                    toAdd.HireDateStart = employee.HireDateStart;
                    toAdd.SallaryPerMonth = employee.SallaryPerMonth;
                    toAdd.username = employee.username;
                    toAdd.password = employee.password;
                    _employeeRepo.Add(toAdd);
                    return Ok();
                }
                else {
                    return StatusCode(StatusCodes.Status409Conflict,
                  "Data weren't within Valid Limits");
                }
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
              "Data weren't within Valid Limits");
            }
        }
        [HttpGet("{id}")]
        public async Task<EmployeeViewModel?> Get(Guid id) {
            EmployeeViewModel employee = new();
            try {
                if (id != Guid.Empty) {
                    var employeeDB = _employeeRepo.GetById(id);
                    employee.ID = employeeDB.ID;
                    employee.Name = employeeDB.Name;
                    employee.Surname = employeeDB.Surname;
                    employee.EmployeeType = employeeDB.EmployeeType;
                    employee.HireDateStart = employeeDB.HireDateStart;
                    employee.HireDateEnd = employeeDB.HireDateEnd;
                    employee.SallaryPerMonth = employeeDB.SallaryPerMonth;
                    employee.username = employeeDB.username;
                    employee.password = employeeDB.password;
                }
                return employee;
            }
            catch (Exception) {
                return null;
            }
        }
        //validations done
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<EmployeeViewModel>> Delete(Guid id) {
            try {
                var itemToDelete = _employeeRepo.GetById(id);
                if (itemToDelete is null) return NotFound($"Item with Id = {id} not found");
                _employeeRepo.Delete(id);
                return Ok(); 
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }

        [Route("/employees/details/{id}")]
        [HttpGet]
        public async Task<EmployeeViewModel?> GetDetailsById(Guid id) {
            var result = await Task.Run(() => { return _employeeRepo.GetById(id); });
            if (result is null) {
                return null;
            }
            else {
                return new EmployeeViewModel {
                    ID = id,
                    Name = result.Name,
                    Surname = result.Surname,
                    EmployeeType = result.EmployeeType,
                    HireDateStart = result.HireDateStart,
                    HireDateEnd = result.HireDateEnd,
                    Trans = result.Transactions.Select(t => new TransactionBasicViewModel {
                        Date = t.Date,
                        TotalValue = t.TotalValue,
                        PaymentMethod = t.PaymentMethod,
                    }).ToList()
                };
            }
        }
        //validations done 
        public async Task<ActionResult> Put(EmployeeViewModel employee) {
            var itemToUpdate = _employeeRepo.GetById(employee.ID);
            if (_dataValidator.ValidateEmployeeData(employee)) {
                if (_dataValidator.CheckRosterPut(_employeeRepo.GetAll().ToList(), employee , itemToUpdate)) {
                    itemToUpdate.ID = employee.ID;
                    itemToUpdate.Name = employee.Name;
                    itemToUpdate.Surname = employee.Surname;
                    itemToUpdate.EmployeeType = employee.EmployeeType;
                    itemToUpdate.HireDateStart = employee.HireDateStart;
                    itemToUpdate.HireDateEnd = employee.HireDateEnd;
                    itemToUpdate.SallaryPerMonth= employee.SallaryPerMonth;
                    itemToUpdate.username = employee.username;
                    itemToUpdate.password = employee.password;
                    _employeeRepo.Update(employee.ID, itemToUpdate);
                    return Ok();
                }
                else return StatusCode(StatusCodes.Status409Conflict,
              "Data weren't within Valid Limits");
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
              "Data weren't within Valid Limits");
            }
        }
        //validations done 
        [HttpPut("fire")]
        public async Task<ActionResult> Fire(EmployeeListViewModel employee) {
            if (_dataValidator.CheckRosterMinus(_employeeRepo.GetAll().ToList(), employee)) {
                var itemtoFire = _employeeRepo.GetById(employee.ID);
                itemtoFire.HireDateEnd = DateTime.Now;
                _employeeRepo.Update(employee.ID, itemtoFire);
                return Ok();
            }
            else {
                return StatusCode(StatusCodes.Status409Conflict,
              "Data weren't within Valid Limits");
            }
        }
        //validations done 
        [HttpPut("rehire")]
        public async Task<ActionResult> Rehire(EmployeeListViewModel employee) {
            if (_dataValidator.CheckRosterPlus(_employeeRepo.GetAll().ToList(), employee)) {
                var itemtoFire = _employeeRepo.GetById(employee.ID);
                itemtoFire.HireDateEnd = null;
                _employeeRepo.Update(employee.ID, itemtoFire);
                return Ok();
            }
            else return StatusCode(StatusCodes.Status409Conflict,
              "Data weren't within Valid Limits");
        }
    }
}
