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
    public class CategoryManagement : ICategoryService
    {
        private ICategoryDA _iCAtegoryDA;
        public CategoryManagement(ICategoryDA iCategoryDA)
        {
            _iCAtegoryDA = iCategoryDA;
        }
        public List<Category> FillCbxProductCategory()
        {
            return _iCAtegoryDA.GetAll();
        }
    }
}
