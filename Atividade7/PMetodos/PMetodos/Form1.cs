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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopiarEColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção - Copiar");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chamou opção - Colar");
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio2"].Activate();
            }
            else
            {
                frmExercicio2 obj2 = new frmExercicio2();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }
        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio3"].Activate();
            }
            else
            {
                frmExercicio3 obj3 = new frmExercicio3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void Exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio4"].Activate();
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }

        private void Exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                MessageBox.Show("Form já existe");
                Application.OpenForms["frmExercicio5"].Activate();
            }
            else
            {
                frmExercicio5 obj5 = new frmExercicio5();
                obj5.MdiParent = this;
                obj5.WindowState = FormWindowState.Maximized;
                obj5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}   

