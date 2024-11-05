using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.İsim = values.KullanıcıAdı;
            userEditViewModel.Soyİsim = values.KullanıcıSoyadı;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Cinsiyet = values.Cinsiyet;

            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.KullanıcıAdı = p.İsim;
            user.KullanıcıSoyadı = p.Soyİsim;
            user.Email = p.Mail;
            user.Cinsiyet = p.Cinsiyet;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Şifre);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                //Hata Mesajları
            }
                 

            return View();
        }
    }
}
