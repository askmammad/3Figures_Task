using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Figures_Task
{
    internal class Parallelepiped : Cone
    {
        public Parallelepiped(double a, double b, double c)
            : base(a, b, c)
        {
        }
        public override double Area()
        {
            double area = 2 * (a * b + a * length + b * length);
            return area;

        }
        public override double Volume()
        {
            double volume = a * b * length;
            return volume;
        }
    }
}
