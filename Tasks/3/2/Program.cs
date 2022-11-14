using Tasks.Util;

namespace Tasks._3._2;

public class Program : BaseProgram
{

    public Program()
    {
        uint length = Input.ReadNotNegativeInt("Enter size of vector: ");
        
        double[] array = new double[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = Input.ReadDouble("Input " + (i+1) + " element of vector: ");
        }

        int minimumIndex = Input.ReadIntInRange("Enter minimum index: ",1,(int) length);

        List<double> arrayWithoutMinimums = new List<double>(array);
        
        for (int i = 1; i < minimumIndex; i++)
        {
            arrayWithoutMinimums.Remove(arrayWithoutMinimums.Min());
        }
        Console.WriteLine(arrayWithoutMinimums.Min());
    }
}