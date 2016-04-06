using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class CustomLinkedListString : ICustomeString
    {
        CustomList StringToManipulate;
        public CustomLinkedListString(string InputString)
        {
            StringToManipulate = new CustomList();
            foreach (char Character in InputString)
            {
                StringToManipulate.AddLast(Character);
            }
        }
        public override string ToString()
        {
            CustomNode current = StringToManipulate.head;
            string StringToReturn = "";
            while (current != null)
            {
                StringToReturn += current.data;
                current = current.next;
            }
            return StringToReturn;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            if (0 <= startIndex || startIndex <= StringToManipulate.Count)
            {
                int j = 0;
                CustomNode current = StringToManipulate.head;
                CustomList tempList = new CustomList();
                while (current != null)
                {
                    if (j != StringToManipulate.Count && j != startIndex)
                    {
                        tempList.AddLast(current.data);
                        current = current.next;
                    }
                    j++;
                    if (j >= startIndex && j <= startIndex + stringToInsert.Length)
                    {
                        foreach (char Character in stringToInsert)
                        {
                            tempList.AddLast(Character);
                            j++;
                        }
                    }

                }
                StringToManipulate = tempList;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            if (0 <= startIndex || (startIndex < StringToManipulate.Count && startIndex + numCharsToRemove < StringToManipulate.Count))
            {
                int j = 0;
                CustomNode current = StringToManipulate.head;
                CustomList tempList = new CustomList();
                while (current != null)
                {
                    while (j >= startIndex && j < startIndex + numCharsToRemove)
                    {
                        current = current.next;
                        j++;
                        if (current == null) break;
                    }
                    if (current != null)
                    {
                        tempList.AddLast(current.data);
                        current = current.next;
                        j++;
                    }
                }
                StringToManipulate = tempList;
            }
            else
            {
                Console.WriteLine("Invalid Index or An Attempt to Remove Beyond The String Length");
            }
        }
        public int Length()
        {
            int length = 0;
            CustomNode current = StringToManipulate.head;
            while (current != null)
            {
                current = current.next;
                length++;
            }
            return length;
        }
    }
}
