using Microsoft.AspNetCore.Mvc;
using BakeryVendorsOrders.Models;

namespace BakeryVendorsOrders.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}