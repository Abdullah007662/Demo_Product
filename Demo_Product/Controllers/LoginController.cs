using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace Demo_Product.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(UserLoginViewModel p)
        {
            /// GİRİŞ YAPMADAN ŞİFRE DEĞİŞTİRME İŞLEMİ YAPILAMAZ ONUN YÜZÜNDEN NULL DEGER HATASI ALIRSIN DİKKAT ET ÖZELLİKLE DE SETTİNG NULL DEGER GİDER
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.KullaniciAdi, p.KullaniciŞifre, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı Veya Şifre");
                }
            }
            
            return View();
        }
      
    }
}
