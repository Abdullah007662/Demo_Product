using DataAccessLayer.Abstruct;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfCostomerDal : GenericRepository<Costomer>, ICostomerDal
    {
        public List<Costomer> GetCostomerListWithJob()
        {
            using (var c = new Context())
            {
                return c.costomers.Include(x => x.Job).ToList();
            }
        }
    }
}
