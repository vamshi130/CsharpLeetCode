using EMployeeCrudEntityFrameworkCore.DTO;
using EMployeeCrudEntityFrameworkCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMployeeCrudEntityFrameworkCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataBaseContext _db;
        public StudentController(DataBaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult GetStudents()
        {
            var studentsData = _db.Students.ToList();
            return Ok(studentsData);
        }
        [HttpPost]
        public ActionResult PostStudents(StudentCreateDTO studentObj)
        {
            Students domainsStudent =new Students();
            domainsStudent.FirstName = studentObj.FirstName;
            domainsStudent.LastName = studentObj.LastName;
            domainsStudent.Email = studentObj.Email;
            //_db.Add(studentObj);
            //_db.SaveChanges();
            _db.Students.Add(domainsStudent);
            _db.SaveChanges();  
            return Ok(studentObj);
        }

    }
}
