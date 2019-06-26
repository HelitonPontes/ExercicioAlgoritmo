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
    public partial class FrmExercicio11 : Form
    {
        public FrmExercicio11()
        {
            InitializeComponent();
        }


        public int Pontocomputador { get; set; }
        public int PontoMayara { get; set; }
        public int v = 1;


        public int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10 };

        private void btnJ1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "1";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if ( v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }

        }

        private void btnJ2_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "2";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ3_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "3";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++); if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ4_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "4";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ5_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "5";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ16_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "6";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ17_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "7";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ8_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "8";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJ10_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "9";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "10";
            lblteste.Text = bt.Text;

            if (txtJogo.Text == lblteste.Text)
            {
                MessageBox.Show("Parabens vocé Acertou");
                lblPontoMayara.Text = "Pontos Mayarar: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Parabens vocé Venceu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }

            }
            else
            {
                MessageBox.Show("Que Pena vocé errou");
                lblPontosComputador.Text = "Pontos Computador: " + Convert.ToString(v++);
                if (v == 5)
                {
                    MessageBox.Show("Vocé Perdeu o Jogo");
                    Close();
                    FrmExercicio11 frm = new FrmExercicio11();
                    frm.Show();
                }
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 11);
            txtJogo.Text = Convert.ToString(numero);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
