using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesClass
{
    class BrazilTaxService  
    {
         
        public double Tax(double ammount)
        {
            if (ammount <= 100.00){
                return ammount * 0.2;
            }
            else
            {
                return ammount * 0.15;
            }
        }



    }
}
