using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=0,c;

            Char[] A = new Char[7] {'c', 'b', '5', '6','7','2','6'};
            

            for (int i = 0; i < 7; i++)
            {
                c=Convert.ToInt32(A[i]);
                Console.WriteLine(c);


                if (c >= '0' && c <= '9')
                    b++;
            }
            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
