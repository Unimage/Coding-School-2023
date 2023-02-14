using Microsoft.AspNetCore.Mvc;

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [Controller]
    public class ManagerController : ControllerBase {
        private readonly IEntityRepo<Engineer> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ManagerDto>> Get() {
            var result = _managerRepo.GetAll();
            return result.Select(manager => new ManagerDto {
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPetMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<ManagerDto> GetById(int id) {
            var result = _managerRepo.GetById(id);
            return new ManagerEditDto {
                Id = id,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPetMonth
            };
        }

        [HttpPost]
        public async Task Post(ManagerEditDto manager) {
            var newManager = new Manager(manager.Name);
            newManager.Surname = manager.Surname;
            newManager.SalaryPetMonth = manager.SalaryPetMonth;
            _managerRepo.Add(newManager);
        }

        [HttpPut]
        public async Task Put(ManagerEditDto manager) {
            var itemToUpdate = _managerRepo.GetById(manager.Id);
            itemToUpdate.Name = manager.Name;
            itemToUpdate.Surname = manager.Surname;
            itemToUpdate.SalaryPetMonth = manager.SalaryPetMonth;
            _managerRepo.Update(manager.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _managerRepo.Delete(id);
        }
    }
}

