using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08a_Tabuada_v1
{
    class Tabuada
    {

        #region Properties

        private int numero;
        public int [] resultado= new int[10] ;
       
        public int X = 1;

        public int[] intervalo = { 1, 2, 3, 4, 5, 6, 9, 8, 7, 10 };

        #endregion

       public Tabuada (int numero)
        {
            this.numero = numero;
            //this.resultado = resultado;
            
        }

        #region Methots

        public void Calcular()
        {

            for (int i =0; i< intervalo .Length ; i++)
            {

                resultado [i] = numero * intervalo[i];
                //numero * intervalo[i];
                //return numero ;

            }

        }

        #endregion

    }
}
