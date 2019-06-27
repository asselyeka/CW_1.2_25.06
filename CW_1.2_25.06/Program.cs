using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.	Дан радиус окружности. Найти длину окружности и площадь круга.

namespace CW_1._2_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Double r, l, s;
            Console.WriteLine("Введите радиус окружности r:");
            string textAsNum = Console.ReadLine();
            r = int.Parse(textAsNum);
            l = 2 * Math.PI * r;
            s = Math.PI * r * r;
            Console.Write("Длину окружности круга: ");
            Console.WriteLine(l);
            Console.Write("Площадь круга: ");
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
