using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Parsing
    {
        public void parsing()
        {
            string number;
            Console.WriteLine("Enter number");
            number = Console.ReadLine();

            int parsedNum = int.Parse(number);
            Console.WriteLine("Parsed number (int from string): ", parsedNum);
        }

        public void tryParsing()
        {
            string number2;
            Console.WriteLine("Enter number");
            number2 = Console.ReadLine();

            int parsedNum2;

            if(int.TryParse(number2, out parsedNum2) )
            {
                Console.WriteLine($"Number {number2} parsed successfully");
            }
            else
            {
                Console.WriteLine($"Parsing {number2} failed");
            }


        
        }


    }
}
