using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrainingCSharp.Models;
using TrainingCSharp.Repositories;

namespace TrainingCSharp.Controllers;

public class DeliveryController : Controller
{
    private readonly ILogger<DeliveryController> _logger;
    private readonly IDeliveryRepository _deliveryRepository;

    public DeliveryController(IDeliveryRepository deliveryRepository)
    {
         _deliveryRepository = deliveryRepository;
    }

    public IActionResult IndexDeliverySearch()
    {
        var deliveries = _deliveryRepository.SearchDeliveries(
            "", "", "", "", "", "", "", "", 1, 50, 1
        );

        return View(deliveries);
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
