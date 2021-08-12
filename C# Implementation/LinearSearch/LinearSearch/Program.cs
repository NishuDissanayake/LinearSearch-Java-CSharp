using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your number list: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i=0; i<length; i++)
            {
                Console.Write("Enter the value for array element " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value you want to find: ");
            int key = int.Parse(Console.ReadLine());

            linearSearch(arr, key, length);

            Console.ReadLine();
        }

        private static void linearSearch(int[] arr, int key, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (key == arr[i])
                {
                    Console.WriteLine("Value was found at position " + (i+1));
                    break;
                }
            }
            Console.WriteLine("Value was not found");
        }
    }
}
