using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class ProductType
    {

        const string type = "All product type";

        public virtual void ProductTypeInfo()
        {
            Console.WriteLine($"This product type includes {type}");
        }
        
    }
}
