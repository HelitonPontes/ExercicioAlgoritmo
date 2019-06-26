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
    public partial class FrmExercicio02 : Form
    {
        public FrmExercicio02()
        {
            InitializeComponent();

        }

            Exercicio02 EX = new Exercicio02();

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtTotalEleitores.Clear();
            txtVotoBrancos.Clear();
            txtVotoNulo.Clear();
            txtPVotosValidos.Clear();
            txtVotoValido.Clear();
            txtPEleitoresVotos.Clear();
            txtPVotoNulos.Clear();
            txtPVotosBrancos.Clear();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)


        {
            EX.Eleitores = float.Parse(txtTotalEleitores.Text);
            EX.VotoBranco = float.Parse(txtVotoBrancos.Text);
            EX.VotoNulo = float.Parse ( txtVotoNulo.Text);
         

            EX.Calcular();

            txtPVotosBrancos.Text = Convert.ToString(EX.PrcVB);
            txtPVotoNulos.Text = Convert.ToString(EX.PrcVN);
            lblVotoValido.Text = Convert.ToString(EX.VotoValidos);
            txtPVotosValidos.Text = Convert.ToString(EX.PrcVV);
            txtPEleitoresVotos.Text = Convert.ToString(EX.porc);


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
