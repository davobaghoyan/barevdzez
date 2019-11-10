using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete.element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray =  { 52, 24, 20, 35 };
            int  [] result = delete_element(myarray,4, 2);
            for (int i = 0; i < 3; i++)
                Console.WriteLine(result[i]);
            Console.ReadLine();


        }

        static int[] delete_element (int [] myarray, int size,int k)
        {
            int j = 0;
            int[] newarray = new int[size - 1];
            for (int f = 0; f < size; f++)
            {
                if (f == k)
                    continue;
                newarray[j] = myarray[f];
                j++;
            }

            return newarray;
        }
    }
}
