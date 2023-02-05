namespace _3Figures_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1: Console.WriteLine("Please choose the figure type and click corresponding number:\n1.Cone\n2.Cylinder\n3.Parallelepiped\n");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Please insert the radius of Cone: ");
                double radiusCone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the height of Cone: ");
                double heightCone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the length of Cone: ");
                double lengthCone = Convert.ToInt32(Console.ReadLine());
                Cone cone = new Cone(radiusCone, heightCone, lengthCone);
                Console.WriteLine($"Area of Cone: {cone.Area()}");
                Console.WriteLine($"Volume of Cone: {cone.Volume()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else if (x == 2)
            {
                Console.WriteLine("Please insert the radius of Cylinder: ");
                double radiusCylinder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the height of Cylinder: ");
                double heightCylinder = Convert.ToInt32(Console.ReadLine());
                Cylinder cylinder = new Cylinder(radiusCylinder, heightCylinder);
                Console.WriteLine($"Area of Cylinder: {cylinder.Area()}");
                Console.WriteLine($"Volume of Cylinder: {cylinder.Volume()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else if (x == 3)
            {
                Console.WriteLine("Please insert the one side of Parallelepiped: ");
                double sideAParallelepiped = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert another side of Parallelepiped: ");
                double sideBParallelepiped = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert the height of Parallelepiped: ");
                double heightParallelepiped = Convert.ToInt32(Console.ReadLine());
                Parallelepiped parallelepiped = new Parallelepiped(sideAParallelepiped, sideBParallelepiped, heightParallelepiped);
                Console.WriteLine($"Area of Parallelepiped: {parallelepiped.Area()}");
                Console.WriteLine($"Volume of Parallelepiped: {parallelepiped.Volume()}");
                Console.WriteLine("---------------------\n");
                goto l1;
            }
            else
            {
                Console.WriteLine("Wrong number inserted\n");
                goto l1;
            }
        }
    }
}