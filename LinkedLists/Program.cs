﻿using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");
            LinkedList<string> list = new LinkedList<string>();
            list.Add("70");
            list.Add("30");
            list.Add("56");
            list.display();

        }
    }
}
