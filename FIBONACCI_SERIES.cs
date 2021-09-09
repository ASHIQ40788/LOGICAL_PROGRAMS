using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAL_PROGRAMS
{
    class FIBONACCI_SERIES
    {
        public void Implemented()
        {
            int a = 0, b = 1, c, i, number;
            Console.Write("Enter the number of elements: ");

            //Parse : used to convert the string representation of a number to its 32-bit signed integer 
            number = int.Parse(Console.ReadLine());

            //printing 0 and 1   
            Console.Write(a + " " + b + " ");

            //loop starts from 2 because 0 and 1 are already printed
            for (i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
            Console.ReadKey();
        }
    }
}
