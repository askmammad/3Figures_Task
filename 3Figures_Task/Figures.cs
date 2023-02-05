using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3Figures_Task
{
    public abstract class Figures
    {
        protected double a;
        protected double b;

        public Figures (double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        public double SideA
        {
            get
            {
                return a;

            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("This figure cannot be less than 0");
                }
                a = value;
            }
        }
        public double SideB
        {
            get
            {
                return b;

            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("This figure cannot be less than 0");
                }
                b = value;
            }
        }

        public abstract double Area();
        public abstract double Volume();
    }
}
