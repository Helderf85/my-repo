using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Ball8_v1
{
    class Ball8
    {

        public string  userName { get; set; }
        public string userQuestion { get; set; }
        public int randomNumber { get; set; }
        public int bola { get; set; }

        public void VerNome()
        {

            Console.WriteLine("Intruduza o seu nome:");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + " !");

        }

        public void UserQuestion()
        {

            Console.WriteLine(userName + " Qual a sua pergunta?");
            userQuestion = Console.ReadLine();
            Console.WriteLine("Press enter to roll the ball");
            Console.ReadKey();

        }

        public void  verBola ()
        {
            
            Random random = new Random();
            randomNumber = random.Next(0, 7);
            Console.WriteLine("A sua bola é: " + randomNumber);
            Console.ReadKey();

        }

        public void MostrarFrase()
        {
            /*
            if ( randomNumber == 0)
            {
                Console.WriteLine(userQuestion + " It is certain");
            }

            else if (randomNumber == 1)
            {
                Console.WriteLine(userQuestion + " It is decidedly so");
            }

            else if (randomNumber == 2)
            {
                Console.WriteLine(userQuestion + " Reply hazy try again");
            }

            else if (randomNumber == 3)
            {
                Console.WriteLine(userQuestion + " Cannot predict now");
            }

            else if (randomNumber == 4)
            {
                Console.WriteLine(userQuestion + " Do not count on it");
            }

            else if (randomNumber == 5)
            {
                Console.WriteLine(userQuestion + " My sources say no");
            }

            else if (randomNumber == 6)
            {
                Console.WriteLine(userQuestion + " Outlook not so good");
            }

            else if (randomNumber == 7)
            {
                Console.WriteLine(userQuestion + " Signs point to yes");
            }
            */
            int random = randomNumber ;

            switch (random )
            {

                case 0:

                    Console.WriteLine("It is certain");
                    
                    break;

                case 1:

                    Console.WriteLine("It is decidedly so");
                    break;

                case 2:

                    Console.WriteLine("Reply hazy try again");

                    break;

                case 3:

                    Console.WriteLine("Cannot predict now");
                    break;

                case 4:

                    Console.WriteLine("Do not count on it");

                    break;

                case 5:

                    Console.WriteLine("My sources say no");
                    break;

                case 6:

                    Console.WriteLine("Outlook not so good");

                    break;

                case 7:

                    Console.WriteLine("Signs point to yes");
                    break;
            }


        }

    }
}
