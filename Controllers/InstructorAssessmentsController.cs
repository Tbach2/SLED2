using Microsoft.AspNetCore.Mvc;

namespace SLED2.Controllers;

public class InstructorAssessmentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public ActionResult Dashboard()
    {
        return View();
    }
}