using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");
            LinkedList<string> list = new LinkedList<string>();
            list.Append("56");
            list.Append("30");
            list.Append("70");
            list.Insert(2,"40");
            Console.WriteLine("final sequence post to the Insert operation: " + list);
            

        }
    }
}
