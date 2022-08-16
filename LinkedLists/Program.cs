using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program!");
            LinkedList<string> list = new LinkedList<string>();
            ArrayList lit = new ArrayList();
            
            lit.Add("56");
            lit.Add("30");
            lit.Add("40");
            lit.Add("70");
            lit.ToArray();
            Console.WriteLine("final sequence post to the Delete operation: " + list);

            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList contains the following values:");
            PrintIndexAndValues(lit);

            // Copies the elements of the ArrayList to a string array.
            int[] myAr = (int[])lit.ToArray(typeof(int ));

            // Displays the contents of the string array.
            Console.WriteLine("The string array contains the following values:");
            PrintIndexAndValues(lit);
        }

        public static void PrintIndexAndValues(ArrayList lit)
        {
            int i = 0;
            foreach (Object o in lit)
                Console.WriteLine("\t[{0}]:\t{1}", i++, o);
            Console.WriteLine();
        }

        public static void PrintIndexAndValues(String[] list)
        {
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, list[i]);
            Console.WriteLine();
        }
    }


}
    

