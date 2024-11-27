using ConsoleAppGitHub1.Operations;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a,b,c;
            Console.WriteLine("Enter a value  :  ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b value  :  ");
            b = Convert.ToInt32(Console.ReadLine());

            AirthamaticOperations obj = new AirthamaticOperations();

            c = obj.Add(a, b);
            Console.WriteLine("The sum is :" + c);

            c = obj.sub(a, b);
            Console.WriteLine("The sub is :" + c);




            Console.WriteLine("Program Completed...!");

            Console.ReadKey();
        }
    }
}
