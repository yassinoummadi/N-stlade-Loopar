using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nästlade_loopar
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Övning 1
            int bredd = 5;
            int hojd = 10;

            for (int y = 0; y < hojd; y++)
            {
                for (int x = 0; x < bredd; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            */

            /* Övning 2 EJ KLAR
            int bredd = 5;
            int hojd = 11;

            for (int y = 0; y < hojd; y++)
            {
                for (int x = 0; x < bredd; x++)
                {
                    if (y%2==0)
                    {
                        Console.Write("o#");
                        
                    }
                    
                    else
                    {
                        Console.Write("#o");
                    }
                }
                Console.WriteLine();
            }
            */



            /* Övning 3
            for (int y = 10; y > 0; y--)
            {
                for (int i = 0; i < y; i++)
                {
                    Console.Write("#");
                }

                Console.Write("");

                Console.WriteLine();
            }
            */
            /* Övning 4
            for (int i = 0; i < 7; i++)
            {
                
                for (int x = 0; x < i; x++)
                {
                    Console.Write(".");
                }

                for (int z = 0; z < 7-i; z++)
                {
                    Console.Write("#");
                }
                
                Console.WriteLine();
            }
            */




        }
    }
}
