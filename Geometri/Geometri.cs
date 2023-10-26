using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    abstract internal class Geometri
    {
        public abstract double Area();

        public void PrintArea()
        {
            Console.WriteLine($"Area {GetType().Name} : {Area()}");
        }
    }

}
