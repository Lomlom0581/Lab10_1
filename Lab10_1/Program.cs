using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Программа переводит угол из градусов в радианы.");

            Console.Write("Введите градусы:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды:");
            int s = int.Parse(Console.ReadLine());

            try
            {                
                Angle a = new Angle(d, m, s);
                Console.WriteLine($"Получилось {a}, это {a.ToRad()} радиан.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
