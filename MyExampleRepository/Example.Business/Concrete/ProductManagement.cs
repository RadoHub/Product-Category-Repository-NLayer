using Example.Business.Abstract;
using Example.DataAccess.Abstract;
using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Business.Concrete
{

    public class ProductManagement : IProductService
    {
        private IProductDA _iProductDA;
        public ProductManagement(IProductDA iProductDA)
        {
            _iProductDA = iProductDA;
        }
        public void AddProduct(Product product)
        {
            _iProductDA.Add(product);
        }

        public List<Product> FillDgwProduct()
        {
            return _iProductDA.GetAll();
        }
    }
}
