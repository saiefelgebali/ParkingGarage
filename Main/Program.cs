using Core;
using Core.Vehicles;

var garage = new Garage(new Floor[]
{
    new (new ParkingSpace[]
    {
        new (ParkingSpaceSize.Large, ParkingSpaceHeight.High),
        new (ParkingSpaceSize.Small, ParkingSpaceHeight.Low),
        new (ParkingSpaceSize.Large, ParkingSpaceHeight.Low),
    }),
    new (new ParkingSpace[]
    {
        new (ParkingSpaceSize.Large, ParkingSpaceHeight.High),
        new (ParkingSpaceSize.Small, ParkingSpaceHeight.Low),
        new (ParkingSpaceSize.Large, ParkingSpaceHeight.Low),
    }),
});

var myCar = new Car("123456");
var myVan = new Van("123456");
var myMotorbike = new Motorbike("123456");

garage.GetFirstAvailableParkingSpace(myMotorbike)?.ParkVehicle(myMotorbike);
garage.GetFirstAvailableParkingSpace(myVan)?.ParkVehicle(myVan);
garage.GetFirstAvailableParkingSpace(myCar)?.ParkVehicle(myCar);

Console.WriteLine();