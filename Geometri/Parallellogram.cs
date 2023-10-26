namespace Labb7_OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Parallellogram()
        {
            Base = 5;
            Height = 4;
        }
        public override double Area()
        {
            return Base * Height;
        }
    }

}
