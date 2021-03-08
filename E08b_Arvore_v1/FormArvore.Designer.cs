namespace E08b_Arvore_v1
{
    partial class FormArvore
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
            this.numericUpDownArvore = new System.Windows.Forms.NumericUpDown();
            this.buttonFazArvore = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelArvore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArvore)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownArvore
            // 
            this.numericUpDownArvore.Location = new System.Drawing.Point(37, 41);
            this.numericUpDownArvore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownArvore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownArvore.Name = "numericUpDownArvore";
            this.numericUpDownArvore.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownArvore.TabIndex = 0;
            this.numericUpDownArvore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonFazArvore
            // 
            this.buttonFazArvore.Location = new System.Drawing.Point(37, 95);
            this.buttonFazArvore.Name = "buttonFazArvore";
            this.buttonFazArvore.Size = new System.Drawing.Size(120, 23);
            this.buttonFazArvore.TabIndex = 1;
            this.buttonFazArvore.Text = "FazArvore";
            this.buttonFazArvore.UseVisualStyleBackColor = true;
            this.buttonFazArvore.Click += new System.EventHandler(this.buttonFazArvore_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(37, 124);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(120, 23);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelArvore
            // 
            this.labelArvore.AutoSize = true;
            this.labelArvore.Location = new System.Drawing.Point(225, 41);
            this.labelArvore.Name = "labelArvore";
            this.labelArvore.Size = new System.Drawing.Size(16, 13);
            this.labelArvore.TabIndex = 3;
            this.labelArvore.Text = "...";
            // 
            // FormArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 195);
            this.Controls.Add(this.labelArvore);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFazArvore);
            this.Controls.Add(this.numericUpDownArvore);
            this.Name = "FormArvore";
            this.Text = "Arvore";
            this.Load += new System.EventHandler(this.FormArvore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArvore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownArvore;
        private System.Windows.Forms.Button buttonFazArvore;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelArvore;
    }
}

