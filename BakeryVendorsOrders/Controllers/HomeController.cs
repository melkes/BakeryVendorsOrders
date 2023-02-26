using Microsoft.AspNetCore.Mvc;
using BakeryVendorsOrders.Models;

namespace BakeryVendorsOrders.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Vendor myVendor = new Vendor("Add new Vendor name");
      return View(myVendor);
    }

  }
}