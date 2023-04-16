namespace Array1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        int max1, max2;

        Console.WriteLine("Enter {0} elements in the array:", size);
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        max1 = max2 = arr[0];

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > max1)
            {
                max2 = max1;
                max1 = arr[i];
            }
            else if (arr[i] > max2 && arr[i] < max1)
            {
                
                max2 = arr[i];
            }
        }

        
        Console.Write("Second Highest = {0}", max2);
        Console.ReadLine();
    }
}

  


