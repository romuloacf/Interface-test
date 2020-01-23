using System;
using System.Collections.Generic;

using System.Globalization;
using InterfacesClass;

namespace Interfaces_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter Rental Data:");

            Console.Write("Car Model:");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Vehicle vehicle = new Vehicle(model);
            CarRental carRental = new CarRental(start, finish, vehicle);
            //CarRental carRental = new CarRental(start, finish, new Vehicle(model));


            Console.WriteLine("Enter price per hour:");
            double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter Price per day:");
            double dayPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(hourPrice, dayPrice);

            Console.WriteLine("INVOICE:");

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine(carRental.Invoice);


            





        }
    }
}
