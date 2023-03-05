using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BakeryVendorsOrders.Models;

namespace BakeryVendorsOrders.Controllers
{
  public class VendorController : Controller
  {
     [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    
  }

}
