namespace Labb7_OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 4;
        }


        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
