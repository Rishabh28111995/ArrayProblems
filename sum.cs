namespace Array4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int sum = 0;

        Console.WriteLine("Enter {0} elements in array: ", length);
        for(int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("sum is = {0}", sum);
    }
}

