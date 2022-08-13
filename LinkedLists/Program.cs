using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");
            LinkedList<string> list = new LinkedList<string>();
         
           
           
            list.Add("56");
            list.Add("70");
            Console.WriteLine("Before insertion: " + list);
            list.Insert(1, "30");
            Console.WriteLine("Status post to Insertion: " + list);

        }
    }
}
