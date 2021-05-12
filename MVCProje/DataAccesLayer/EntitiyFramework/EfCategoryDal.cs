using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntitiyFramework
{
    public class EfCategoryDal:GenericRepository<Category>, ICategoryDal
    {

    }
}
