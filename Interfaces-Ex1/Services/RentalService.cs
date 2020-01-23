using System;
using System.Collections.Generic;
using System.Text;



namespace InterfacesClass
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerday { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();


        public RentalService(double pricePerHour, double pricePerday)
        {
            PricePerHour = pricePerHour;
            PricePerday = pricePerday;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerday * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }

    }
}
