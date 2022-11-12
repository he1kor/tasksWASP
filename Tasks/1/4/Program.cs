using Tasks.Util;

namespace Tasks._1._4;

public class Program : BaseProgram
{
    public Program()
    {
        uint triangleSize = Input.ReadNotNegativeInt("Enter size of Pascal's triangle:");
        List<int> pastLine = new List<int>();
        for (int lineNumber = 1; lineNumber <= triangleSize; lineNumber++)
        {
            foreach (int number in pastLine)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            List<int> newLine = new List<int>();
            
            
            for (int i = 0; i < lineNumber; i++)
            {
                if (i == 0 || i == pastLine.Count)
                {
                    newLine.Add(1);
                    continue;
                }

                newLine.Add(pastLine[i - 1] + pastLine[i]);
            }

            pastLine = new List<int>(newLine);
        }
    }
}