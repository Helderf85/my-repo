using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Ball8_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            Ball8 ball801 = new Ball8();

            ball801.VerNome();

            ball801.UserQuestion();

            ball801.verBola();

            ball801.MostrarFrase();


            Console.ReadKey();
        }
    }
}
