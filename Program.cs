using System;

namespace Averagely
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("A program that calculates the average of your grades in five subjects.");

            Console.Write("Enter your English grades:");
            double english = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your history grades:");
            double history = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your math grades:");
            double math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Computer Science grades:");
            double computerScience = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your biology grades:");
            double biology = Convert.ToDouble(Console.ReadLine());

            double average = (english + history + math + computerScience + biology)/5;
            Console.WriteLine($"\n Result:>>> {average}");
        }
    }
}