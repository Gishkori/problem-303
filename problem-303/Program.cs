
public class NumArray
{

    private int[] numArray;

    public NumArray(int[] nums)
    {
        numArray = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;
        for (int i = left; i <= right && i < numArray.Length; i++)
        {
            sum = sum + numArray[i];
        }
        return sum;
    }
}

class Program
{
    static void Main()
    {
        NumArray obj = new NumArray([1, 2, 3, 4]);
        int param_1 = obj.SumRange(0, 2);
        Console.WriteLine(param_1);
    }

}