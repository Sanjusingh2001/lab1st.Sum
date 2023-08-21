using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1st.Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            Console.WriteLine("Enter the element of array : ");
            for (int i = 0; i < 5; i++) Arr[i] = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += Arr[i];
            }
            Console.WriteLine("The sum of all elements of array : " + sum);
            Console.ReadLine();
        }
    }
}
