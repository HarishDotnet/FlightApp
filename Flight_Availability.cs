using System;
using System.Collections.Generic;
using System.Dynamic;

public class Flight
{
    public string FlightNumber { get; set; }
    public string Airline { get; set; }
    public string DepartureTime { get; set; }
    public string ArrivalTime { get; set; }
    public decimal Price { get; set; }

    public Flight(string flightNumber, string airline, string departureTime, string arrivalTime, decimal price)
    {
        FlightNumber = flightNumber;
        Airline = airline;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        Price = price;
    }
}

public class FlightAvailabilityChecker
{
    public static DateTime Getdate(){
        DateTime departureDate;
        while (!DateTime.TryParse(Console.ReadLine(), out departureDate))
        {
            Console.Write("Invalid date format. Please enter a valid date (yyyy-mm-dd): ");
        }
        return departureDate;
    }
    public String hr="harsih";
        // Simulated list of flights (no external API)
    private static List<Flight> availableFlights = new List<Flight>
    {
        new Flight("AA123", "American Airlines", "2024-12-15 08:00", "2024-12-15 12:00", 250.00m),
        new Flight("DL456", "Delta Airlines", "2024-12-15 10:00", "2024-12-15 14:00", 275.00m),
        new Flight("UA789", "United Airlines", "2024-12-15 14:00", "2024-12-15 18:00", 300.00m),
        new Flight("SW101", "Southwest Airlines", "2024-12-15 16:00", "2024-12-15 20:00", 225.00m)
    };

    public static void CheckFlightAvailability(string from, string to, DateTime departureDate)
    {
        Console.WriteLine($"Searching flights from {from} to {to} on {departureDate.ToShortDateString()}...\n");

        bool flightFound = false;
        string ch="n";
        // Simulate checking flights
        do{
            if(ch.Equals("y")){
            Console.Write("Enter departure date (yyyy-mm-dd): ");
            departureDate=Getdate();
            ch="n";
            }
        foreach (var flight in availableFlights)
        {
            // For this example, we assume all flights are available for the selected date and location
            if (flight.DepartureTime.StartsWith(departureDate.ToString("yyyy-MM-dd")))
            {
                flightFound = true;
                Console.WriteLine($"Flight: {flight.FlightNumber}");
                Console.WriteLine($"Airline: {flight.Airline}");
                Console.WriteLine($"Departure: {flight.DepartureTime}");
                Console.WriteLine($"Arrival: {flight.ArrivalTime}");
                Console.WriteLine($"Price: ${flight.Price}");
                Console.WriteLine("-----------------------------------------");
            }
        }

        if (!flightFound)
        {
            Console.WriteLine("No flights found for the selected criteria.\n press y for try diff date.");
            ch=Console.ReadLine();
            
        }
    }while(ch.ToLower().Equals("y"));
    }
    public FlightAvailabilityChecker()
    {
        // Sample input from user
        Console.Write("Enter departure location: ");
        string from = Console.ReadLine();

        Console.Write("Enter destination location: ");
        string to = Console.ReadLine();

        Console.Write("Enter departure date (yyyy-mm-dd): ");
        DateTime departureDate;
        departureDate=Getdate();

        // Check flight availability
        CheckFlightAvailability(from, to, departureDate);
    }
}
