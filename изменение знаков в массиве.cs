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
            int a;
            string str;
            Console.WriteLine("введите количество чисел в массиве");
            str = Console.ReadLine();
            a = int.Parse(str);

            Char[]A = new Char[a];
            Random rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                A[i] = Convert.ToChar(rnd.Next()%100);
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();

            for (int f = 0; f < a; f++)
            {
                if(A[f]!='$')
                
                    A[f]='$';
                Console.Write(A[f] + " ");
            }
            
                Console.ReadLine();

        }
    }
}
