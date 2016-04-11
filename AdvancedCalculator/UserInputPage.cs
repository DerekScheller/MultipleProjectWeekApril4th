using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class UserInputPage
    {
        List<char> ValidCharList;
        List<char> OperatorList;
        List<char> SanitizedUserInput;
        char Operator;
        List<double> TwoNumberList;
        public UserInputPage()
        {
            ValidCharList = new List<char>();
            OperatorList = new List<char>();
            SanitizedUserInput = new List<char>();
            TwoNumberList = new List<double>();
        }
        public void Run()
        {
            BreakToRowData(GetUserInput());
            GetBrokeInput();
        }
        public char SendOperator()
        {
            return Operator;
        }
        public List<double> SendNumbers()
        {
            return TwoNumberList;
        }
        public string GetUserInput()
        {
            PopulateCharList();
            Console.WriteLine("I am an equation solving calculator.");
            Console.WriteLine("Remember you can add +, subtract -, multiply *, divide / or exponetiate ^.");
            Console.WriteLine("\nPlease enter your a mathmatical equation for me.");
            string userInputEquation = Console.ReadLine();
            return userInputEquation;
        }
        public void PopulateCharList()
        {
            ValidCharList.Add('1');
            ValidCharList.Add('2');
            ValidCharList.Add('3');
            ValidCharList.Add('4');
            ValidCharList.Add('5');
            ValidCharList.Add('6');
            ValidCharList.Add('7');
            ValidCharList.Add('8');
            ValidCharList.Add('9');
            ValidCharList.Add('0');
            OperatorList.Add('+');
            OperatorList.Add('-');
            OperatorList.Add('/');
            OperatorList.Add('^');
            OperatorList.Add('*');
        }
        public void BreakToRowData(string equation)
        {
            char previousCharacter = ' ';
            foreach (char character in equation)
            {
                if (OperatorList.Contains(character) && !OperatorList.Contains(previousCharacter))
                {
                    SanitizedUserInput.Add(character);
                    previousCharacter = character;
                }
                else if (ValidCharList.Contains(character))
                {
                    SanitizedUserInput.Add(character);
                    previousCharacter = character;
                }
            }
        }
        public void GetBrokeInput()
        {
            StringBuilder number = new StringBuilder();
            foreach (char Character in SanitizedUserInput)
            {
                if (ValidCharList.Contains(Character))
                {
                    number.Append(Character);
                }
                else if (OperatorList.Contains(Character))
                {
                    Operator = Character;
                    TwoNumberList.Add(Convert.ToDouble(number.ToString()));
                    number.Clear();
                }
            }
            TwoNumberList.Add(Convert.ToDouble(number.ToString()));
        }
    }
}
