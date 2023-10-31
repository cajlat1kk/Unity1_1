using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ШалаевИльяАлексеевич_1
{

    class Program
    {
        static void Main()
        {
            
            int[] elememt = new int[100];
            Random random = new Random();

            for (int x = 0; x < elememt.Length; x++)
            {
                elememt[x] = random.Next(1, 101); 
            }

            Console.WriteLine("Стартовый массив:");
            PrintMassive(elememt);

            BubbleSort(elememt);

            Console.WriteLine("Отсортированный массив:");
            PrintMassive(elememt);
            Console.ReadLine();

        
        }

        static void BubbleSort(int[] a)
        {
            int sravnenie;
            for (int x = 0; x < a.Length - 1; x++)
            {
                for (int y = 0; y < a.Length - 1 - x; y++)
                {
                    if (a[y] > a[y + 1])
                    {
                        
                        sravnenie = a[y];
                        a[y] = a[y + 1];
                        a[y + 1] = sravnenie; 
                    }
                }
            }
        }

        static void PrintMassive(int[] b)
        {
            foreach (int num in b)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
        }
            
    }
}