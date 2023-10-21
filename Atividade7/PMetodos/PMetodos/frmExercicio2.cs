﻿using System;
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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnVerifica_Click(object sender, EventArgs e)
        {
            if(String.Compare(txtPalavra1.Text,txtPalavra2.Text,true)==0)
            {
                MessageBox.Show("As palavras são iguais");
            }
            else
            {
                MessageBox.Show("As palavras são diferentes");
            }
        }

        private void BtnInserir1_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, metade) + txtPalavra1.Text + 
                txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length - metade);
        }

        private void BtnInserir2_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(metade, "**");
        }
    }
}
