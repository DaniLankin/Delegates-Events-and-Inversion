// See https://aka.ms/new-console-template for more information
using CSHARP_Delegates;
using System;

namespace CSHARP_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService service = new MathService();
            new List<IMathPerformedService>
            {
                new LoginService(), new NotificationService()
            }.ForEach(serv => service.MathPreformed += serv.OnMathPerformed);
            service.AddNumbers(5.79, 13.2);
            service.MultiplyNumbers(5.79, 13.2);
        } 

        
    }
}
