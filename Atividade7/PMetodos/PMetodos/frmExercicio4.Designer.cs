namespace PMetodos
{
    partial class frmExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnPosicaoBranco = new System.Windows.Forms.Button();
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnTotalLetras = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(153, 45);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(529, 94);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnPosicaoBranco
            // 
            this.btnPosicaoBranco.Location = new System.Drawing.Point(368, 323);
            this.btnPosicaoBranco.Name = "btnPosicaoBranco";
            this.btnPosicaoBranco.Size = new System.Drawing.Size(135, 53);
            this.btnPosicaoBranco.TabIndex = 1;
            this.btnPosicaoBranco.Text = "Posição do 1° caracter branco";
            this.btnPosicaoBranco.UseVisualStyleBackColor = true;
            this.btnPosicaoBranco.Click += new System.EventHandler(this.BtnPosicaoBranco_Click);
            // 
            // btnNumericos
            // 
            this.btnNumericos.Location = new System.Drawing.Point(100, 323);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(135, 53);
            this.btnNumericos.TabIndex = 2;
            this.btnNumericos.Text = "Total Numeros";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnTotalLetras
            // 
            this.btnTotalLetras.Location = new System.Drawing.Point(606, 323);
            this.btnTotalLetras.Name = "btnTotalLetras";
            this.btnTotalLetras.Size = new System.Drawing.Size(135, 53);
            this.btnTotalLetras.TabIndex = 3;
            this.btnTotalLetras.Text = "Total letras";
            this.btnTotalLetras.UseVisualStyleBackColor = true;
            this.btnTotalLetras.Click += new System.EventHandler(this.BtnTotalLetras_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(42, 45);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(48, 20);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnTotalLetras);
            this.Controls.Add(this.btnNumericos);
            this.Controls.Add(this.btnPosicaoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnPosicaoBranco;
        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnTotalLetras;
        private System.Windows.Forms.Label lblTexto;
    }
}