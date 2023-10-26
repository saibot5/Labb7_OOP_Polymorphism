namespace Labb7_OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public int a { get; set; }
        public int b { get; set; }

        public Ellips()
        {
            a = 5;
            b = 4;
        }
        public override double Area()
        {
            return Math.PI * a * b;
        }
    }

}
