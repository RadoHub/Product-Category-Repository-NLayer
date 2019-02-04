using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> FillCbxProductCategory();
    }
}
