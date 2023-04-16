namespace Array3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("Enter {0} elements in array", length);
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNegative elements age: ");
        for (int i = 0; i < length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("{0}\t", arr[i]);
            }
        }

    }
}

