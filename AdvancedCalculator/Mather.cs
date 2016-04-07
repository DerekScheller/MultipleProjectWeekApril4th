using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    abstract class Mather
    {
        private List<IDoMath> _action = new List<IDoMath>();
        public List<IDoMath> Action
        {
            get { return _action; }
        }
        public abstract void EquationCreator();
    }
}