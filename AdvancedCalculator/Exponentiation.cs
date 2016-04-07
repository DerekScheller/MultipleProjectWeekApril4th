using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Exponentiation : IDoMath
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = firstNumber;
            for(int i = 1; i < secondNumber; i++)
            {
                answer += answer * firstNumber;
            }
            return answer;
        }
    }
}
