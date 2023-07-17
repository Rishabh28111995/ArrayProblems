namespace Array1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        int maxOne, maxTwo;

        Console.WriteLine("Enter {0} elements in the array:", size);
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        maxOne = maxTwo = arr[0];

        for (int i = 0; i < size; i++)
        {
            if (arr[i] > max1)
            {
                maxTwo = maxOne;
                maxOne = arr[i];
            }
            else if (arr[i] > maxTwo && arr[i] < maxOne)
            {
                
                maxTwo = arr[i];
            }
        }

        
        Console.Write("Second Highest = {0}", maxTwo);
        Console.ReadLine();
    }
}

  


