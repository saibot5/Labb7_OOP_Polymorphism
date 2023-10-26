namespace Labb7_OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public int lenght { get; set; }
        public int breadth { get; set; }
        public Rektangel()
        {
            lenght = 4;
            breadth = 6;
        }

        public override double Area()
        {
           return lenght * breadth;
        }
    }

}
