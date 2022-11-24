namespace Tasks._3._3;

public struct SubarrayExpression
{
    public int StartIndex;
    public int EndIndex;
    public int JumpValue;

    public SubarrayExpression(string creatingQuestion)
    {
        StartIndex = 0;
        EndIndex = 0;
        JumpValue = 0;
        while (true)
        {
            Console.WriteLine(creatingQuestion);
            string subarrayExpressionString = Console.ReadLine();
            if (subarrayExpressionString == null) continue;
            
            const int firstValueIndex = 0;

            if (CheckValueCorrectness(subarrayExpressionString,findColons(subarrayExpressionString))) break;
        }
    }

    private Tuple<int?, int?, int?> findColons(string subarrayExpressionString)
    {
        int? secondValueIndex = null;
        int? thirdValueIndex = null;
        for (int i = 0; i < subarrayExpressionString.Length-1; i++)
        {
            if (subarrayExpressionString[i] != ':') continue;
                
            if (secondValueIndex == null) secondValueIndex = i + 1;
            else if (thirdValueIndex == null) thirdValueIndex = i + 1;
        }

        return new Tuple<int?, int?,int?>(0,secondValueIndex,thirdValueIndex);
    }
    private bool CheckValueCorrectness(string subarrayExpressionString, Tuple<int?, int?, int?> indexes)
    {
        if (indexes.Item1 == null || indexes.Item2 == null || indexes.Item3 == null)
        {
            return false;
        }

        int firstValueIndex = (int) indexes.Item1;
        int secondValueIndex = (int) indexes.Item2;
        int thirdValueIndex = (int) indexes.Item3;
        
        try
        {
            StartIndex = (int) uint.Parse(subarrayExpressionString.Substring(firstValueIndex,secondValueIndex-1));
            EndIndex = (int) uint.Parse(subarrayExpressionString.Substring(secondValueIndex,thirdValueIndex-secondValueIndex-1));
            JumpValue = int.Parse(subarrayExpressionString.Substring(thirdValueIndex,subarrayExpressionString.Length-thirdValueIndex));
            return true;
        }
        catch (FormatException)
        {
            Console.WriteLine("Not integer!");
            return false;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Not in integer range!");
            return false;
        }
    }

    public T[] GetSubArray<T>(T[] array)
    {
        List<T> newArray = new List<T>();
        for (int i = JumpValue > 0 ? StartIndex : EndIndex;
             JumpValue > 0 ? i <= EndIndex : i >= StartIndex;
             i += JumpValue)
        {
            newArray.Add(array[i]);
        }

        return newArray.ToArray();
    }
}