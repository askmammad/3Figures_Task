using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Figures_Task
{
    public class Cone: Cylinder
    {
        protected double length;
        public Cone(double radius, double height, double length)
            : base(radius, height)
        {
            Length = length;
        }
        public double Length
        {
            get
            {
                return length;

            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("This figure cannot be less than 0");
                }
                length = value;
            }
        }
        public override double Area()
        {
            double area = Math.PI * a * (a + length);
            return area;
            
        }
        public override double Volume()
        {
            double volume = (Math.PI * a * a * b)/3;
            return volume;
        }
    }
}
