using Tasks.Util;

namespace Tasks._2._1;

public class Program : BaseProgram
{
    public Program()
    {
        Console.WriteLine(Convert.ToString(Input.ReadNotNegativeInt("Input integer number you want to read as binary:"),2));
    }
}