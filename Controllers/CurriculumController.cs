using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS_website.Models;
using CS_website.Data;

namespace CS_website.Controllers;

public class CurriculumController : Controller
{
    private readonly ILogger<CurriculumController> _logger;

    private readonly CourseContext _context;

    public CurriculumController(ILogger<CurriculumController> logger, CourseContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index(int? level)
    {          // Get all courses from the database
        var courses = _context.Course.OrderBy(c => c.code).ToList();
        // Console.WriteLine(level);
        // // Filter courses by year if year parameter is specified
        if (level.HasValue)
        {
            courses = courses.Where(c => c.level == level.ToString()).ToList();
        }

        // Pass the courses to the view
        return View(courses);

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
