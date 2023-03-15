using Core.Vehicles;

namespace Core;

public class ParkingSpace
{
    private readonly ParkingSpaceSize _size;
    private readonly ParkingSpaceHeight _height;
    private Vehicle? _occupiedVehicle;
    
    public ParkingSpace(ParkingSpaceSize size, ParkingSpaceHeight height)
    {
        _size = size;
        _height = height;
    }

    public bool CanParkVehicle(Vehicle vehicle)
    {
        if (_occupiedVehicle != null)
        {
            return false;
        }
        
        return vehicle.Height <= _height && vehicle.Size <= _size;
    }

    public void ParkVehicle(Vehicle vehicle)
    {
        if (!CanParkVehicle(vehicle))
        {
            throw new Exception($"This parking space cannot be occupied by a {vehicle.GetType()}.");
        }

        _occupiedVehicle = vehicle;
    }
}

public enum ParkingSpaceHeight
{
    Low = 0,
    High = 1,
}

public enum ParkingSpaceSize
{
    Small = 0,
    Large = 1,
}