namespace Core.Vehicles;

public class Car : Vehicle
{
    public Car(string registrationNumber)
    {
        RegistrationNumber = registrationNumber;
        Height = ParkingSpaceHeight.Low;
        Size = ParkingSpaceSize.Large;
    }
}