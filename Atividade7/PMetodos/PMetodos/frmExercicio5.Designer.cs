namespace PMetodos
{
    partial class frmExercicio5
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnSorteio = new System.Windows.Forms.Button();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(107, 26);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(187, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(107, 56);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(187, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // BtnSorteio
            // 
            this.BtnSorteio.Location = new System.Drawing.Point(234, 149);
            this.BtnSorteio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSorteio.Name = "BtnSorteio";
            this.BtnSorteio.Size = new System.Drawing.Size(98, 42);
            this.BtnSorteio.TabIndex = 2;
            this.BtnSorteio.Text = "Sorteio";
            this.BtnSorteio.UseVisualStyleBackColor = true;
            this.BtnSorteio.Click += new System.EventHandler(this.BtnSorteio_Click);
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(39, 29);
            this.lblNumero1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(57, 13);
            this.lblNumero1.TabIndex = 3;
            this.lblNumero1.Text = "1° Número";
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(39, 58);
            this.lblNumero2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(57, 13);
            this.lblNumero2.TabIndex = 4;
            this.lblNumero2.Text = "2° Número";
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.BtnSorteio);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button BtnSorteio;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
    }
}