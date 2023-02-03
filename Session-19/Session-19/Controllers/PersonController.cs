using Microsoft.AspNetCore.Mvc;

namespace Session_19.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase {

        [HttpGet(Name = "GetPersonName")]
        public Person Get() {

            Person person = new Person();
            person.FName = "Stratos";
            person.age = 25;
            person.LName = "Chalkopiadis";

            return person;
        }
    }
}