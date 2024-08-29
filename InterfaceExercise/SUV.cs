namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }
    public bool SeatCanBeRemoved { get; set; } = true;
    public int Year { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool WebPage { get; set; }
    public int AgeOfCompany { get; set; }
}