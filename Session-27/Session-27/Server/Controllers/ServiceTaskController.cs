using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Session-27.Server.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class ServiceTaskController : ControllerBase
{
    // GET: api/<ServiceTaskController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<ServiceTaskController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ServiceTaskController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ServiceTaskController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ServiceTaskController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
