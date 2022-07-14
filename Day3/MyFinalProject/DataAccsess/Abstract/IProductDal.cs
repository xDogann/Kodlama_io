using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    // Interface - Product Table - Data Access Layer
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
