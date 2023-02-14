using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

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
            var result = _engineerRepo.GetAll();
            return result.Select(engineer => new EngineerListDto {
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<EngineerListDto> GetById(int id) {
            var result = _engineerRepo.GetById(id);
            return new EngineerEditDto {
                Id = id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPerMonth
            };
        }

        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name);
            newEngineer.Surname = engineer.Surname;
            newEngineer.SalaryPerMonth = engineer.SalaryPetMonth;
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            itemToUpdate.Name = engineer.Name;
            itemToUpdate.Surname = engineer.Surname;
            itemToUpdate.SalaryPerMonth = engineer.SalaryPerMonth;
            _engineerRepo.Update(engineer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _engineerRepo.Delete(id);
        }
    }
}

