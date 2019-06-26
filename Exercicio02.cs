using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Exercicio02
    {
        //8) Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos
        //brancos, nulos e válidos.Calcular e escrever o percentual que cada um representa em relação ao total
        //de eleitores.

        public float Eleitores { get; set; }
        public float VotoBranco { get; set; }
        public float VotoNulo { get; set;  }
        public float VotoValidos { get; set; }
        public float porc = 100;
        public float PrcVB { get; set; }
        public float PrcVN { get; set; }
        public float PrcVV { get; set; }

        public void Calcular ()
        {
            PrcVB = VotoBranco * porc / Eleitores;
            PrcVN = VotoNulo * porc / Eleitores;
            VotoValidos = Eleitores - VotoBranco - VotoNulo;
            PrcVV = VotoValidos * porc / Eleitores;

        }

    }
}
