﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += str[i];
            }
            if (str == str2)
            {
                Console.WriteLine("палиндром");
            }
            else
            {
                Console.WriteLine("не палиндром");
            }
            Console.ReadKey();
            /*string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            Console.ReadKey();*/
        }
    }
}
