using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practose1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentsManager _students;

        public StudentController(IStudentsManager students)
        {
            _students = students;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var allStudents = _students.GetAll();
            return Ok(allStudents);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddStudent(Student pupil1)
        {
            _students.AddStudent(pupil1);            
            return Ok();
        }
        

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            _students.DeleteStudent(id);
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateStudent(Student studentToChange) 
        {
            _students.UpdateStudent(studentToChange);
            return Ok();
        }

        [HttpGet("Search")]
        public async Task<IActionResult> ChooseStudent(int id) 
        {
            var student = _students.GetStudent(id);

            return Ok(student);
        }
        

    }
}
