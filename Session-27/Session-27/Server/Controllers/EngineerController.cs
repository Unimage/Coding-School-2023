using Microsoft.AspNetCore.Mvc;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [Controller]
    public class EngineerController : ControllerBase {
        private readonly IEntityRepo<Engineer> _engineerRepo;

        public EngineerController(IEntityRepo<Engineer> engineerRepo) {
            _engineerRepo = engineerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EngineerDto>> Get() {
            var result = _engineerRepo.GetAll();
            return result.Select(engineer => new EngineerDto {
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPetMonth
            });
        }

        [HttpGet("{id}")]
        public async Task<EngineerDto> GetById(int id) {
            var result = _engineerRepo.GetById(id);
            return new EngineerEditDto {
                Id = id,
                Name = engineer.Name,
                Surname = engineer.Surname,
                SalaryPerMonth = engineer.SalaryPetMonth
            };
        }

        [HttpPost]
        public async Task Post(EngineerEditDto engineer) {
            var newEngineer = new Engineer(engineer.Name);
            newEngineer.Surname = engineer.Surname;
            newEngineer.SalaryPetMonth = engineer.SalaryPetMonth;
            _engineerRepo.Add(newEngineer);
        }

        [HttpPut]
        public async Task Put(EngineerEditDto engineer) {
            var itemToUpdate = _engineerRepo.GetById(engineer.Id);
            itemToUpdate.Name = engineer.Name;
            itemToUpdate.Surname = engineer.Surname;
            itemToUpdate.SalaryPetMonth = engineer.SalaryPetMonth;
            _engineerRepo.Update(engineer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _engineerRepo.Delete(id);
        }
    }
}

