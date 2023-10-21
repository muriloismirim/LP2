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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int contador =0;

            for(var i=0;i<rchtxtFrase.Text.Length;i++)
            {
                if (char.IsNumber(rchtxtFrase.Text[i]))
                    contador++;
            }

            MessageBox.Show($"A frase tem {contador} números");


        }

        private void BtnPosicaoBranco_Click(object sender, EventArgs e)
        {
            int contador=0,posicao=0;

            while (contador<rchtxtFrase.Text.Length)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[contador]))
                {
                    posicao = contador + 1;
                    break;
                }
                contador++;
            }
            MessageBox.Show($"O primeiro caracter em branco está na posição {posicao}");
        }

        private void BtnTotalLetras_Click(object sender, EventArgs e)
        {
            int num=0;
            foreach(var i in rchtxtFrase.Text )
            {
                if (char.IsLetter(i))
                    num++;

            }
            MessageBox.Show($"O total de letras é {num}");
        }
    }
}
