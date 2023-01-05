using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS_website.Models;

namespace CS_website.Controllers;

public class CurriculumController : Controller
{
    private readonly ILogger<CurriculumController> _logger;

    public CurriculumController(ILogger<CurriculumController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}