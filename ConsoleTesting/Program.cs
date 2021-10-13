﻿using System;
using TaskSolutions;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne taskOne = new TaskOne(2,0,1,1);

            Console.WriteLine(taskOne.SumDigits());
            Console.WriteLine("-----------------");
            
            foreach (var c in taskOne.ReverseDigits())
            {
                Console.Write(c);
            }

            Console.WriteLine("-----------------");
        }
    }
}
