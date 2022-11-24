using System.Text;
using Tasks.Util;

namespace Tasks._2._2;

public class Program : BaseProgram
{
    public Program()
    {
        uint firstInt = Input.ReadNotNegativeInt("Input first value:");
        uint secondInt = Input.ReadNotNegativeInt("Input second value:");
        uint sum = firstInt + secondInt;

        string firstBinary = IntToBinaryString(firstInt);
        string secondBinary = IntToBinaryString(secondInt);
        string sumBinary = IntToBinaryString(sum);
        
        Console.WriteLine(firstBinary);
        Console.WriteLine(secondBinary);
        Console.WriteLine(new string('-',sizeof(int)*8));
        Console.WriteLine(sumBinary);
    }
    private string IntToBinaryString(uint sourceInt)
    {
        StringBuilder binaryString = new StringBuilder("");
        for (int i = 0; i < sizeof(int) * 8; i++)
        {
            binaryString.Insert(0,BoolToString(CheckBit(sourceInt,i)));
        }

        return binaryString.ToString();
    }

    private uint CreateTrueBitMask(int bitIndex)
    {
        TryThrowBitOutOfInt(bitIndex);
        return (uint)1 << bitIndex;
    }

    private bool CheckBit(uint value, int bitIndex)
    {
        return (value | CreateTrueBitMask(bitIndex)) == value;
    }

    private void TryThrowBitOutOfInt(int bitIndex)
    {
        if (bitIndex < 0)
            throw new ArgumentOutOfRangeException(bitIndex + " is less than 0");
        if (bitIndex >= sizeof(int) * 8)
            throw new ArgumentOutOfRangeException(bitIndex + " is more than " + (sizeof(int)-1));
    }

    private string BoolToString(bool boolValue)
    {
        return boolValue ? "1" : "0";
    }
}