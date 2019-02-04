using Example.DataAccess.Abstract;
using Example.DataAccess.Concrete.EntityFramework.EFBase;
using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDA: EFBaseRepository<Category, ExampleDataContext>, ICategoryDA
    {
    }
}
