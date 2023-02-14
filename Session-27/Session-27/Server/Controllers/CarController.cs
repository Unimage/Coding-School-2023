using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_27.EF.Repositories;
using Session_27.Model;
using Session_27.Shared;

namespace Session_27.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class CarController : ControllerBase {
        private readonly IEntityRepo<Car> _carRepo;
        public CarController(IEntityRepo<Car> carRepo) {
            _carRepo = carRepo;

        }


        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<CarListDto>> Get() {
            var carList = _carRepo.GetAll();
            return carList.Select(car => new CarListDto {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                CarRegistrationNumber = car.CarRegistrationNumber
            });
        }
        //Create - Post
        [HttpPost]
        public async Task Post(CarCreateDto car) {
            var newCar = new Car(car.Brand, car.Model, car.CarRegistrationNumber);
            newCar.Transactions = new();
            _carRepo.Add(newCar);
        }



        //Delete
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _carRepo.Delete(id);
        }


        //Edit - GetbyID
        [HttpGet("{id}")]
        public async Task<CarEditDto> GetById(int id) {
            var result = _carRepo.GetById(id);
            return new CarEditDto {
                Id = id,
                Brand = result.Brand,
                Model = result.Model,
                CarRegistrationNumber = result.CarRegistrationNumber
            };
        }

        //Put
        public async Task Put(CarEditDto car) {
            var itemToUpdate = _carRepo.GetById(car.Id);
            itemToUpdate.Id = car.Id;
            itemToUpdate.CarRegistrationNumber = car.CarRegistrationNumber;
            itemToUpdate.Brand = car.Brand;
            itemToUpdate.Model = car.Model;
            _carRepo.Update(car.Id, itemToUpdate);
        }

        //Post
    }
}
