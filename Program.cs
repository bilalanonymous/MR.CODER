using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        { double a = 5;
            double balance = 120;
            do
            {
                Console.WriteLine("input withdraw number that is multiple of 5 please");
                double x = Convert.ToDouble(Console.ReadLine());
                a = x;
            } while (a % 5 != 0);
            if (a < 120)
            {
                double withdraw = (balance - a) - 0.50;
                Console.WriteLine("your current balance is");
                Console.WriteLine(withdraw);
            }
            else
            {
                Console.WriteLine("your current balance is");
                Console.WriteLine(balance);
                Console.WriteLine("you can not withdraw");
            }

        }
    }
}
