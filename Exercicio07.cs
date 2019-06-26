
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Exercicio07
    {
        public float Nota01 { get; set; }
        public float Nota02 { get; set; }
        public float Nota03 { get; set; }
        public float Nota04 { get; set; }
        public float Media { get; set; }
        public string NomeAluno { get; set; }
        public string StrResultado { get; set; }


        public void Calcular ()
        {
            Media = (Nota01 + Nota02 + Nota03 + Nota04) / 4;

            if ( Media  >= 6)
            {
                StrResultado = "Aprovado";

            }
            if ( Media >= 4 && Media <= 5.9) 
            {
                StrResultado = "Recuperação";

            }
            if (Media < 3.9)
            {
                StrResultado = "Reprovado";
            }


        }
    }
}
