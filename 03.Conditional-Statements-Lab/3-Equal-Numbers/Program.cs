﻿using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            
            if (isEqual(num1, num2, num3))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static bool isEqual(int num1, int num2, int num3)
        {
            bool isEqualNum = false;

            if(num1 == num2 && num2 == num3)
            {
                isEqualNum = true;
            }

            return isEqualNum;
        }
    }
}
