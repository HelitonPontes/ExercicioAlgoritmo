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
    public partial class FrmExercicio01 : Form
    {
        public FrmExercicio01()
        {
            InitializeComponent();
        }

        Exercicio01 EX = new Exercicio01();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            txtDimensão.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EX.Altura = float.Parse(txtAltura.Text);
            EX.Base1 = float.Parse(txtBase.Text);

            EX.Dimensão();


            txtDimensão.Text = Convert.ToString(EX.Resultado);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
