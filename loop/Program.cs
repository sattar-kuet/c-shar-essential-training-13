using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  for(int counter=1; counter<=10; counter = counter + 1)
            {
                Console.WriteLine(counter);
            } */ 

               /* 10
                9
                8
                7
                .
                .
                1 */

           /* for(int counter = 10; counter>0 ; counter = counter - 1)
            {
                Console.WriteLine(counter);
            }*/
            /*
             * 1 3 5 7 9 11 13 15 ... 31
             */

            for (int i = 1; i<=31; i = i + 2)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
