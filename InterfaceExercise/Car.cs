namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public bool HasTrunk { get; set; }
    public bool FoldingSeat { get; set; }
    public int Year { get; set; }
    public string Name { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool WebPage { get; set; }
    public int AgeOfCompany { get; set; }
}