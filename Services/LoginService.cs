using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Delegates.Services
{
    public class LoginService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPreformedEventArgs args)
        {
            Console.WriteLine("Logging result " + args.MathResult);
        }
    }
}
