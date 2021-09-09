
using System;

namespace LOGICAL_PROGRAMS
{
    class PRIME_NUMBER
    {
        public void PrN()
        {
            int n, i, COUNT = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    COUNT++;
                }

            }



            if (COUNT == 2)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("NOT A PRIME NUMBER");
            }
        }
    }
}