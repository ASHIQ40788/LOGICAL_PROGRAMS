using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICAL_PROGRAMS
{
    class REVERSE_NUMBER
    {
        public void REV_NUM()
        {
            int reminder, sum = 0, number;
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            //int reminder, reverse = 0;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = number % 10;
                //multiply the sum with 10 and then add the reminder
                sum = (sum * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is :" +sum);
            Console.ReadKey();
        }
    }
}