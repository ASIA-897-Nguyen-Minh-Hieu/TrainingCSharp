using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrainingCSharp.Models;

namespace TrainingCSharp.Controllers;

public class DeliveryController : Controller
{
    private readonly ILogger<DeliveryController> _logger;

    public DeliveryController(ILogger<DeliveryController> logger)
    {
        _logger = logger;
    }

    public IActionResult IndexDeliverySearch()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
