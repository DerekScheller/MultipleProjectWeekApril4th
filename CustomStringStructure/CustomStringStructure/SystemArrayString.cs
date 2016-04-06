using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class SystemArrayString : ICustomeString
    {
        char[] StringToManipulate;
        public SystemArrayString(string InputString)
        {
            StringToManipulate = new char[InputString.Count()];
            int i = 0;
            foreach (char Character in InputString)
            {
                StringToManipulate[i] = Character;
                i++;
            }         
        }
        public override string ToString()
        {
            string ReturnString = "";
            foreach (char Character in StringToManipulate)
            {
                ReturnString += Character;
            }
            return ReturnString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char[] tempArray = new char[StringToManipulate.Count() + stringToInsert.Count()];
            int i = 0;
            int j = 0;
            for (int TempIndex = 0; TempIndex < StringToManipulate.Count() + stringToInsert.Count(); TempIndex++)
            {
                if(TempIndex >= startIndex && TempIndex < startIndex + stringToInsert.Count())
                {                    
                tempArray[TempIndex] = stringToInsert.ElementAt(i);
                    i++;
                }
                else
                {
                    tempArray[TempIndex] = StringToManipulate[j];
                    j++;
                }
            }
            StringToManipulate = tempArray;
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] ShortenedString = new char[StringToManipulate.Count() - numCharsToRemove];
            int i;
            for(i = 0; i < startIndex; i++)
            {
                ShortenedString[i] = StringToManipulate[i];
            }
            for (int j = startIndex + numCharsToRemove; j < StringToManipulate.Count(); j++)
            {
                ShortenedString[i] = StringToManipulate[j];
                i++;
            }
            StringToManipulate = ShortenedString;
        }
        public int Length()
        {
            int Length = StringToManipulate.Count();
            return Length;
        }
    }
}
