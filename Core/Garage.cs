using Core.Vehicles;

namespace Core;

public class Garage
{
    private readonly Floor[] _floors;
    
    public Garage(Floor[] floors)
    {
        _floors = floors;
    }
    
    public ParkingSpace? GetFirstAvailableParkingSpace(Vehicle vehicle)
    {
        return _floors.FirstOrDefault(floor => floor.CanParkVehicle(vehicle))?
            .GetFirstAvailableParkingSpace(vehicle);
    }
}