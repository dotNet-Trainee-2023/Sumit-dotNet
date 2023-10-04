using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TernaryNullCoalescing
    {
        public void TernaryOperator()
        {
            int number;
            Console.WriteLine("Enter number : ");
            number = int.Parse(Console.ReadLine());

            string numberType = (number % 2 == 0) ? "Even": "Odd";

            Console.WriteLine($"Number is {numberType}");

        }

        public void NullCoalescingOperator()
        {
            string? str1 = null;
            Console.WriteLine("String 1 is " + str1);

            string str2 = "Sample string";
            Console.WriteLine("String 2 is "+ str2);

            string str3 = str1 ?? "Sample string in null case";

            Console.WriteLine("Assigned value if string 3 is null: " + str3);

            Console.WriteLine($"String 1: {str1},  String 2: {str2}, String 3: {str3}");
        
        }

    }
}
