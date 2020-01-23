﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InterfacesClass
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }


        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment" +
                BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +
                "\n Tax" +
                Tax.ToString("F2", CultureInfo.InvariantCulture) +
                "\n Total Payment:" +
                TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
