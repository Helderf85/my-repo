namespace E08a_Tabuada_v1
{
    partial class FormTabuada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumero
            // 
            this.numericUpDownNumero.Location = new System.Drawing.Point(35, 12);
            this.numericUpDownNumero.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumero.Name = "numericUpDownNumero";
            this.numericUpDownNumero.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumero.TabIndex = 1;
            this.numericUpDownNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(35, 54);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(120, 23);
            this.buttonCalcular.TabIndex = 2;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(35, 103);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(16, 13);
            this.labelResultado.TabIndex = 3;
            this.labelResultado.Text = "...";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(38, 161);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(117, 23);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // FormTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 209);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numericUpDownNumero);
            this.Name = "FormTabuada";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.FormTabuada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumero;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

