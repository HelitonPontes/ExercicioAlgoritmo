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
    public partial class FrmExercicio06 : Form
    {
        public FrmExercicio06()
        {
            InitializeComponent();
        }

        Ingredientes Ing = new Ingredientes();


      
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {

            Ing.ingrediente1 = float.Parse(txtIngre1.Text);
            Ing.ingrediente2 = float.Parse(txtIngre2.Text);
            Ing.ingrediente3 = float.Parse(txtIngre3.Text);
            Ing.ingrediente4 = float.Parse(txtIngre4.Text);
            Ing.ingrediente5 = float.Parse(txtIngre5.Text);

            Ing.ValorTotal = Ing.ingrediente1 + Ing.ingrediente2 + Ing.ingrediente3 + Ing.ingrediente4 + Ing.ingrediente5;

            txtTotal.Text = Convert.ToString(Ing.ValorTotal);

            Ing.porrcetagem = float.Parse(txtPorcetagem.Text);

            Ing.porc = Ing.ValorTotal * Ing.porrcetagem / 100;

            Ing.ValorVenda = Ing.ValorTotal + Ing.porc;

            txtValorVenda.Text = Convert.ToString(Ing.ValorVenda);

            txtLucro.Text = Convert.ToString(Ing.porc);


        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            txtIngre1.Clear();
            txtIngre2.Clear();
            txtIngre3.Clear();
            txtIngre4.Clear();
            txtIngre5.Clear();
            txtLucro.Clear();
            txtTotal.Clear();
            txtValorVenda.Clear();
            txtValorVenda.Clear();
            txtValorVenda.Clear();

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    

