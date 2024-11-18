using Microsoft.AspNetCore.Mvc;
using workshop.Dtos;
using workshop.Entities;
using workshop.Migrations;

namespace workshop.Controllers
{
    public class ProfileController : Controller
    {
        private readonly mvcPortalContext _context;
        public ProfileController(mvcPortalContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ViewProfile()
        {
            var SessionReceieved = HttpContext.Session.GetString("email");
            ViewBag.sessionEmail = SessionReceieved;
            //var cs = HttpContext.Session.SetString
            var logged = _context.Users.Where(x => x.Email == SessionReceieved).FirstOrDefault();
            return View(logged);
        }
        [HttpGet]
        public IActionResult EditProfile()
        {
            var SessionRec = HttpContext.Session.GetString("email");
            var JobRec = _context.Users.Where(x => x.Email == SessionRec).FirstOrDefault();
            return View(JobRec);
        }
        [HttpPost]
        public IActionResult EditProfile(User userChanges)
        {
            if(userChanges == null)
            {
               return RedirectToAction("ViewProfile");
            }
            var existingUser = _context.Users.Find(userChanges.Id);
            if (existingUser != null)
            {
            existingUser.Email = userChanges.Email;
            existingUser.Name = userChanges.Name;
            existingUser.Password = userChanges.Password;
            existingUser.Location = userChanges.Location;
            existingUser.confirmPassword = userChanges.confirmPassword;
            _context.Users.Update(existingUser);
            _context.SaveChanges();
            return RedirectToAction("First","Landing");
            }
            else
            {
                return RedirectToAction("ViewProfile");
            }
        }


    }
}
