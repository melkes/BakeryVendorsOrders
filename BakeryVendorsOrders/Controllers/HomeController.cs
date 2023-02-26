using Microsoft.AspNetCore.Mvc;
using BakeryVendorsOrders.Models;

namespace BakeryVendorsOrders.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Vendor myVendor = new Vendor("Add new Vendor name", "Add a new Vendor description");
      return View(myVendor);
    }

  }
}