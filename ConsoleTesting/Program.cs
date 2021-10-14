﻿using System;
using TaskSolutions;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK ONE

            TaskOne taskOne = new TaskOne(2, 0, 1, 1);

            Console.WriteLine(taskOne.SumDigits());
            Console.WriteLine("-----------------");

            foreach (var c in taskOne.ReverseDigits())
            {
                Console.Write(c);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------");

            foreach (var c in taskOne.SwitchLastDigitToFirst())
            {
                Console.Write(c);
                Console.WriteLine();
            }
            
            Console.WriteLine("-----------------");

            foreach (var c in taskOne.SwitchLastDigitToFirst())
            {
                Console.Write(c);
                Console.WriteLine();
            }

            Console.WriteLine("-----------------");

            //TASK TWO
            TaskTwo taskTwo = new TaskTwo(1,9);

            taskTwo.MultiplyRandomNumber();

            Console.WriteLine("-----------------");

            //TASK THREE
            TaskThree taskThree = new();

            Console.WriteLine(taskThree.ComputeSum(2, 2));
        }
    }
}
