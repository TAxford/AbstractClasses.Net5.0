using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Net5._0
{
    abstract class Shape
    {
        //property
        public string Name { get; set; }
        
        //Constructor
        public virtual void GetInfo() 
        {
            Console.WriteLine($"\n This is a {Name}");
        }

        //method
        public abstract double Volume();

    }
}
