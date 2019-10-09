using System;

namespace Задание__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Присвоение");
            string str = Console.ReadLine();
            double x = Convert.ToDouble(str);
            int d = (int)(x - (int)x) * 10;
            Console.WriteLine("d=" + d);          
        }
    }
}
