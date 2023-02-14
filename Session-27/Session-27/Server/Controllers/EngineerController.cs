using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Microsoft.AspNetCore.Http;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [Controller]
    public class EngineerController : ControllerBase {

        private readonly IEntityRepo<Engineer> _engineerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo) {
            _engineerRepo = engineerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EngineerListDto>> Get() {
            var engineer = _engineerRepo.GetAll();
            return engineer.Select(engineer => new EngineerListDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId 
            });
        }

        [HttpGet("{id}")]
        public async Task<EngineerEditDto> GetById(int id) {
            var engineer = _engineerRepo.GetById(id);
            return new EngineerEditDto {
                Id = engineer.Id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth,
                ManagerId = engineer.ManagerId
            };
        }

        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name,engineer.Surname,engineer.SalaryPerMonth);
            newEngineer.Surname = engineer.Surname;
            newEngineer.SalaryPerMonth = engineer.SalaryPerMonth;
            newEngineer.ManagerId = engineer.ManagerId;
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            itemToUpdate.Name = engineer.Name;
            itemToUpdate.Surname = engineer.Surname;
            itemToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
            itemToUpdate.ManagerId = engineer.ManagerId;
            _engineerRepo.Update(engineer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _engineerRepo.Delete(id);
        }
    }
}

