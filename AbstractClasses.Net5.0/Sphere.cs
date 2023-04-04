using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractClasses.Net5._0
{
    internal class Sphere : Shape
    {
        //property
        public double Length { get; set; }

        //Constructor
        public Sphere(double length)
        {
            Name = "Sphere";
            Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a length of {Length}");
        }
    }
}
