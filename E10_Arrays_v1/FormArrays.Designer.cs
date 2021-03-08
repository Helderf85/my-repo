namespace E10_Arrays_v1
{
    partial class Arrays
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
            this.labelGetName = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxGetName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGetName
            // 
            this.labelGetName.AutoSize = true;
            this.labelGetName.Location = new System.Drawing.Point(53, 81);
            this.labelGetName.Name = "labelGetName";
            this.labelGetName.Size = new System.Drawing.Size(55, 13);
            this.labelGetName.TabIndex = 0;
            this.labelGetName.Text = "Get Name";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(102, 127);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxGetName
            // 
            this.textBoxGetName.Location = new System.Drawing.Point(143, 81);
            this.textBoxGetName.Name = "textBoxGetName";
            this.textBoxGetName.Size = new System.Drawing.Size(100, 20);
            this.textBoxGetName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(56, 182);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(19, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "....";
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 319);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxGetName);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelGetName);
            this.Name = "Arrays";
            this.Text = "Arrays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGetName;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxGetName;
        private System.Windows.Forms.Label labelName;
    }
}

