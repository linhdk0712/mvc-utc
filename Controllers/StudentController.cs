using Microsoft.AspNetCore.Mvc;
using mvc_etc.Models;

namespace mvc_etc.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;
    private readonly List<Student> _students = new List<Student>();

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
        _students.Add(
            new Student
            {
                Id = 1, 
                Name = "John", 
                Branch = Branch.IT,
                Gender = Gender.Male, 
                Address = "Kathmandu", 
                DateOfBird = new DateTime(1999, 12, 12), 
                Email = "john@gmail.com", 
                IsRegular = true, 
                Password = "123456"
            });
        _students.Add(
            new Student
            {
                Id = 2, 
                Name = "Mary", 
                Branch = Branch.BE,
                Gender = Gender.Female, 
                Address = "Harisiddhi", 
                DateOfBird = new DateTime(1998, 11, 12), 
                Email = "mary@gmail.com", 
                IsRegular = true, 
                Password = "123456"
            });
        _students.Add(
            new Student
            {
                Id = 1, 
                Name = "Gopal", 
                Branch = Branch.CE,
                Gender = Gender.Male, 
                Address = "Ason", 
                DateOfBird = new DateTime(1999, 12, 12), 
                Email = "gopal@gmail.com", 
                IsRegular = true, 
                Password = "123456"
            });
    }

    public IActionResult Index()
    {
        return View(_students);
    }

}