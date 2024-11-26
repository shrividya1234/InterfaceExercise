namespace InterfaceExercise;

public interface IVehicle
{
    
    //In your IVehicle:
            
    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    public int NumberOfWheels { get; set; }
    public string Color { get; set; }
    public bool IsHybrid { get; set; }
    public bool IsAutodrive { get; set; }
    
}