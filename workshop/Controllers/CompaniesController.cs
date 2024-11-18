using Microsoft.AspNetCore.Mvc;

namespace workshop.Controllers
{
    public class CompaniesController : Controller
    {
        public IActionResult GeCompaniestList()
        {
            return View();
        }
    }
}
