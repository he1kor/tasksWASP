using Tasks.Util;

namespace Tasks._1._2
{
public class Program : BaseProgram
    {
        public Program()
        {
            uint length = Input.ReadNotNegativeInt("Input length of matrix: ");
            for (uint i = 1; i <= length; i++)
            {
                for (uint digit = length - i + 1; digit < length; digit++)
                {
                    Console.Write(digit + new string(' ',length.ToString().Length - digit.ToString().Length + 1));
                }
                for (uint digit = length; digit >= i; digit--)
                {
                    Console.Write(digit + new string(' ',length.ToString().Length - digit.ToString().Length + 1));
                }

                Console.WriteLine();
            }
        }
    }
}