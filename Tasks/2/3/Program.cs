using Tasks.Util;

namespace Tasks._2._3;

public class Program : BaseProgram
{
    public Program()
    {
        short shortNumber1 = Input.ReadShort("Input first short");
        short shortNumber2 = Input.ReadShort("Input second short");
        short shortNumber3 = Input.ReadShort("Input third short");
        short shortNumber4 = Input.ReadShort("Input fourth short");
        byte[] bytes1 = BitConverter.GetBytes(shortNumber1);
        byte[] bytes2 = BitConverter.GetBytes(shortNumber2);
        byte[] bytes3 = BitConverter.GetBytes(shortNumber3);
        byte[] bytes4 = BitConverter.GetBytes(shortNumber4);
        
        byte[] longBytes = {bytes4[0], bytes4[1],bytes3[0], bytes3[1],bytes2[0], bytes2[1],bytes1[0], bytes1[1]};
        long longNumber = BitConverter.ToInt64(longBytes);
        
        Console.WriteLine(longNumber);
    }
}