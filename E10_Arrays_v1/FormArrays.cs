using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E10_Arrays_v1
{
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        List <ClassArray > classArraysList = new List <ClassArray >();

        private void buttonApply_Click(object sender, EventArgs e)
        {

            ClassArray class01 = new ClassArray();
            
            class01.Nome = textBoxGetName.Text;

            //class01.adicionar();
            classArraysList.Add(class01);


            labelName.Text = class01.Nome;
        }
    }
}
