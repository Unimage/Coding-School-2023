using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase {
        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ManagerListDto>> Get() {
            var manager = _managerRepo.GetAll();
            return manager.Select(manager => new ManagerListDto {
                Id = manager.Id,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<ManagerEditDto> GetById(int id) {
            var manager = _managerRepo.GetById(id);
            return new ManagerEditDto {
                Id = manager.Id,
                Name = manager.Name,
                Surname = manager.Surname,
                SalaryPerMonth = manager.SalaryPerMonth
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
            itemToUpdate.Id = manager.Id;
            itemToUpdate.Name = manager.Name;
            itemToUpdate.Surname = manager.Surname;
            itemToUpdate.SalaryPerMonth = manager.SalaryPerMonth;
            _managerRepo.Update(manager.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                _managerRepo.Delete(id);
                return Ok();
            }
            catch (DbUpdateException ex) {
                return BadRequest("This todo cannot be deleted!");
            }
            catch (KeyNotFoundException ex) {
                return BadRequest($"Todo with id {id} not found!");
            }
        }
    }
}

