namespace Labb7_OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public int side { get; set; }

        public Fyrkant()
        {
            side = 5;
        }

        public override double Area()
        {
            return side * side;
        }
    }

}
