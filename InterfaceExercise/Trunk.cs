namespace InterfaceExercise;

public class Trunk : IVehicle , ICompany
{
    public bool HasTrunkBed { get; set; }
    public int TrunkBedSpace { get; set; }
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool IsHybrid { get; set; }
    public bool IsAutodrive { get; set; }
   

    public string Logo { get; set; }
    public string Headquaters { get; set; }
}