using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SystemIdentity.Areas.Identity.Data;
using SystemIdentity.Data;
using SystemIdentity.Models;

namespace SystemIdentity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly SystemIdentityContext _context;

    public HomeController(ILogger<HomeController> logger, SystemIdentityContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        SystemUser user = _context.Users
            .Include(c => c.MyCar)      //toto pripojuje uzivateli jeho zavisla data podle 1:n (left join)
            .FirstOrDefault(u=> u.Email == User.Identity.Name);
        ViewBag.User = user;
        return View();
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
