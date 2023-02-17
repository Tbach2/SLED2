using Microsoft.AspNetCore.Mvc;

namespace SLED2.Controllers;

public class AdminController : Controller
{
    // GET
    public ActionResult AdminDashboard()
    {
        return View();
    }
}