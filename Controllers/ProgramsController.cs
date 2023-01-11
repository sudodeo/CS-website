using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS_website.Models;

namespace CS_website.Controllers;

public class ProgramsController : Controller
{
    private readonly ILogger<ProgramsController> _logger;

    public ProgramsController(ILogger<ProgramsController> logger)
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
