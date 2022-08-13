using System;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");
            LinkedList<string> list = new LinkedList<string>();
           // list.Add("56");
          //  list.Add("30");
           // list.Add("70");
            list.Append("56");
            list.Append("30");
            list.Append("70");
            list.display();

        }
    }
}
