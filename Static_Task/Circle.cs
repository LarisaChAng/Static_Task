using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2 * r * Math.PI;
        }
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public string GetAreaPoint(double r, double x0, double y0, double x1, double y1)
        {
            double x = Math.Abs(x1 - x0);
            double y = Math.Abs(y1 - y0);

            if (x <= r && y <= r) 
                return "Точка внутри окружности";
            else
                return "Точка не внутри окружности";
        }
    }
}
