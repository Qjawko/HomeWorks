using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ермагамбет Темирлан");

            Console.WriteLine("Введите первое число");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = Int32.Parse(Console.ReadLine());

            Console.Write("Сумма равна = ");
            Console.WriteLine(a+b);

            Console.ReadLine();
        }
    }
}
