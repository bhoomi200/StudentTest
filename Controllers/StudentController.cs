using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentTest.Models;
using StudentTest.Services;

namespace StudentTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentTest StudentService;
        public StudentController(IStudentTest _studentService)
        {
            StudentService = _studentService;
        }

        [HttpGet("studentlist")]
        public async Task<IActionResult> GetStudents()
        {
            try
            {
                var result = StudentService.GetStudents();
                return StatusCode(200, result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            

        }
        [HttpGet("getstudentbyid")]
        public async Task<IActionResult> GetStudent(int Id)
        {
            try
            {
                var result = StudentService.GetStudent(Id);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("addstudent")]
        public async Task<IActionResult> PostStudent(Student student)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var result = StudentService.PostStudent(student);
                    return StatusCode(200,result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("updatestudent")]
        public async Task<IActionResult> PutStudent(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = StudentService.PutStudent(student);
                    return StatusCode(200, result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteStudent(int Id)
        {

            try
            {
                var result = StudentService.DeleteStudent(Id);
                return StatusCode(200, result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
