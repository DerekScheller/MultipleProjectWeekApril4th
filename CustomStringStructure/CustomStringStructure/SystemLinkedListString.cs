using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class SystemLinkedListString : ICustomeString
    {
        LinkedList<char> StringToManipulate;
        public SystemLinkedListString(string InputString)
        {
            StringToManipulate = new LinkedList<char>();
            foreach(char Character in InputString)
            {
                StringToManipulate.AddLast(Character);
            }
        }
       public override string ToString()
        {
            string StringToReturn = "";
            foreach(char Character in StringToManipulate)
            {
                StringToReturn += Character;
            }
            return StringToReturn;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            LinkedList<char> tempString = new LinkedList<char>();
            int i = 0;
            int j = 0;
            for (int indexTotal = 0; indexTotal < StringToManipulate.Count + stringToInsert.Length; indexTotal++)
            {
                if (indexTotal >= startIndex && indexTotal < startIndex + stringToInsert.Length)
                {
                    tempString.AddLast(stringToInsert.ElementAt(j));
                    j++;
                }
                else
                {
                    tempString.AddLast(StringToManipulate.ElementAt(i));
                    i++;
                }
            }
            StringToManipulate = tempString;
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            LinkedList<char> tempString = new LinkedList<char>();
            int i;
            for(i = 0; i < StringToManipulate.Count; i++)
            {
             if(i < startIndex)
                {
                    tempString.AddLast(StringToManipulate.ElementAt(i));
                }
             else if (i >= startIndex + numCharsToRemove)
                {
                    tempString.AddLast(StringToManipulate.ElementAt(i));
                }
            }
            StringToManipulate = tempString;
        }
        public int Length()
        {
            int length = StringToManipulate.Count();
            return length;
        }
    }
}
