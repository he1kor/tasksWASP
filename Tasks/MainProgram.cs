namespace Tasks;

public static class Program
{
    private static BaseProgram runningProgram;
    private static string[][] programs =
    {
        new []{ "Magical Numbers","Diagonal number matrix","Draw triangle with points","Pascal's triangle" },
        new []{ "Read int as binary","Sum of binary","4 shorts to long","Long to 4 shorts","Switch 2 bytes in long" },
        new []{ "Vector norm","Minimum by index","Subarray expression" },
        new []{ "Car park"},
        new []{ "Disk store"}
    };
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Type Program number. Example: \"1.1\". Type \"0\" to exit.");
            PrintPrograms();
            string answer = Console.ReadLine();
            if (answer == "0") break;

            if (TryRunProgram(answer))
            {
                runningProgram.Dispose();
            }
            else
            {
                Console.WriteLine("Wrong program number!");
            }
        }
    }

    private static bool TryRunProgram(string program)
    {
        switch (program)
        {
            case "1.1":
                runningProgram = new _1._1.Program();
                return true;
            case "1.2":
                runningProgram = new _1._2.Program();
                return true;
            case "1.3":
                runningProgram = new _1._3.Program();
                return true;
            case "1.4":
                runningProgram = new _1._4.Program();
                return true;
            case "2.1":
                runningProgram = new _2._1.Program();
                return true;
            case "2.2":
                runningProgram = new _2._2.Program();
                return true;
            case "2.3":
                runningProgram = new _2._3.Program();
                return true;
            case "2.4":
                runningProgram = new _2._4.Program();
                return true;
            case "2.5":
                runningProgram = new _2._5.Program();
                return true;
            case "3.1":
                runningProgram = new _3._1.Program();
                return true;
            case "3.2":
                runningProgram = new _3._2.Program();
                return true;
            case "3.3":
                runningProgram = new _3._3.Program();
                return true;
            case "4.1":
                runningProgram = new _4._1.Program();
                return true;
            case "5.1":
                runningProgram = new _5._1.Program();
                return true;
            default:
                return false;
        }
    }

    private static void PrintPrograms()
    {
        for (int task = 0; task < programs.Length; task++)
        {
            Console.WriteLine(task+1 + ":");
            for (int subTask = 0; subTask < programs[task].Length; subTask++)
            {
                Console.WriteLine("\t" + (subTask+1) + " - " + programs[task][subTask]);
            }
        }
    }
}