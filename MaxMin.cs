using System.Drawing;

namespace Array5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int max;
        int min;

        Console.WriteLine("Enter {0} elements in array", length);
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        max = arr[0];
        min = arr[0];

        for (int i = 1; i < length; i++)
        {
           if (arr[i] > max)
            {
                max = arr[i];
            }

           if (arr[i] < min)
            {
                min = arr[i];
            }
            Console.WriteLine("Highest element = {0}\n", max);
            Console.WriteLine("smallest element = {0}", min);
            
        }
    }
}

