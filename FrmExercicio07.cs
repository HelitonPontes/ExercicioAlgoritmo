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
    public partial class FrmExercicio07 : Form
    {
        public FrmExercicio07()
        {
            InitializeComponent();
        }

        Exercicio07 EX = new Exercicio07();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNomealuno.Clear();
            txtNota01.Clear();
            txtNota02.Clear();
            txtNota03.Clear();
            txtNota04.Clear();
            txtResultadoMédia.Clear();
            txtMedia.Clear();
            lblResultado.Text = "XXXX";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            

            EX.Nota01 = float.Parse(txtNota01.Text);
            EX.Nota02 = float.Parse(txtNota02.Text);
            EX.Nota03 = float.Parse(txtNota03.Text);
            EX.Nota04 = float.Parse(txtNota04.Text);
            EX.NomeAluno = txtNomealuno.Text;

            EX.Calcular();

            txtMedia.Text = Convert.ToString(EX.Media);
            txtResultadoMédia.Text = Convert.ToString (EX.StrResultado);

            lblResultado.Text = "O nome Aluno: " + EX.NomeAluno + ", Média: " + EX.Media + ", Resultado: " + EX.StrResultado;


            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
