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
    public partial class FrmExercicio03 : Form
    {
        public FrmExercicio03()
        {
            InitializeComponent();
        }

        Exercicio03 EX = new Exercicio03();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtNome.Clear();
            txtCategoria.Clear();
            lblResultado.Text = "XXXX";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EX.Idade = int.Parse(txtIdade.Text);

            EX.Nome = txtNome.Text;

            EX.Calcular();

            txtCategoria.Text = Convert.ToString(EX.Categoria);

            lblResultado.Text = Convert.ToString(EX.strResultado);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
