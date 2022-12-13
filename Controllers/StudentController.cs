using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    StudentRepository studentRepository;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;

        studentRepository = new StudentRepository();
    }

    public IActionResult Index()
    {

        Debug.WriteLine("[+] All Students");
        var students = studentRepository.AllStudents();
        return View(students);
    }

    public IActionResult Courses()
    {
        Debug.WriteLine("[+] All Courses");
        var courses = studentRepository.AllCourses();

        return View(courses);
    }

    public IActionResult Course(string course)
    {
        Debug.WriteLine("[+] Course: " + course);
        var students = studentRepository.FindStudentByCourse(course);

        return View(students);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
