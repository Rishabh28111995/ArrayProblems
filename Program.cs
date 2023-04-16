namespace Array2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];

        Console.WriteLine("Enter {0} elements in array", length);
        for(int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nElements in array: ");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0}", arr[i]);
        }
    }

}

