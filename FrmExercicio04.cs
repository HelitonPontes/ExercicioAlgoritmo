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
    public partial class FrmExercicio04 : Form
    {
        public FrmExercicio04()
        {
            InitializeComponent();
        }
        Expressão Ex = new Expressão();


        //(X + 5 + 8 / 2 . 50 + 3 - Y )

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtCalcular.Clear();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

            Ex.X = float.Parse(txtX.Text);
            Ex.Y = float.Parse(txtY.Text);

            Ex.Resultado = (Ex.X + 5 + 8 / 2 * 50 + 3 - Ex.Y);

            txtCalcular.Text = Convert.ToString(Ex.Resultado);


        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
