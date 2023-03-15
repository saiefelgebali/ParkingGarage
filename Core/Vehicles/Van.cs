namespace Core.Vehicles;

public class Van : Vehicle
{
    public Van(string registrationNumber)
    {
        RegistrationNumber = registrationNumber;
        Height = ParkingSpaceHeight.High;
        Size = ParkingSpaceSize.Large;
    }
}