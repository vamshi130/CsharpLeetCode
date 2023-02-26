using AutoMapper;
using EmployeeCRUD.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly DatabaseContext _db;
        public readonly IMapper _mapper;
        public EmployeeController(DatabaseContext db,IMapper mapper)
        {
            _db = db;   
            _mapper = mapper;   
        }
        [HttpGet]
        public ActionResult GetEmployees()
        {
            var employeeData= _db.Employees.ToList();
            var employeeDto=_mapper.Map<EmployeeCreateDTO>(employeeData);
            return Ok(employeeDto);
        }
        [HttpPost]
        public ActionResult PostEmployees(EmployeeCreateDTO employeeObj)
        {
            var domainEmployee=_mapper.Map<Employee>(employeeObj);
            _db.Employees.Add(domainEmployee);
            _db.SaveChanges();
            return Ok(employeeObj);
        } 
    }
}
