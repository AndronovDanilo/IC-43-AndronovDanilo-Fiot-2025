using Microsoft.AspNetCore.Mvc;

namespace MyHotelApi.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}