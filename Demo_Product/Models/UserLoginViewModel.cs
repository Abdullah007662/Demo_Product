﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string? KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Giriniz")]
        public string? KullaniciŞifre { get; set; }
    }
}
