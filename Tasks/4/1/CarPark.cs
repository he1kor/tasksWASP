namespace Tasks._4._1;

public class CarPark
{
    private string _name;
    private List<Car> _cars;

    public string Name => _name;
    public List<Car> Cars => _cars;

    public CarPark(string name)
    {
        _name = name;
        _cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        _cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        _cars.Remove(car);
    }

    public override string ToString()
    {
        string result = _name + " the car park:";
        foreach (Car car in _cars)
        {
            result += "\n" + car + ";";
        }
        return result;
    }
}