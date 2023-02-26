using Microsoft.AspNetCore.Mvc;
using webRequestHandling.models;
using webRequestHandling2.models;

namespace webRequestHandling2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly databaseContext _db;
        public EmployeeController(databaseContext db)
        {
            _db= db;
        }
        [HttpGet]
        //In IEnumberable the filter logic gets executed at the client side
        public async Task<ActionResult<Employee>> Index()
        {
            //IEnumerable<Employee> employees = _db.Employees;
            IQueryable<Employee> employees = _db.Employees;
            var d = employees.Where(m => m.Id == 1).ToList();
            return Ok(d);

            //Ilist we use in case of add remove or refer to an item using index.
        }
    }
}

