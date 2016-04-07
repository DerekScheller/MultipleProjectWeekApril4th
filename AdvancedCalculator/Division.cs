using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Division : IDoMath
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = 0;
            if(secondNumber != 0)
            {
            answer = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("You can not divide by ZERO");
            }
            return answer;
        }
    }
}
