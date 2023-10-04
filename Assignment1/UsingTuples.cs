using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class UsingTuples
    {
        public (string name, int age, string email , int salary, double bonusPercent, double total) getUserInfo()
        {
            string name = "Ram";
            int age = 25;
            string email = "ram@gmail.com";
            int salary = 25000;
            double bonusPercent = 13.5;
            double total = salary + (salary * bonusPercent) / 100;


            return (name, age, email, salary, bonusPercent, total);
        }
    }
}
