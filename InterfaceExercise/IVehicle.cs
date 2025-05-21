using System;

namespace InterfaceExercise;

public interface IVehicle
{
    string Year { get; set; }
    string Make { get; set; }
    string Model { get; set; }
    void Drive();

    void DriveDefault()
    {
        Console.WriteLine("Default drive method inside interface");
    }
}

