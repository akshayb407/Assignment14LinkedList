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
            Console.WriteLine("Initial Sequence is :" + list);
            list.Pop(0);
            Console.WriteLine("final sequence post to the pop operation: " + list);

        }
    }
}
