using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers
{
    [Route("[customer]")]
    [ApiController]
public class CustomerController : ControllerBase
{
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;

        }

        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var customerList = _customerRepo.GetAll();
            return customerList.Select(customer => new CustomerListDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname= customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin
            });
        }




    }
}
