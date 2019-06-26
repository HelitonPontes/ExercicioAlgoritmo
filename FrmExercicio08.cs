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
    public partial class FrmExercicio08 : Form
    {
        public FrmExercicio08()
        {
            InitializeComponent();
        }

        Exercicio08Array EXA = new Exercicio08Array();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtArray1.Clear();
            txtArray2.Clear();
            txtArray3.Clear();
            txtArray4.Clear();
            txtArray5.Clear();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] nome = new string[5];

            nome[0] = txtArray1.Text;
            nome[1] = txtArray2.Text;
            nome[2] = txtArray3.Text;
            nome[3] = txtArray4.Text;
            nome[4] = txtArray5.Text;


            lblValor1.Text = nome[0];
            lblValor2.Text = nome[1];
            lblValor3.Text = nome[2];
            lblValor4.Text = nome[3];
            lblValor5.Text = nome[4];

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
