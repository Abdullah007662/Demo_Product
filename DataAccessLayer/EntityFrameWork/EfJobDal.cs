﻿using DataAccessLayer.Abstruct;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfJobDal:GenericRepository<Job>,IJobDal
    {
    }
}
