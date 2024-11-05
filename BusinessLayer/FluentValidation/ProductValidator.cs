using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Geçilmez").MinimumLength(3).WithMessage("Ürün Adı Minimum 3 Karakter Olmalıdır");

            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Stok Kısmı Boş Geçilemez");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Fiyat Kısmı Boş Geçilemez");
        }
       
    }
}
