using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] fibonacci = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    fibonacci[i] = i;
                }
                else
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                Console.Write(fibonacci[i] + " ");
            }
        }
    }
}
