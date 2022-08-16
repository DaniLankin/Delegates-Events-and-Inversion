using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_Delegates.Services
{
    public class NotificationService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPreformedEventArgs args)
        {
            Console.WriteLine("Notification result " + args.MathResult);
        }
    }
}
