using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [Controller]
    public class ManagerController : ControllerBase {
        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ManagerListDto>> Get() {
            var result = _managerRepo.GetAll();
            return result.Select(manager => new ManagerListDto {
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<ManagerEditDto> GetById(int id) {
            var result = _managerRepo.GetById(id);
            return new ManagerEditDto {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                SalaryPerMonth = result.SalaryPerMonth
            };
        }

        [HttpPost]
        public async Task Post(ManagerEditDto manager) {
            var newManager = new Manager(manager.Name,manager.Surname,manager.SalaryPerMonth);
            newManager.Surname = manager.Surname;
            newManager.SalaryPerMonth = manager.SalaryPerMonth;
            _managerRepo.Add(newManager);
        }

        [HttpPut]
        public async Task Put(ManagerEditDto manager) {
            var itemToUpdate = _managerRepo.GetById(manager.Id);
            itemToUpdate.Name = manager.Name;
            itemToUpdate.Surname = manager.Surname;
            itemToUpdate.SalaryPerMonth = manager.SalaryPerMonth;
            _managerRepo.Update(manager.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _managerRepo.Delete(id);
        }
    }
}

