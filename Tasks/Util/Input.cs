namespace Tasks.Util;

public class Input
{
    public static int ReadInt(String question)
    {
        while (true)
        {
            Console.WriteLine(question);
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not integer!");
            }
        }
    }

    public static uint ReadNotNegativeInt(String question)
    {
        int notNegativeValue;
        while (true)
        {
            notNegativeValue = ReadInt(question);
            if (notNegativeValue >= 0) return (uint)notNegativeValue;
            Console.WriteLine("Negative integer!");
        }
    }
}