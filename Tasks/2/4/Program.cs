using Tasks.Util;

namespace Tasks._2._4;

public class Program : BaseProgram
{
    public Program()
    {
        long longNumber = Input.ReadLong("Input long here: ");
        
        byte[] longBytes = BitConverter.GetBytes(longNumber);

        byte[] shortBytes1 = {longBytes[6], longBytes[7]};
        byte[] shortBytes2 = {longBytes[4], longBytes[5]};
        byte[] shortBytes3 = {longBytes[2], longBytes[3]};
        byte[] shortBytes4 = {longBytes[0], longBytes[1]};

        short shortNumber1 = BitConverter.ToInt16(shortBytes1);
        short shortNumber2 = BitConverter.ToInt16(shortBytes2);
        short shortNumber3 = BitConverter.ToInt16(shortBytes3);
        short shortNumber4 = BitConverter.ToInt16(shortBytes4);

        Console.WriteLine(shortNumber1);
        Console.WriteLine(shortNumber2);
        Console.WriteLine(shortNumber3);
        Console.WriteLine(shortNumber4);
    }
}