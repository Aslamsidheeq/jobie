using Microsoft.AspNetCore.Mvc;
using workshop.Entities;

namespace workshop.Controllers
{
    public class LandingController : Controller
    {
        private readonly mvcPortalContext _context;

        public LandingController(mvcPortalContext context)
        {
            _context = context;
        }
        public IActionResult First()
        {
            var email = HttpContext.Session.GetString("email");
            if (email == null)
            {
                return RedirectToAction("Login");
            }
            List<Job> jobsList = new List<Job>();
            jobsList = _context.Jobslist.ToList();
            return View(jobsList);
        }
    }
}
