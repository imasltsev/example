using System;

namespace helloApp
{
    class Task1
    {
        static void Main(string[] args)
        {
            // task1
            Console.WriteLine("Task 1:");
            bool boolValue = true;
            byte byteValue = 55;
            sbyte sbyteValue = -1;
            char charValue ='M';
            decimal decimalValue =1005.5M;
            double doubelValue = 12.3;
            float floatValue = 12.3f;
            int intValue = 265;
            uint uintValue = 0xFF;
            long longValue = -20;
            ulong ulongValue=0b100;
            short shortValue = -1000;
            ushort ushValue = 25555;
            string name = "Ilua";
            object objectValue = "Hi";
            object ObjectValue = 3.14; 
            
            Console.WriteLine($"Your data: {boolValue}\t {byteValue}\t {sbyteValue}\t{charValue}\t" +
                $"{decimalValue}\t{doubelValue}\t{floatValue}\t{intValue}\t{uintValue}\n" +
                $"{longValue}\t{ulongValue}\t{shortValue}\t{ushValue}\t{name}\t{objectValue}\t{ObjectValue}\n");
            //-----------------------------------------------------------------------------------
            //task 2

            Console.Write("Task 2: \n");
            Console.Write("Enter an integer x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer y=");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer z=");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integerо t=");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Select * or / or + or - or for example: ({x}?{y})*({z}?{t})");
            string example = Console.ReadLine();
            switch (example)
            {
                case "*":
                    int a = (x * y) * (z * t);
                    Console.WriteLine($"You have chosen *:  ({x}*{y})*({z}*{t})= {a}");
                    break;
                case "/":
                    int a2 = (x / y) * (z / t);
                    Console.WriteLine($"You have chosen /:  ({x}/{y})*({z}/{t})= {a2}");
                    break;
                case "+":
                    int a3 = (x + y) * (z + t);
                    Console.WriteLine($"You have chosen +:  ({x}+{y})*({z}+{t})= {a3}");
                    break;
                case "-":
                    int a4 = (x - y) * (z - t);
                    Console.WriteLine($"You have chosen -:  ({x}-{y})*({z}-{t})= {a4}");
                    break;
                default:
                    Console.WriteLine("You have chosen an unknown action");
                    break;
            }
            Console.WriteLine("\n\n");
            //Task 2.1
            Console.WriteLine("Task 2.1\n");
            Console.WriteLine("operation  ==");
            var b1 = 1;
            var b2 = 2;
            bool c=b1==b2;
            Console.WriteLine($"{b1}=={b2} result {c}");
            Console.WriteLine("operation  !=");
            var b3 = 5;
            var b4 = 3;
            bool c1 = b3 != b4;
            Console.WriteLine($"{b3}!={b4} result {c1}");
            Console.WriteLine("operation  >");
            var b5 = 3;
            var b6 = 5;
            bool c2 = b5 > b6;
            Console.WriteLine($"{b5}>{b6} result {c2}");
            Console.WriteLine("operation  <");
            var b7 = 3;
            var b8 = 1;
            bool c3 = b7 < b8;
            Console.WriteLine($"{b7}<{b8} result {c3}");
            Console.WriteLine("operation  >=");
            var b9 = 3;
            var b10 = 5;
            bool c4 = b9 >= b10;
            Console.WriteLine($"{b9} >= {b10} result {c4}");
            Console.WriteLine("operation  <=");
            var b11 = 3;
            var b12 = 5;
            bool c5 = b7 <= b8;
            Console.WriteLine($"{b11}<={b12} result {5}");
            Console.WriteLine("Logical operations");
            Console.WriteLine("operation  |");
            bool c6 = (b1 > b2) | (b3 > b4);
            bool c7 = (b1 > b2) | (b3 < b4); ;
            Console.WriteLine($"{b1}>{b2}- false, {b3}>{b5} - true , result {c6}");
            Console.WriteLine($"{b1}<{b2}- false, {b3}>{b5} - false , result {c7}");
            Console.WriteLine("operation  ||");
            bool c8 = (b1 > b2) || (b3 > b4);
            bool c9 = (b1 > b2) || (b3 < b4); ;
            Console.WriteLine($"{b1}>{b2}- false, {b3}>{b5} - true , result {c8}");
            Console.WriteLine($"{b1}>{b2}- false, {b3}<{b5} - false , result {c9}");
            Console.WriteLine("operation  &");
            bool c10 = (b1 < b2) & (b3 > b4);
            bool c11 = (b1 > b2) & (b3 > b4); ;
            Console.WriteLine($"{b1}<{b2}- true, {b3}>{b5} - true , result {c10}");
            Console.WriteLine($"{b1}>{b2}- false, {b3}>{b5} - true , result {c11}");
            Console.WriteLine("operation  &&");
            bool c12 = (b1 < b2) && (b3 > b4);
            bool c13 = (b1 > b2) &&(b3 > b4); ;
            Console.WriteLine($"{b1}<{b2}- true, {b3}>{b5} - true , result {c12}");
            Console.WriteLine($"{b1}>{b2}- false, {b3}>{b5} - true , result {c13}");
            Console.WriteLine("operation  ^");
            bool c14 = (b1 < b2) ^ (b3 > b4);
            bool c15 = (b1 > b2) ^ (b3 > b4); 
            bool c16= (b1 > b2) ^ (b3 < b4);
            Console.WriteLine($"{b1}<{b2}- true, {b3}>{b5} - true , result {c14}");
            Console.WriteLine($"{b1}>{b2}- false, {b3}>{b5} - true , result {c15}"); 
            Console.WriteLine($"{b1}>{b2}- false, {b3}<{b5} - false , result {c15}");
            Console.WriteLine("operation  ^");
            bool c17 = true;
            bool d= !c17;
            Console.WriteLine($"{d}");
            Console.ReadKey();
        }
    }
}
       


       
