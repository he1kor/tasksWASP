namespace Tasks;

public abstract class BaseProgram : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("-------------------------------------------");
    }
    protected BaseProgram()
    {
        Console.WriteLine("-------------------------------------------");
    }
}