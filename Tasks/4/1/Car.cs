namespace Tasks._4._1;

public class Car
{
    private string _brand;
    private int _productionYear;
    private double _power;
    public double Power => _power;

    public string Brand => _brand;

    public int ProductionYear => _productionYear;

    public Car(double power, string brand, int productionYear)
    {
        _power = power;
        _brand = brand;
        _productionYear = productionYear;
    }

    public override string ToString()
    {
        return _brand + ", " + _productionYear + ", " + _power + " horse power";
    }
}