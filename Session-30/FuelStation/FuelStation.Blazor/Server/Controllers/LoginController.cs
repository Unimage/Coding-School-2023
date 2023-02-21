using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public LoginController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }
        [HttpGet("{username}/{password}")]
        public async Task<VerifiedEmployeeViewModel?> Get(string username, string password) {
            VerifiedEmployeeViewModel employee = new();

            if (string.IsNullOrWhiteSpace(username)  || string.IsNullOrWhiteSpace(password)) { 
                return null; 
            }   
            else {
                var employees = _employeeRepo.GetAll();
                var foundEmployee = employees.FirstOrDefault(x => x.username == username && x.password == password);
                if (foundEmployee is not null) {
                    employee = new() {
                        ID = foundEmployee.ID,
                        Username = foundEmployee.username,
                        FullName = foundEmployee.Name  + foundEmployee.Surname,
                        EmployeeType = foundEmployee.EmployeeType
                    };
                }
            }
            return employee;
        }

    }
}
