using Tasks.Util;

namespace Tasks._2._2;

public class Program : BaseProgram
{
    public Program()
    {
        uint firstInt = Input.ReadNotNegativeInt("Input first value:");
        uint secondInt = Input.ReadNotNegativeInt("Input second value:");
        uint sum = firstInt + secondInt;

        string firstBinary = Convert.ToString(firstInt,2);
        string secondBinary = Convert.ToString(secondInt,2);
        string sumBinary = Convert.ToString(sum, 2);
        
        int firstLength = firstBinary.Length;
        int secondLength = secondBinary.Length;
        int sumLength = sumBinary.Length;

        firstBinary = new String('0', sumLength - firstLength) + firstBinary;
        secondBinary = new String('0', sumLength - secondLength) + secondBinary;
        
        Console.WriteLine(firstBinary);
        Console.WriteLine(secondBinary);
        Console.WriteLine(new string('-',sumLength));
        Console.WriteLine(sumBinary);
    }
}