using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Movie : ProductType, Product
    {
        string type;
        double cost;
        int quantity;
        string language;

        public Movie()
        {
            type = "Movie";
            cost = 1800.50;
            quantity = 5;
            language = "fr";
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
