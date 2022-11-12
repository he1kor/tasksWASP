using System.Text;

namespace Tasks._1._1;

public class Program : BaseProgram
{
    public Program()
    {
        StringBuilder magicNumber = new StringBuilder(new String('0', 4));
        for (int digit1 = 3; digit1 <= 9; digit1++)
        {
            magicNumber[0] = digit1.ToString()[0];
            for (int digit2 = 2; digit2 < digit1; digit2++)
            {
                magicNumber[1] = digit2.ToString()[0];
                for (int digit3 = 1; digit3 < digit2; digit3++)
                {
                    magicNumber[2] = digit3.ToString()[0];
                    for (int digit4 = 0; digit4 < digit3; digit4++)
                    {
                        magicNumber[3] = digit4.ToString()[0];
                        Console.WriteLine(magicNumber);
                    }
                }
            }
        }
    }
}