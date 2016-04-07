using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Multiplication : IDoMath
    {
        public double Operation(double firstNumber, double secondNumber)
        {
            double answer = firstNumber * secondNumber;
            return answer;
        }
    }
}
