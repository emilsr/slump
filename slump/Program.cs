using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slump
{
    class Program
    {
        static void Main(string[] args)
        {   //övning1
            /*
            int sum = 0;
            Random randomerare = new Random();
            int[] list = new int[10];

            for (int i = 0; i < 10; i++)
            {

                list[i] = randomerare.Next(1, 21);
                sum += list[i];
                Console.Write(list[i] + " ");
                
            }
            Console.WriteLine(sum/list.Length);
            Console.ReadKey();
            */
            //övning2
            Random randomerare = new Random();
            int[] list = new int[20];
            
            for (int i = 0; i < list.Length; i++)
            {

                list[i] = randomerare.Next(15, 31);
            }
            Array.Sort(list);
            for (int y = 0; y < 20; y++)
            {
                Console.Write(list[y] + " ");
                if (y==list.Length/2-1)
                {
                    Console.Write(":" + " ");
                }
            }
            double min =  list[list.Length/2-1];
            double max = list[list.Length / 2];
            Console.WriteLine("medianen är " + (min + max) /2);
            Console.ReadKey();

            //övning3
            //har redan gjort den i tidaigare övningar 
            

        }
    }
}
