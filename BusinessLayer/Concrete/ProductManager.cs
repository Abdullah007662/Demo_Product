using BusinessLayer.Abstract;
using DataAccessLayer.Abstruct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IGenericService<Product>
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)  
        {
            _productDal.İnsert(t);
            //if(t.ProductName.Length>=5 && t.ProductPrice>=1&& t.ProductName != null)
            //{
            //    _productDal.İnsert(t);

            //}
            //else
            //{
            //    //Hata Mesajları
            //}
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
