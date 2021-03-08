using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E08b_Arvore_v1
{
    public partial class FormArvore : Form
    {
        public FormArvore()
        {
            InitializeComponent();
        }

        private void FormArvore_Load(object sender, EventArgs e)
        {
            buttonLimpar.Visible  = false;
        }

        private void buttonFazArvore_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = new Size(420, 250);

            buttonLimpar.Visible  = true;

            Arvore arvore01 = new Arvore();

            arvore01.valor = Convert.ToInt16 ( numericUpDownArvore.Value) ;

            arvore01.criarArvore();
            labelArvore .Text  = arvore01 .Mensagem ;

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelArvore.Text = "";
            buttonLimpar.Visible = false;
            ActiveForm.Size = new Size(269, 234);

        }
    }
}
