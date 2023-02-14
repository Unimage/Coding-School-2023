using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get() {
            var customerList = _customerRepo.GetAll();
            return customerList.Select(customer => new CustomerListDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin
            });
        }

        //Create - Post
        [HttpPost]
        public async Task Post(CustomerCreateDto customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.Phone, customer.Tin);
            newCustomer.Transactions = new();
            _customerRepo.Add(newCustomer);
        }


        //Delete
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }

        //Edit - GetbyID
        [HttpGet("{id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
            Id = id,
            Name = result.Name,
            Surname = result.Surname,
            Phone = result.Phone,
            Tin = result.Tin

        };
        }


        //Put
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);
            itemToUpdate.Id = customer.Id;
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.Phone = customer.Phone;
            itemToUpdate.Tin = customer.Tin;
            itemToUpdate.Transactions = customer.Transactions;
            _customerRepo.Update(customer.Id, itemToUpdate);
        }



    }
}
