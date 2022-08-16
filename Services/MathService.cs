using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Delegates.Services
{
    public class MathService
    {

        public event EventHandler<MathPreformedEventArgs> MathPreformed;

        public double AddNumbers(double value1, double value2)
        {
            var result = value1 + value2;
            MathPreformed(this, new MathPreformedEventArgs(result));
            return result;
        }
        public double MultiplyNumbers(double value1, double value2)
        {
            var result = value1 * value2;
            MathPreformed(this, new MathPreformedEventArgs(result));
            return result;
        }
    }
}
