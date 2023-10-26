namespace Labb7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintGeometri();
        }

        private static void PrintGeometri()
        {
            List<Geometri> Shapes = new List<Geometri>() {new Cirkel(), new Ellips(), new Fyrkant(), new Parallellogram(), new Rektangel()};

            foreach (Geometri shape in Shapes)
            {
                shape.PrintArea();
            }

            
        }
    }
}