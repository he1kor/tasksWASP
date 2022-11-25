namespace Tasks._4._1;

public class PassengerCar : Car
{
    private int _passengerAmount;

    public int PassengerAmount => _passengerAmount;

    private Dictionary<string,int> _repairHistory;
    
    public PassengerCar(double power, string brand, int productionYear,int passengerAmount) : base(power, brand, productionYear)
    {
        _passengerAmount = passengerAmount;
        _repairHistory = new Dictionary<string, int>();
    }

    public bool WriteRepairYear(string detail, int year)
    {
        if (_repairHistory.ContainsKey(detail))
            return false;
        _repairHistory.Add(detail,year);
        return true;
    }

    public int ReadRepairYear(string detail)
    {
        if (!_repairHistory.ContainsKey(detail))
            throw new ArgumentException("repairHistory doesn't contain " + detail);
        return _repairHistory[detail];
    }

    public void PrintRepairHistory()
    {
        foreach (KeyValuePair<string,int> detailRepairYear in _repairHistory)
        {
            Console.WriteLine(detailRepairYear.Key + ": " + detailRepairYear.Value);
        }
    }

    public override string ToString()
    {
        return Brand + ", " + ProductionYear + ", " + Power + " horse power; " + _passengerAmount + " passengers";
    }
}