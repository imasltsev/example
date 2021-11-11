using System;
using System.Collections.Generic;
using Bogus;

namespace Task4._3
{
    class Ex3
    {
        static void DeleteNumbers(LinkedList<int> list)
        {
            var numbers = list.First;
            var numbers1 = numbers;
            var count = 0;

            while (list.Count != 1)
            {
                var j = list.Count;
                for(int i = 0; i < j; i++)
                {
                    if (numbers != null)
                    {
                        numbers1 = numbers;
                        numbers = numbers.Next;
                        if (i % 2 != 0)
                        {
                            list.Remove(numbers1);
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                numbers = list.First;
                count++;
                Console.Write($"\n{count} circle: ");
                foreach (var item in list)
                {
                    Console.Write($"{item}, ");

                }

            }
        }
        
        static void Main(string[] args)
        {
            var listA = new LinkedList<int>();
            Console.Write("Enter the number of people in th circle: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N < 2 || N > 100)
            {
                Console.Write("\nError! Please, enter the number of of people in range [2, 100]:");
                N = Convert.ToInt32(Console.ReadLine());
            }

            listA.AddFirst(1);
            for (int i = 1; i < N; i++)
            {
                if (listA.Last != null)
                {
                    listA.AddAfter(listA.Last,i+1);
                }
            }

            Console.Write("listA: ");
            foreach (var item in listA)
            {
                Console.Write($"{item}. ");
            }

            Console.WriteLine();
            DeleteNumbers(listA);
        }
    }        
}
