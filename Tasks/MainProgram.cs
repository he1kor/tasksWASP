namespace Tasks;

public static class Program
{
    private static BaseProgram runningProgram;
    private static string[][] programs =
    {
        new []{ "Magical Numbers","Diagonal number matrix","Draw triangle with points","Pascal's triangle" },
        new []{ "To bit code","Test" }
    };
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Type Program number. Example: \"1.1\". Type \"0\" to exit.");
            PrintPrograms();
            string answer = Console.ReadLine();
            if (answer == "0") break;

            if (RunProgram(answer))
            {
                runningProgram.Dispose();
            }
            else
            {
                Console.WriteLine("Wrong program number!");
            }
        }
    }

    private static bool RunProgram(string program)
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