using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb3
{
    public class Fyrkant : Teckning
    {
        public double sida { get; set; }
        public Fyrkant()
        {
            sida = 5;
        }

        public override double Area()
        {
            return sida * sida;
        }
    }
}
