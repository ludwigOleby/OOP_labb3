using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb3
{

    public class Cirkel : Teckning
    {
        public double Radius { get; set; }

        public double Pi = 3.14;

        public Cirkel()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return (Radius * Radius) * Pi;
        }

    }
}


    

       
          
