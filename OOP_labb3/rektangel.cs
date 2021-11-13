using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_labb3
{
    public class rektangel : Teckning 
    {

        public double bas { get; set; }
        public double höjd{ get; set; }
        public rektangel()
        {
            bas = 5;
            höjd = 10;
        }

        public override double Area()
        {
            return (bas * höjd);
        }
    }
}
