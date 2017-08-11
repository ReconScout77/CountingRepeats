using Microsoft.AspNetCore.Mvc;
using RepeatFinder.Models;
using System.Collections.Generic;
using System;

namespace RepeatFinder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/results")]
    public ActionResult Results()
    {
      RepeatCounter repeats = new RepeatCounter(Request.Form["find-this"], Request.Form["search-this"]);
      return View(repeats);
    }
  }
}
