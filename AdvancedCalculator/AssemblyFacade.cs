using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class AssemblyFacade
    {
        private Mather math;
        private UserInputPage getinfo;
        char operationChar;
        List<double> twoNumbers;
        double numberOne;
        double numberTwo;
        Addition add;
        Subtraction sub;
        Division div;
        Multiplication multi;
        Exponentiation expo;

        public AssemblyFacade()
        {  
            getinfo = new UserInputPage();
            math = new Mather();
            add = new Addition();
            sub = new Subtraction();
            div = new Division();
            multi = new Multiplication();
            expo = new Exponentiation();
        }
        public void Run()
        {
            getinfo.Run();
            operationChar = getinfo.SendOperator();
            AnswerPrinter(SwitchToOperate(NumberOne, NumberTwo, operationChar));
            Run();
        }
        double NumberOne { 
            get {
                twoNumbers = getinfo.SendNumbers();
                numberOne = twoNumbers.ElementAt(0);
                return numberOne; } }
        double NumberTwo {
            get {
                twoNumbers = getinfo.SendNumbers();
                numberTwo = twoNumbers.ElementAt(1);
                return numberTwo; }
             }
        public double SwitchToOperate(double firstNumber, double secondNumber, char opCharacter)
        {
            double answer;
            switch (opCharacter)
            {
                case '+':
                    answer = math.DoMath(firstNumber, secondNumber, add);
                    return answer;
                case '-':
                    answer = math.DoMath(firstNumber, secondNumber, sub);
                    return answer;
                case '/':
                    answer = math.DoMath(firstNumber, secondNumber, div);
                    return answer;
                case '*':
                    answer = math.DoMath(firstNumber, secondNumber, multi);
                    return answer;
                case '^':
                    answer = math.DoMath(firstNumber, secondNumber, expo);
                    return answer;
                default:
                    Console.WriteLine("An Error Occured While Attempting Your Operation.");
                    return 0;
            }
        }
        public void AnswerPrinter(double answer)
        {
            Console.WriteLine(answer);
        }

    }
}
