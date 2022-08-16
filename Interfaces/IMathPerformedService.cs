using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Delegates.Interfaces
{
    public interface IMathPerformedService
    {
        void OnMathPerformed(object sender, MathPreformedEventArgs args);
    }
}
