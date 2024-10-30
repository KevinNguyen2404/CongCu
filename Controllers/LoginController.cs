using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using WebChordCore.Models;

namespace WebChordCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly HopAmChuanContext _context;

        public LoginController(HopAmChuanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var checkLogin = HttpContext.Session.GetInt32("isLogin");
            if (checkLogin != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(string TenTK, string TenMK)
        {
            var model = _context.Users.FirstOrDefault(t => t.UserName == TenTK && t.Password == TenMK);
            if (model != null)
            {
                HttpContext.Session.SetInt32("user", model.Id);
                HttpContext.Session.SetInt32("isLogin", 1);
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.ErrMess = "Tài Khoản Hoặc Mật Khẩu Không Đúng";
            return View("Index");
        }

        [CheckLoginUser]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
