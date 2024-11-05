using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CostomerValidator : AbstractValidator<Costomer>
    {
        public CostomerValidator()
        {
            RuleFor(x => x.CostomerNAme).NotNull().WithMessage("Kullanıcı Adı Boş Olama").MaximumLength(10).WithMessage("Kullanıcı Adı 10 Karakterden Fazla Olamaz ").MinimumLength(5).WithMessage("Kullanıcı Adı 5 Karakterden Az Olamaz ");
            RuleFor(x => x.CostomerCity).NotNull().WithMessage("Kullanıcı Şehri Boş Olamaz").MaximumLength(13).WithMessage("Kullanıcı Şehri Maximum 13 Karakter Olabilir").MinimumLength(3).WithMessage("Kullanıcı Şehri Minimum 3 Karakter Olabilir");
            
            
        }
    }
}
