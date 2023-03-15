namespace Core.Vehicles;

public abstract class Vehicle
{
    public string RegistrationNumber { get; protected set; }
    public ParkingSpaceHeight Height { get; protected set; }
    public ParkingSpaceSize Size { get; protected set; }
}