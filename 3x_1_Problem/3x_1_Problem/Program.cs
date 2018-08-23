using System;
using System.Collections.Generic;

namespace _3x_1_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (uint initValue = 1; initValue < 1000000; initValue++)
            {
                ProcessLoop(initValue);
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
        static void ProcessLoop(uint initValue)
        {
            uint value = initValue;
            // max positive int value 2,147,483,647
            //uint value = 2147483646;
            Console.WriteLine("Starting Value : {0}", value);
            List<uint> calcValues = new List<uint>();
            while (value > 1)
            {
                calcValues.Add(value);
                Console.WriteLine("{0}", value);
                value = AdjustValue(value);
            }
            calcValues.Add(value);
            Console.WriteLine("{0}", value);
        }
        static uint AdjustValue(uint value)
        {
            if (TestEven(value)) return (value/2);
            else return ((value * 3) + 1);
        }
        static bool TestEven(uint value)
        {
            if (value % 2 == 0) return true;
            else return false;
        }

    }
}
