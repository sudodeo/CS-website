using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CS_website.Models;

namespace CS_website.Controllers;

public class StdAssociationController : Controller
{
    private readonly ILogger<StdAssociationController> _logger;

    public StdAssociationController(ILogger<StdAssociationController> logger)
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
