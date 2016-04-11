using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Mather
    {
        IDoMath action = null;
        public double DoMath(double firstNumber, double secondNumber, IDoMath Operator)
        {
            this.action = Operator;
            double answer = action.Operation(firstNumber, secondNumber);
            return answer;
        }
    }
}