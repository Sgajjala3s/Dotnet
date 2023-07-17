using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Even and Odd Numbers program for first 100 numbers
namespace EvenandOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers:");
            for (int n = 0; n <= 100; n++)
            {
                if (n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
                
            }
            Console.WriteLine("\nodd Numbers:");
            for (int n = 0; n <= 100; n++)
            {
                if(n%2 !=0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
