using Tasks.Util;

namespace Tasks._3._3;

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

        SubarrayExpression subarrayExpression = new SubarrayExpression("Input subarray expression. Example: 0:" + (length-1) + ":-1");

        array = subarrayExpression.GetSubArray(array);
        foreach (double value in array)
        {
            Console.WriteLine(value);
        }
    }
}