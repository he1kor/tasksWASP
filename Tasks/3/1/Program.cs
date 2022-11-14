using Tasks.Util;

namespace Tasks._3._1;

public class Program : BaseProgram
{
    public Program()
    {
        uint length = Input.ReadNotNegativeInt("Enter size of vector: ");
        uint normOrder = Input.ReadNotNegativeInt("Enter order of norm: ");
        double[] vector = new double[length];
        
        for (int i = 0; i < length; i++)
        {
            vector[i] = Input.ReadDouble("Input " + (i+1) + " element of vector: ");
        }

        double normOfVector = vector.Sum(element => Math.Pow(element, normOrder));
        normOfVector = Math.Pow(normOfVector,1.0 / normOrder);
        
        Console.WriteLine(normOfVector);
    }
}