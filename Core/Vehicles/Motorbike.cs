namespace Core.Vehicles;

public class Motorbike : Vehicle
{
    public Motorbike(string registrationNumber)
    {
        RegistrationNumber = registrationNumber;
        Height = ParkingSpaceHeight.Low;
        Size = ParkingSpaceSize.Small;
    }
}