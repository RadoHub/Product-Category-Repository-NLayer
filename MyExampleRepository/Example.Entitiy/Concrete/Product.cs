using Example.Entitiy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Entitiy.Concrete
{
    public class Product: IEntity
    {
        //one to many relationship between product and category classes
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        public   Category CurrentCategory { get; set; }
    }
}
