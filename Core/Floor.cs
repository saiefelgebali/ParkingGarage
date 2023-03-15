using Core.Vehicles;

namespace Core;

public class Floor
{
    private readonly ParkingSpace[] _parkingSpaces;

    public Floor(ParkingSpace[] parkingSpaces)
    {
        _parkingSpaces = parkingSpaces;
    }

    public bool CanParkVehicle(Vehicle vehicle)
    {
        return _parkingSpaces.Any(space => space.CanParkVehicle(vehicle));
    }
    
    public ParkingSpace? GetFirstAvailableParkingSpace(Vehicle vehicle)
    {
        return _parkingSpaces.FirstOrDefault(space => space.CanParkVehicle(vehicle));
    }
}