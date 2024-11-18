using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using workshop.Dtos;
using workshop.Entities;
using workshop.Interfaces;

namespace workshop.Controllers
{
    public class RegController : Controller
    {
        private readonly mvcPortalContext _context;
        private IMapper _mapper;
        private IUserServices _userServices;
        public RegController(mvcPortalContext context, IMapper mapper,IUserServices userServices)
        {
            _context = context;
            _mapper = mapper;
            _userServices= userServices;
        }

        [HttpGet]
        public IActionResult DisplayForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayForm(UserDto user)
        {
            var addUser = _mapper.Map<User>(user);
            var res = _userServices.RegisterService(addUser);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(String email, String password)
        {
            var newLog = _context.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if(newLog != null)
            {
                HttpContext.Session.SetString("email",email);
                return RedirectToAction("First","Landing");
            }
            return View();
        }
    }
}
