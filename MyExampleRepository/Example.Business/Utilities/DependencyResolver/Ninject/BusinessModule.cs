using Example.Business.Abstract;
using Example.Business.Concrete;
using Example.DataAccess.Abstract;
using Example.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Business.Utilities.DependencyResolver.Ninject
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManagement>();
            Bind<IProductDA>().To<EFProductDA>();

            Bind<ICategoryService>().To<CategoryManagement>();
            Bind<ICategoryDA>().To<EFCategoryDA>();
        }
    }
}
