using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webRequestHandling2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<webRequestHandling.models.Employee>> Get()
        {
            var employees = new List<webRequestHandling.models.Employee>
            {
                new webRequestHandling.models.Employee { Id = 1,firstName="Vamshi",lastName="Krishna",country="India"}
            };
            return Ok(employees);
        }
    }
}
