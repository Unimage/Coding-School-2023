using FuelStation.Blazor.Shared.Etc;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly DataValidator _dataValidator;
        private readonly Limits _limits;

        public CustomerController(IEntityRepo<Customer> customerRepo, DataValidator datavalidator, Limits limits) {
            _customerRepo = customerRepo;
            _dataValidator = datavalidator;
            _limits = limits;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListViewModel>> Get() {
            var result = _customerRepo.GetAll();
            return result.Select(customer => new CustomerListViewModel {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            });
        }
        [HttpGet("{id:Guid}")]
        public async Task<CustomerViewModel?> Get(Guid id) {
            CustomerViewModel customer = new();
            try {
                if (id != Guid.Empty) {
                    var result = _customerRepo.GetById(id);
                    if (result is null) return null;

                    customer.ID = result.ID;
                    customer.Name = result.Name;
                    customer.Surname = result.Surname;
                    customer.CardNumber = result.CardNumber;
                    customer.Transactions = result.Transactions;
                }
                return customer;
            }
            catch (Exception) {
                return null;
            }
        }
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<CustomerListViewModel>> Delete(Guid id) {
            try {
                var customer = _customerRepo.GetById(id);

                if (customer is null) {
                    return NotFound($"Customer with Id {id} not found");
                }

                _customerRepo.Delete(id);
                return Ok();
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error at deleting data");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post(CustomerViewModel customer) {
            if (_dataValidator.ValidadeCustomerData(customer)) {
                var newCustomer = new Customer {
                    ID = customer.ID,
                    Name = customer.Name,
                    Surname = customer.Surname,
                    CardNumber = customer.CardNumber,
                };
                newCustomer.Transactions = new();


                _customerRepo.Add(newCustomer);
                return Ok();
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
              "Data weren't within Valid Limits");
            }
        }
        public async Task<ActionResult> Put(CustomerViewModel customer) {

            var itemToUpdate = _customerRepo.GetById(customer.ID);
            if (_dataValidator.ValidadeCustomerData(customer)) {
                itemToUpdate.ID = customer.ID;
                itemToUpdate.Name = customer.Name;
                itemToUpdate.Surname = customer.Surname;
                itemToUpdate.CardNumber = customer.CardNumber;
                itemToUpdate.Transactions = customer.Transactions;
                _customerRepo.Update(customer.ID, itemToUpdate);
                return Ok();
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
              "Data weren't within Valid Limits");
            }
        }
        [Route("/customers/details/{id}")]
        [HttpGet]
        public async Task<CustomerViewModel?> GetDetailsById(Guid id) {
            var result = await Task.Run(() => { return _customerRepo.GetById(id); });
            if (result is null) {
                return null;
            }
            else {
                return new CustomerViewModel {
                    ID = id,
                    Name = result.Name,
                    Surname = result.Surname,
                    CardNumber = result.CardNumber,
                    Trans = result.Transactions.Select(t => new TransactionBasicViewModel {
                        Date = t.Date,
                        TotalValue = t.TotalValue,
                        PaymentMethod = t.PaymentMethod,
                    }).ToList()
                };
            }
        }
    }
}
