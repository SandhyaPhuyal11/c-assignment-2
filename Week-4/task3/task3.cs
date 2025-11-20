namespace task3;

public class ParameterDemo
{
    // 1. Method using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. Method using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Sandhya Phuyal";  // Assign your full name
    }

    // 3. Method using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}
