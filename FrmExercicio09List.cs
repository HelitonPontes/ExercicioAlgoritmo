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
    public partial class FrmExercicio09List : Form
    {
        public FrmExercicio09List()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtList1.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> Nome = new List<string>();

        

        Nome.Add(txtList1.Text);



            lblValor1.Text = Convert.ToString(Nome);



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
