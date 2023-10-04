using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Book : ProductType, Product
    {
        string type;
        double cost;
        int quantity;
        string language;

        public Book()
        {
            type = "Book";
            cost = 1200.50;
            quantity = 10;
            language = "en";
        }

        public override void ProductTypeInfo()
        {
            Console.WriteLine($"This product type includes {type}");
        }

        public double getPrice()
        {
            
            return (quantity * cost);
        }

        public string getLanguageInfo()
        { 
            return language;    
        }


        
    }
}
