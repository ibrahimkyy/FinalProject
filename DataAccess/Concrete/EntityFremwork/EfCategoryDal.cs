﻿using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFremwork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NortwindContext>, ICategoryDal
    {
        
    }
}
