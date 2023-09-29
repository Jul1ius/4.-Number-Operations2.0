using System;
using System.Runtime.Serialization;

namespace _4._Number_Operations2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (op == "+")
                total = n1 + n2;
            else if (op == "-")
                total = n1 - n2;
            else if (op == "*")
                total = n1 * n2;
            else if (op == "/")
                total = n1 / n2;

            Console.WriteLine($"{n1} {op} {n2} = {total:f2}");
        }
    }
}
