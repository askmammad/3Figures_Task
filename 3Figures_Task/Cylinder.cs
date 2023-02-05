using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Figures_Task
{
    public class Cylinder : Figures
    {
        public Cylinder(double radius, double height) 
            :base(radius, height)
        {
        }
        public override double Area()
        {
            double area = Math.PI * 2 * a * (a + b);
            return area;
        }
        public override double Volume()
        {
            double volume = Math.PI * a * a * b;
            return volume;
        }
    }
}
