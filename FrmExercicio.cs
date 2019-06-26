using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosAlgoritmos
{
    public partial class FrmExercicio : Form
    {
        public FrmExercicio()
        {
            InitializeComponent();
        }

        private void exeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio01 frm = new FrmExercicio01();
            frm.ShowDialog();
        }

        private void exercicio02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio02 frm = new FrmExercicio02();
            frm.ShowDialog();
        }

        private void exercicio03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio03 frm = new FrmExercicio03();
            frm.ShowDialog();
        }

        private void exercicio04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio04 frm = new FrmExercicio04();
            frm.ShowDialog();

        }

        private void exercicio05ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmExercicio05 frm = new FrmExercicio05();
            frm.ShowDialog();
        }

        private void exercicio06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio06 frm = new FrmExercicio06();
            frm.ShowDialog();

        }

        private void exercicio07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio07 frm = new FrmExercicio07();
            frm.ShowDialog();
        }

        private void exercicio08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio08 frm = new FrmExercicio08();
            frm.ShowDialog();
        }

        private void exercicio09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio09List frm = new FrmExercicio09List();
            frm.ShowDialog();
        }

        private void exercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio10 frm = new FrmExercicio10();
            frm.ShowDialog();
        }

        private void exercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExercicio11 frm = new FrmExercicio11();
            frm.Show();
        }
    }
}
