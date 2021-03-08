using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_Rock__Paper__or_Scissors_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            RockPaperScissors rock01 = new RockPaperScissors();

            rock01.EscolhaUtilizador();

            rock01.EscolhaComputador();

            rock01.Calcular();

        }
    }
}
