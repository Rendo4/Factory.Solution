using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;
using System;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle ="Home";
        ViewBag.Tab="home";
        ViewBag.DateTime= DateTime.Now;
        List<MachineEngineer> model = _db.MachineEngineer.ToList();
        return View(model);
      }

    }
}