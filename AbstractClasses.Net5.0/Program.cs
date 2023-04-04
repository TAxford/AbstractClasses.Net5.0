using System;

namespace AbstractClasses.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes) 
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                Cube IceCube = shape as Cube;
                if (IceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This Shape is a cube");
                }
            }
        }
    }
}
