using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            var bytes = Base32Encoding.ToBytes("3IPVEG5CJTWT6VW4");

            var totp = new Totp(bytes);

            var result = totp.ComputeTotp();
            var remainingTime = totp.RemainingSeconds();

            Console.WriteLine(result);
            Console.WriteLine(remainingTime);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
