using System.Text;
using Tasks.Util;

namespace Tasks._2._1;

public class Program : BaseProgram
{
    public Program()
    {
        uint sourceValue = Input.ReadNotNegativeInt("Input integer number you want to read as binary:");
        Console.WriteLine(IntToBinaryString(sourceValue));
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