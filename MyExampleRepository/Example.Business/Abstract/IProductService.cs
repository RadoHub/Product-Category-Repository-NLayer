using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Entitiy.Concrete;

namespace Example.Business.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> FillDgwProduct();
    }
}
