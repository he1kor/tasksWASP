namespace Tasks._4._1;

public class Truck : Car
{
    private int _maxWeight;
    private int _weight;
    private Tuple<string?, string?> _driverFullName;
    private Dictionary<string, int> _load;

    public int MaxWeight => _maxWeight;
    public Tuple<string?, string?> DriverFullName => _driverFullName;
    public Dictionary<string, int> Load => _load;

    public Truck(double power, string brand, int productionYear,int maxWeight) : base(power, brand, productionYear)
    {
        _maxWeight = maxWeight;
        _driverFullName = new Tuple<string?, string?>(null,null);
        _load = new Dictionary<string, int>();
        _weight = 0;
    }

    public void SetDriverFullName(string firstName, string lastName)
    {
        _driverFullName = new Tuple<string?, string?>(firstName, lastName);
    }

    public bool AddLoad(string load,int weight)
    {
        if (_load.ContainsKey(load))
            return false;
        if (_weight + weight > _maxWeight)
            return false;
        _load.Add(load,weight);
        _weight += weight;
        return true;
    }

    public void RemoveLoad(string load)
    {
        if (!_load.ContainsKey(load))
            throw new ArgumentException("Load has no " + load);
        _weight -= _load[load];
        _load.Remove(load);
    }
    public void PrintLoad()
    {
        foreach (KeyValuePair<string,int> detailRepairYear in _load)
        {
            Console.WriteLine(detailRepairYear.Key + ": " + detailRepairYear.Value);
        }
    }
    public override string ToString()
    {
        return Brand + ", " + ProductionYear + ", " + Power + " horse power, " + _maxWeight + " max weight" + (_driverFullName.Item1 == null ? "" : "; " + _driverFullName.Item1 + " "+ _driverFullName.Item2 + " the driver");
    }
}