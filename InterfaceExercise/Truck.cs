using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool HasTrailer { get; set; }
    public void Drive()
    {
        Console.WriteLine($"Driving in my {GetType().Name}");
    }

    public string Logo { get; set; }
    public DateTime DataEstablished { get; set; }
}