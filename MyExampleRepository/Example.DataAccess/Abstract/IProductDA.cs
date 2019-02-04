using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DataAccess.Abstract
{
    public interface IProductDA: IRepository<Product>
    {
    }
}
