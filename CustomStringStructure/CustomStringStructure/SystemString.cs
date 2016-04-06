using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringStructure
{
    public class SystemString : ICustomeString
    {
        string StringToManipulate;
        public SystemString(string inputString)
        {
            StringToManipulate = inputString;
        }
        public override string ToString()
        {
            return StringToManipulate;
        }
        public void Insert(int startIndex, string StringToInsert)
        {
            StringToManipulate = StringToManipulate.Insert(startIndex, StringToInsert);
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            StringToManipulate = StringToManipulate.Remove(startIndex, numCharsToRemove);
        }
        public int Length()
        {
            int StringLength = StringToManipulate.Length;
            return StringLength;
        }
    }
}
