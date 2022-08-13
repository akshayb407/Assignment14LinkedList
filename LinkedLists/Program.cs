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
            list.Search("30");
            Console.WriteLine(list);
            
            

        }
    }
}
