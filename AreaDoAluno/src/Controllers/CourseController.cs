using AreaDoAluno.Models;
using AreaDoAluno.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AreaDoAluno.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly DataContext _appDbContext;

        public CourseController(DataContext appDbContext) {
            _appDbContext = appDbContext;
        }

        [HttpPost] 
        public async Task<ActionResult<Course>> AddCourse(Course course) 
        {
            try {
                _appDbContext.Courses.Add(course);
                await _appDbContext.SaveChangesAsync();

                return Ok(course);
            } catch {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Course>> UpdateCourse(Course NewCourse) 
        {
            try {
                var course = await _appDbContext.Courses.FindAsync(NewCourse.Id);

                if (course == null)
                {
                    return NotFound("Course not found");
                }

                foreach (var property in NewCourse.GetType().GetProperties())
                {
                    var NewValue = NewCourse.GetType().GetProperty(property.Name)?.GetValue(NewCourse);
                    property.SetValue(course, NewValue);
                }

                await _appDbContext.SaveChangesAsync();

                return Ok(NewCourse);
            } catch {
                return StatusCode(400);
            }
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetAll() 
        {
            try {
                var courses = await _appDbContext.Courses.ToListAsync();

                return Ok(courses);
            } catch {
                return StatusCode(400);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(int Id) 
        {
            try {
                var course = await _appDbContext.Courses.FirstOrDefaultAsync((course) => course.Id == Id);

                if (course == null) {
                    return NotFound("Course not found");
                }
                
                return Ok(course);
            } catch {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id) 
        {
            try {
                int isCourseDeleted = await _appDbContext.Courses.Where((course) => course.Id == Id).ExecuteDeleteAsync();

                if (isCourseDeleted == 0)
                {
                    return NotFound("Course not found");
                }

                await _appDbContext.Courses.Where((course) => course.Id == Id).ExecuteDeleteAsync();

                return Ok("Course deleted");
            } catch {
                return StatusCode(500);
            }
        }
    }
}
