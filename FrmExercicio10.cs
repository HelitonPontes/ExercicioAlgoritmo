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
    public partial class FrmExercicio10 : Form
    {
        public FrmExercicio10()
        {
            InitializeComponent();
        }

        Exercicio10 Ex = new Exercicio10();

        public void Limpar ()
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Ex.usuario == txtUsuario.Text && Ex.senha== txtSenha.Text)
            {
                FrmExercicio frm = new FrmExercicio();
                frm.ShowDialog();

                Limpar();
            }

            else
            {
                MessageBox.Show("Usuario ou senha Incorretos");
                Limpar();

            }

           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
