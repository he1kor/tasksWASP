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
            catch (OverflowException)
            {
                Console.WriteLine("Too large!");
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

    public static short ReadShort(string question)
    {
        while (true)
        {
            Console.WriteLine(question);
            try
            {
                return short.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not short!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large!");
            }
        }
    }
    public static long ReadLong(String question)
    {
        while (true)
        {
            Console.WriteLine(question);
            try
            {
                return long.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Not long!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large!");
            }
        }
    }
    public static int ReadIntInRange(String question,int beginValue,int endValue)
    {
        int integerValue;
        while (true)
        {
            Console.WriteLine(question);
            try
            {
                integerValue = int.Parse(Console.ReadLine());
                if (integerValue > endValue)
                {
                    Console.WriteLine("Too large!");
                    continue;
                }
                if (integerValue < beginValue)
                {
                    Console.WriteLine("Too small!");
                    continue;
                }

                return integerValue;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not integer!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large!");
            }
        }
    }
}