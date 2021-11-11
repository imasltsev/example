using Bogus;
using System;
using System.Collections.Generic;

namespace Task4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var intList = new List<int>();
            var intList2 = new List<int>();
            var stringList = new List<string>();
            var stringList2 = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                intList.Add(rnd.Next(-100, 101));
                intList2.Add(rnd.Next(-100, 101));

                var faker = new Faker();
                stringList.Add(faker.Hacker.Noun());

                var faker2 = new Faker();
                stringList2.Add(faker2.Hacker.Noun());
            }

            Console.Write("Numbers list: ");
            foreach (var i in intList)
            {
                Console.Write($"{i}. ");
            }

            Console.WriteLine();

            Console.Write("String list: ");
            foreach (var str in stringList)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();

            Console.Write("Numbers list №2: ");
            foreach (var i in intList2)
            {
                Console.Write($"{i}. ");
            }

            Console.WriteLine();

            Console.Write("String list№2: ");
            foreach (var str in stringList2)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Sorting.

            ISorted<int> intShakerSort = new ShakerSort<int>();
            ISorted<string> stringShakerSort = new ShakerSort<string>();
            ISorted<int> intShellSort = new ShellSort<int>();
            ISorted<string> stringShellSort = new ShellSort<string>();

            intShakerSort.Sort(intList, new IntComparer());
            stringShakerSort.Sort(stringList, new StrComparer());

            intShellSort.Sort(intList2, new IntComparer());
            stringShellSort.Sort(stringList2, new StrComparer());


            Console.Write("Int list, sorted with Shaker Sort: ");
            foreach (var i in intList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write("String list, sorted with Shaker Sort: ");
            foreach (var str in stringList)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Int list №2, sorted with Shell Sort: ");
            foreach (var i in intList2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write("String list №2, sorted with Shell Sort: ");
            foreach (var str in stringList2)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
        }
    }
}
