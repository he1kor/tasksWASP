using Tasks.Util;

namespace Tasks._2._5;

public class Program : BaseProgram
{
    public Program()
    {
        long longNumber = Input.ReadLong("Input long number:");
        int firstByteNumber = Input.ReadIntInRange("Input first number of byte (from 1 to 8):",1,8);
        int secondByteNumber = Input.ReadIntInRange("Input second number of byte (from 1 to 8):",1,8);

        firstByteNumber--;
        secondByteNumber--;
        byte[] longBytes = BitConverter.GetBytes(longNumber);

        byte bufferByte = longBytes[firstByteNumber];

        List<Byte> newBytes = new List<byte>(longBytes);
        newBytes.RemoveAt(firstByteNumber);
        newBytes.Insert(firstByteNumber,longBytes[secondByteNumber]);
        
        newBytes.RemoveAt(secondByteNumber);
        newBytes.Insert(secondByteNumber,longBytes[firstByteNumber]);
        
        Console.WriteLine(BitConverter.ToInt64(newBytes.ToArray()));
    }
}