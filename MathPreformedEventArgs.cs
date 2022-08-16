using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Delegates
{
    public class MathPreformedEventArgs : EventArgs
    {
        public double MathResult { get; set; }
        public MathPreformedEventArgs(double mathResult)
        {
            MathResult = mathResult;
        }
    }
}
