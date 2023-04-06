using Microsoft.EntityFrameworkCore;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PierresTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatsContext _db;

    public TreatsController(TreatsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}