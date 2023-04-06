using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PierresTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresTreats.Controllers;

public class HomeController : Controller
{
    private readonly TreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, TreatsContext db)
    {
        _userManager = userManager;
        _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] trt = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", trt);
      model.Add("flavors", flavors);
      return View(model);
    }
  }

