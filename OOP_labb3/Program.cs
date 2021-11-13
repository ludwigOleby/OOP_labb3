using System;

namespace OOP_labb3
{
    class Program
    {
        static void Main(string[] args)
        {

            Teckning T1 = new Cirkel();
            Console.WriteLine("Area cirkel: " + T1.Area());  
            Teckning T2 = new Fyrkant();
            Console.WriteLine("Area fyrkant: " + T2.Area());
            Teckning T3 = new rektangel();
            Console.WriteLine("Area rektangel: " + T3.Area());


            Console.ReadKey();
        }
    }
}
