using Core;

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

Console.WriteLine("");