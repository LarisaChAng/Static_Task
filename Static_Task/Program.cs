using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Методы определяют: длину и площадь окружности; принадлежность точки кругу
            Console.WriteLine("Введите радиус и координаты центра окружности:");
            double r = Convert.ToDouble(Console.ReadLine());

            double x0 = Convert.ToDouble(Console.ReadLine());            
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            double length = Circle.GetLength(r);
            double square = Circle.GetSquare(r);            
            string areaPoint = Circle.GetAreaPoint(r, x0, y0, x1, y1);

            Console.WriteLine($"Длина = {length:f2} \nПлощадь = { square:f2} \n{ areaPoint}");            
            Console.ReadKey();
        }
    }
}
