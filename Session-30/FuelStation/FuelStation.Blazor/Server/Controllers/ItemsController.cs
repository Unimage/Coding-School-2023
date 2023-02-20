using FuelStation.Blazor.Shared.Etc;
using FuelStation.Blazor.Shared.Services;
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase {
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly DataValidator _dataValidator;
        private readonly Limits _limits;

        public ItemController(IEntityRepo<Item> itemRepo, DataValidator datavalidator, Limits limits) {
            _itemRepo = itemRepo;
            _dataValidator = datavalidator;
            _limits = limits;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get() {
            var result = _itemRepo.GetAll();
            return result.Select(x => new ItemListViewModel {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                ItemType = x.ItemType,
                Price = x.Price,
                Cost = x.Cost
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemViewModel?> Get(Guid id) {
            ItemViewModel item = new();
            try {
                if (id != Guid.Empty) {
                    var result = _itemRepo.GetById(id);
                    item.ID = result.ID;
                    item.Code = result.Code;
                    item.Description = result.Description;
                    item.ItemType = result.ItemType;
                    item.Cost = result.Cost;
                    item.Price = result.Price;
                }
                return item;
            }
            catch (Exception) {
                return null;
            }

        }
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<ItemViewModel>> Delete(Guid id) {
            try {
                var itemToDelete = _itemRepo.GetById(id);

                if (itemToDelete is null) return NotFound($"Item with Id = {id} not found");
                _itemRepo.Delete(id);
                return Ok();
            }
            catch (Exception e) {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post(ItemViewModel item) {
            if (_dataValidator.ValidateItemData(item)) { 
                var newItem = new Item() {
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost
                };
                _itemRepo.Add(newItem);
                return Ok();
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
          "Data weren't within Valid Limits");
            }
        }
        public async Task<ActionResult> Put(ItemViewModel item) {

            var itemToUpdate = _itemRepo.GetById(item.ID);
            if (_dataValidator.ValidateItemData(item)){ 
                itemToUpdate.ID = item.ID;
                itemToUpdate.Code = item.Code;
                itemToUpdate.Description = item.Description;
                itemToUpdate.Cost = item.Cost;
                itemToUpdate.Price = item.Price;
                itemToUpdate.ItemType= item.ItemType;
                _itemRepo.Update(item.ID, itemToUpdate);
                return Ok();
            }
            else {
                return StatusCode(StatusCodes.Status406NotAcceptable,
              "Data weren't within Valid Limits");
            }
        }
    }


}

