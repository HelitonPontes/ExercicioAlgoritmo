using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Exercicio05
    {
        //9) Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
        //Calcular e escrever o valor do novo salário

        public string NomeF { get; set; }
        public float SalarioAtual { get; set; }
        public float PercentualAjuste { get; set; }
        public float SalarioReajustado { get; set; }
        public float QAumento { get; set; }


        public void Calcula ()
        {
            QAumento = SalarioAtual * PercentualAjuste / 100;
            SalarioReajustado = SalarioAtual + QAumento;

        }


    }
}
