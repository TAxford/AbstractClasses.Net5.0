using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Net5._0
{
    internal class Cube : Shape
    {
        //property
        public double Length { get; set; }

        //Constructor
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"\n This is a {Name}");
        }
    }
}
