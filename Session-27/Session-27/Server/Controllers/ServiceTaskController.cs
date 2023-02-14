using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Session_27.Client.Pages.ServiceTask;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;
using Session_27.Shared.ServiceTask;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session_27.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceTaskController : ControllerBase
    {

        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo)
        {
            _serviceTaskRepo = serviceTaskRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ServiceTaskListDto>> Get()
        {
            var result = _serviceTaskRepo.GetAll();
            return result.Select(task => new ServiceTaskListDto
            {
                 Id = task.Id,
                 Code = task.Code,
                 Description = task.Description,
                 Hours = task.Hours,
            }) ;
        }

        [HttpGet("{id}")]
        public async Task<ServiceTaskEditDto> GetById(int id)
        {
            var result = _serviceTaskRepo.GetById(id);
            return new ServiceTaskEditDto
            {
                Id = result.Id,
                Code = result.Code,
                Description = result.Description,
                Hours = result.Hours,
            };
        }

        [HttpPost]
        public async Task Post(ServiceTaskEditDto serviceTask)
        {
            var newTask = new ServiceTask(serviceTask.Code ,serviceTask.Description, serviceTask.Hours);                 
            _serviceTaskRepo.Add(newTask);
        }











































    }
}
