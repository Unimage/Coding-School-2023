using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Session_27.Server.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class EngineerController : ControllerBase {

        private readonly IEntityRepo<Engineer> _engineerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo, IEntityRepo<Manager> managerRepo) {
            _engineerRepo = engineerRepo;
            _managerRepo = managerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EngineerListDto>> Get() {
            var engineer = _engineerRepo.GetAll();
            return engineer.Select(engineer => new EngineerListDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId,
                Manager = new ManagerListDto{
                    Id= engineer.ManagerId,
                    Name= engineer.Manager.Name,
                    Surname= engineer.Manager.Surname
                }
            }) ;
        }

        [HttpGet("{id}")]
        public async Task<EngineerEditDto> GetById(int id) {
            var engineer = _engineerRepo.GetById(id);
            var managers = _managerRepo.GetAll();
            return new EngineerEditDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId,
                Managers = managers.Select(manager => new ManagerListDto {
                    Id = manager.Id,
                    Name = manager.FullName
                    
                }).ToList()
               // TransactionLines = engineer.TransactionLines
            };
        }

        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name,engineer.Surname,engineer.SalaryPerMonth);
            newEngineer.ManagerId = engineer.ManagerId;
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            itemToUpdate.Id = engineer.Id;
            itemToUpdate.Name = engineer.Name;
            itemToUpdate.Surname = engineer.Surname;
            itemToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
            itemToUpdate.ManagerId = engineer.ManagerId;
            _engineerRepo.Update(engineer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            try {
                _engineerRepo.Delete(id);
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

