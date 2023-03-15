using Core.Vehicles;

namespace Core;

public class ParkingSpace
{
    private ParkingSpaceSize Size;
    private ParkingSpaceHeight Height;
    private Vehicle? OccupiedVehicle;
    
    public ParkingSpace(ParkingSpaceSize size, ParkingSpaceHeight height)
    {
        Size = size;
        Height = height;
    }
}

public enum ParkingSpaceHeight
{
    Low,
    High
}

public enum ParkingSpaceSize
{
    Small,
    Large
}