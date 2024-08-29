namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public bool HasTruckBed { get; set; } = true;
    public int NumberOfTires { get; set; }
    public int Year { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool WebPage { get; set; }
    public int AgeOfCompany { get; set; }
}