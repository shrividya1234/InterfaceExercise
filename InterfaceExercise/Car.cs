namespace InterfaceExercise;

public class Car : IVehicle , ICompany
{
    public bool Trunk { get; set; }
    public int TrunkSpace { get; set; }
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool IsHybrid { get; set; }
    public bool IsAutodrive { get; set; }
   
    public string Logo { get; set; }
    public string Headquaters { get; set; }
}