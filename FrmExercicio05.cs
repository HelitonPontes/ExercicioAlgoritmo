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
    public partial class FrmExercicio05 : Form
    {
        public FrmExercicio05()
        {
            InitializeComponent();
        }

        Exercicio05 EX = new Exercicio05();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtPorcetagemReajsute.Clear();
            txtSalarioAtual.Clear();
            txtSalarioReajustado.Clear();
            txtAumento.Clear();
            lblResultado.Text = "XXXX";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EX.NomeF = txtNome.Text;
            EX.SalarioAtual = float.Parse(txtSalarioAtual.Text);
            EX.PercentualAjuste = float.Parse(txtPorcetagemReajsute.Text);

            EX.Calcula();

            txtSalarioReajustado.Text = Convert.ToString(EX.SalarioReajustado);
            txtAumento.Text = Convert.ToString(EX.QAumento);



            lblResultado.Text = "Funcionario: " + EX.NomeF + ", Salario Atual: " + EX.SalarioAtual + ", Salario Reajustado: " + EX.SalarioReajustado;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
