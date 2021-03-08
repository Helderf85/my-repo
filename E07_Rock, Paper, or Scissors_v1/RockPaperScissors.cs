using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_Rock__Paper__or_Scissors_v1
{
    class RockPaperScissors
    {

        public string escUtilizador { get; set; }
        public string escComputador { get; set; }
        public int randomNumber { get; set; }
        public int bola { get; set; }

        public void EscolhaUtilizador()
        {



            while (escUtilizador != "papel" && escUtilizador != "tesoura" && escUtilizador != "pedra")
            {
                Console.WriteLine("Escolha papel, tesoura ou pedra");
                escUtilizador = Console.ReadLine().ToLower();

                if (escUtilizador == "papel" || escUtilizador == "tesoura" || escUtilizador == "pedra")
                {
                    Console.WriteLine("Escolheu " + escUtilizador + " !");
                }
                else
                {
                    Console.WriteLine("Escreva novamente!");
                }
                Console.ReadKey();
            }

        }

        public void EscolhaComputador()
        {

            Console.WriteLine("O computador agora vai escolher");
            Console.ReadKey();
            Random random = new Random();
            randomNumber = random.Next(1, 3);

            if (randomNumber == 1)
            {
                escComputador = "papel";
                Console.WriteLine("Escolha do PC " + escComputador + " !");
            }
            else if (randomNumber == 2)
            {
                escComputador = "tesoura";
                Console.WriteLine("Escolha do PC " + escComputador + " !");
            }
            else if (randomNumber == 3)
            {
                escComputador = "pedra";
                Console.WriteLine("Escolha do PC " + escComputador + " !");
            }


            Console.ReadKey();
        }

        public void Calcular()
        {
            if (escComputador == "papel" && escUtilizador == "tesoura")
            {
                Console.WriteLine("you win");
            }
            else if (escComputador == "tesoura" && escUtilizador == "papel")
            {
                Console.WriteLine("you lose");
            }
            else if (escComputador == "tesoura" && escUtilizador == "pedra")
            {
                Console.WriteLine("you lose");
            }
            else if (escComputador == "pedra" && escUtilizador == "tesoura")
            {
                Console.WriteLine("you win");
            }
            else if (escComputador == "papel" && escUtilizador == "pedra")
            {
                Console.WriteLine("you win");
            }
            else if (escComputador == "pedra" && escUtilizador == "papel")
            {
                Console.WriteLine("you lose");
            }
            Console.ReadKey();
        }
    }
}
