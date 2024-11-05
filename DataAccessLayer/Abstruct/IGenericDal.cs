using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstruct
{
    public interface IGenericDal<T> where T : class
    {
        void İnsert(T t);
        void Delete(T t);
        void Update(T t);

        List<T> GetList();
        T GetById(int id);
    }
}
