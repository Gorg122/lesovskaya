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
            int a,b,f;
            string str;

            Console.WriteLine("введите количество чисел в массиве 1");
            str=Console.ReadLine();
            a = int.Parse(str);

            Console.WriteLine("введите количество чисел в массиве 2");
            str = Console.ReadLine();
            b = int.Parse(str);

            Random rnd = new Random();

            int[] A = new int[a];
            for (int i = 0; i < a; i++)
            {
                A[i] = rnd.Next()%100;
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();
            int[] B= new int[b];
            for (int c = 0; c < b; c++)
            {
                B[c] = rnd.Next()%100;
                Console.Write(B[c] + " ");
            }
         

                Console.ReadLine();

            


        }
    }
}
