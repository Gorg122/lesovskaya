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
            int f,max=0,t,j=0,i=0;
            string str;
            Console.WriteLine("введите количетсво чисел в массиве");
            str=Console.ReadLine();
            f=int.Parse(str);

            int[]A = new int [f];
            Random rnd=new Random();


            for (i = 0; i < f; i++)
            
            
                A[i] = rnd.Next()%100;
            
                for (i = 0; i < f; i++)
                {
                    Console.Write(A[i] + " ");
                }


                for (i = 0; i < f; i++)
                {
                    max = 0;
                    for (j = 0; j < f - i; j++)
                    {
                        if (A[j] > A[max])
                            max = j;
                    }
                    j--;
                    if (max < j)
                    {
                        t = A[max];
                        A[max] = A[j];
                        A[j] = t;
                    }
                }
                Console.WriteLine();

                for (i = 0; i < f; i++)
                {
                    Console.Write(A[i] + " ");
                }


            Console.ReadKey();
            



        }
    }
}

