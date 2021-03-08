using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E08a_Tabuada_v1
{
    public partial class FormTabuada : Form
    {
        public FormTabuada()
        {
            InitializeComponent();
        }

        private void FormTabuada_Load(object sender, EventArgs e)
        {

            labelResultado.Visible  = false;
            buttonLimpar.Visible = false;

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelResultado.Visible = true;
            buttonLimpar.Visible = true;

            int numero01=Convert.ToInt16(Math.Round(numericUpDownNumero.Value, 0));



            //string resultado01 = labelResultado;
            //int numero01 = Convert.ToInt16(Math.Round(numericUpDownNumero.Value, 0));
           

            Tabuada taboada01 = new Tabuada(numero01);


            //taboada01.numero = Convert.ToInt16(Math.Round(numericUpDownNumero.Value, 0));

            numero01 = Convert.ToInt16(Math.Round(numericUpDownNumero.Value, 0));


            //for (int i = 0; i < taboada01.intervalo.Length; i++)
            //{

            taboada01.Calcular();

            //int[] resultado = { 1, 2, 3, 4, 5, 6, 9, 8, 7, 10 };

            //Array.Sort(resultado);

            labelResultado.Text = string.Join("\r\n",taboada01.resultado);
            //}

            //taboada01.Calcular();


        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

            labelResultado.Text = " ";
            numericUpDownNumero.Value = 1;
            buttonLimpar.Visible = false;
        }
    }
}
