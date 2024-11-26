using System.Drawing;

namespace InterfaceExercise;

public class SUV : IVehicle,ICompany
{
    public int Row { get; set; }
    public int CargoSpace { get; set; }
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool IsHybrid { get; set; }
    public bool IsAutodrive { get; set; }
  
    public string Logo { get; set; }
    public string Headquaters { get; set; }
}