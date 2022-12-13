using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP4.Data;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Debug.WriteLine("Here" + UniversityContext.Instance);
        Debug.WriteLine("Here" + UniversityContext.Instance);
        List<Student> s = UniversityContext.Instance.Student.ToList();
        Debug.WriteLine(s);
        return View();
    }

    public IActionResult Privacy()
    {
        Debug.WriteLine("Meow");
        Debug.WriteLine("Here" + UniversityContext.Instance);
        Debug.WriteLine("Here" + UniversityContext.Instance);
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
