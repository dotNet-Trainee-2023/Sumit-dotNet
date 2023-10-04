

namespace Assignment1
{
    public class Program
    {
        public static void Main(String []args)
        {

            string bookLanguage, movieLanguage;
            double bookCost, movieCost;

            // Using tuples
            Console.WriteLine("Using Tuples: ");

            UsingTuples tupleObj = new UsingTuples();

            var tupleVar = tupleObj.getUserInfo();

            string name = tupleVar.name;
            int age = tupleVar.age;
            string email = tupleVar.email;
            int salary = tupleVar.salary;
            double bonusPercent = tupleVar.bonusPercent;
            double total = tupleVar.total;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Email:  {email}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Bonus percent: {bonusPercent}");
            Console.WriteLine($"Total amount: {total}");


            Console.WriteLine();
            Console.WriteLine("Using LINQ");

            UsingLINQ usingLINQobj = new UsingLINQ();
            usingLINQobj.UsingLinq();

            Console.WriteLine();

            Console.WriteLine("Inheritance");
            Book bookObj = new Book();
            bookObj.ProductTypeInfo();
            bookCost = bookObj.getPrice();
            Console.WriteLine("Book Cost: "+ bookCost);

            bookLanguage = bookObj.getLanguageInfo();
            Console.WriteLine("Book language: "+ bookLanguage);


            Movie movieObj = new Movie();
            movieObj.ProductTypeInfo();
            movieCost = movieObj.getPrice();
            Console.WriteLine("Movie Cost: " + movieCost);

            movieLanguage = movieObj.getLanguageInfo();
            Console.WriteLine("Movie language: " + movieLanguage);

            Console.WriteLine();
            Console.WriteLine("Parsing example");

            Parsing parsingObj = new Parsing();

            parsingObj.parsing();
            parsingObj.tryParsing();

            Console.WriteLine();

            Console.WriteLine("Ternary and null coalescing operators example");

            TernaryNullCoalescing terNullCoalesObj = new TernaryNullCoalescing();

            terNullCoalesObj.TernaryOperator();
            terNullCoalesObj.NullCoalescingOperator();

            Console.WriteLine() ;

        }

    }

}