using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08b_Arvore_v1
{
    class Arvore
    {
        #region Properties
        public int valor { get; set; }
        public string Mensagem { get; set; }
        public string animais { get; set; }
        #endregion

        #region Methots
        public void criarArvore()
        {
            string[] animais = new string[5];
                

            switch (valor)
            {
                case 1:
                    Mensagem =
                       "      **     " + Environment.NewLine +
                       "       ||     " + Environment.NewLine +
                       "       ||     ";


                    break;

                case 2:
                    Mensagem =
                     "      **     " + Environment.NewLine +
                     "     ****    " + Environment.NewLine +
                     "       ||     " + Environment.NewLine +
                     "       ||     ";

                    break;

                case 3:
                    Mensagem =
                      "      **     " + Environment.NewLine +
                      "     ****    " + Environment.NewLine +
                      "    ******   " + Environment.NewLine +
                      "       ||     " + Environment.NewLine +
                      "       ||     ";
                    break;

                case 4:
                    Mensagem =
                       "      **     " + Environment.NewLine +
                       "     ****    " + Environment.NewLine +
                       "    ******   " + Environment.NewLine +
                       "   ********  " + Environment.NewLine +
                       "       ||     " + Environment.NewLine +
                       "       ||     ";
                    break;

                case 5:
                    Mensagem =
                       "      **     " + Environment.NewLine +
                       "     ****    " + Environment.NewLine +
                       "    ******   " + Environment.NewLine +
                       "   ********  " + Environment.NewLine +
                       "  ********** " + Environment.NewLine +
                       "       ||     " + Environment.NewLine +
                       "       ||     ";
                    break;

                default:
                    Mensagem = "Outro";
                    break;
            }
        }


        #endregion

    }
}
