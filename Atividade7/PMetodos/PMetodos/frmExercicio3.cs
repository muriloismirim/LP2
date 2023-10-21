using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemover1_Click(object sender, EventArgs e)
        {
            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text,StringComparison.OrdinalIgnoreCase);
            while(posicao>=0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + 
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, 
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void BtnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {
            // transformando string em array de char
            char[] vetorC = txtPalavra1.Text.ToCharArray();
            // inverte o array
            Array.Reverse(vetorC);
            txtPalavra2.Text = "";
            //foreach (char C in vetorC)
               // txtPalavra2.Text += vetorC;

           txtPalavra2.Text = new string(vetorC);
           // txtPalavra2.Text = vetorC.ToString();
        }
    }
}
