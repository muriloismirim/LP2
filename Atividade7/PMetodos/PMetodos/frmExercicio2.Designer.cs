namespace PMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(181, 39);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(574, 26);
            this.txtPalavra1.TabIndex = 0;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(181, 80);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(574, 26);
            this.txtPalavra2.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(111, 313);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(125, 57);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verificar Iguais";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.BtnVerifica_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(346, 313);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(125, 57);
            this.btnInserir1.TabIndex = 3;
            this.btnInserir1.Text = "Inserir 1";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.BtnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(595, 313);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(125, 57);
            this.btnInserir2.TabIndex = 4;
            this.btnInserir2.Text = "Inserir 2";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.BtnInserir2_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(66, 45);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(66, 86);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 20);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Button btnInserir2;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}