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
    public class CostomerManager : IGenericService<Costomer>
    {
        ICostomerDal _costomerDAl ;

        public CostomerManager(ICostomerDal costomerDAl)
        {
            _costomerDAl = costomerDAl;
        }

        public List<Costomer> GetCostomersListWith()
        {
            return _costomerDAl.GetCostomerListWithJob();
        }

        public void TDelete(Costomer t)
        {
            _costomerDAl.Delete(t);
        }

        public Costomer TGetById(int id)
        {
            return _costomerDAl.GetById(id);
        }

        public List<Costomer> TGetList()
        {
            return _costomerDAl.GetList();
        }

        public void TInsert(Costomer t)
        {
            _costomerDAl.İnsert(t);
        }

        public void TUpdate(Costomer t)
        {
            _costomerDAl.Update(t);
        }
    }
}
