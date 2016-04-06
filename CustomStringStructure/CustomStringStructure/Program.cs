using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    class Program
    {
        static void Main(string[] args)
   {
            string b = "red 6 Stripe";
            string c = "revolution";
            string f = "fun";
            string j = "Dolphin";
            SystemString test = new SystemString(b);
            SystemArrayString test1 = new SystemArrayString(c);
            SystemLinkedListString test2 = new SystemLinkedListString(f);
            CustomLinkedListString test3 = new CustomLinkedListString(j);
            SortedList<int, ICustomeString> sortedStringList = new SortedList<int, ICustomeString>();
            sortedStringList.Add(test.Length(), test);
            sortedStringList.Add(test1.Length(), test1);
            sortedStringList.Add(test2.Length(), test2);
            sortedStringList.Add(test3.Length(), test3);

            foreach(ICustomeString StringClass in sortedStringList.Values)
            {
                Console.WriteLine(StringClass.Length());
                StringClass.Insert(2, j);
                Console.WriteLine(StringClass.ToString());
                StringClass.Remove(5, 5);
                Console.WriteLine(StringClass.ToString());
            }
            Console.ReadLine();




            //            Assignment 3:*​ 
            //Create a custom string structure:

            //    Create an ICustomString interface with the following custom functions:
            //        A constructor that takes a plain old System.string to initialize the structure
            //        string ToString()
            //        void Insert(string stringToInsert)
            //        void Remove(int startIndex, int numCharsToRemove)
            //        int Length()

            //    Inherit from the ICustomString interface to implement the following custom string subclasses:

            //        SystemString
            //            Underlying structure: System.string
            //            Piggyback off System.string's built-in functionality to implement ICustomString's functions

            //        SystemArrayString
            //            Underlying structure: System.array
            //            Each index of the underlying array holds one character

            //        SystemLinkedListString
            //            Underlying structure: System.Collections.Generic.LinkedList
            //            Each node of the underlying C# LinkedList holds one character

            //        CustomLinkedListString
            //            Underlying structure: your own custom linked list
            //            Each node of the underlying custom linked list structure holds one character

            //Create a System.Collections.SortedList, SortedList<ICustomString> sortedStringList, 
            //sorted by the length of each string element, populated by a mix of each of the ICustomString subclasses
        }
    }
}
