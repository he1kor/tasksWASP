using Tasks.Util;

namespace Tasks._4._1;

public class Program : BaseProgram
{
    private CarPark _carPark;
    public Program()
    {
        _carPark = new CarPark(Input.ReadNotEmptyString("Enter car park name: "));

        int choice;
        while (true)
        {
            Console.WriteLine("Choose action:\n0. Exit program.\n1. Create new passenger car.\n2. Create new truck.");
            choice = Input.ReadIntInRange("perform action: ", 0, 2);
            if (choice == 0)
                break;
            PerformAction(choice);
            Console.WriteLine(_carPark);
        }

    }

    private void PerformAction(int action)
    {
        switch (action)
        {
            case 1:
                CreatePassengerCar();
                break;
            case 2:
                CreateTruck();
                break;
            default:
                throw new ArgumentException("Unexpected action: " + action);
        }
    }

    private void CreatePassengerCar()
    {
        double power = Input.ReadDouble("Enter your car's power: ");
        string brand = Input.ReadNotEmptyString("Enter your car's brand: ");
        int productionYear = Input.ReadInt("Enter your car's production year: ");
        int passengerAmount = Input.ReadInt("Enter passenger amount: ");
        _carPark.AddCar(new PassengerCar(power,brand,productionYear,passengerAmount));
    }
    
    private void CreateTruck()
    {
        double power = Input.ReadDouble("Enter your car's power: ");
        string brand = Input.ReadNotEmptyString("Enter your car's brand: ");
        int productionYear = Input.ReadInt("Enter your car's production year: ");
        int maxWeight = Input.ReadInt("Enter your car's max weight: ");
        _carPark.AddCar(new Truck(power,brand,productionYear,maxWeight));
    }
}