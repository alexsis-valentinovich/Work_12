using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    static class Cycle
    {
        static public double GetlengthCycle(double r)
        {
            return 2 * Math.PI * r;
        }
        static public double GetsquareCycle(double r)
        {
            return Math.PI * r * r;
        }
        static public string Getposition(double x, double y, double x0, double y0, double r0)
        {
            if ((x - x0) * (x - x0) + (y - y0) * (y - y0) <= (r0 * r0))
            {
                if ((x - x0) * (x - x0) + (y - y0) * (y - y0) == (r0 * r0))
                {
                    return "Точка находится на окружности";
                }
                else
                {
                    return "Точка находится внутри окружности";
                }
            }
            else
            {
                return "Точка находится снуружи окружности";
            }
        }
    }
}
