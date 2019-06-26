using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Exercicio01
    {
        //6) Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrever a
        //área do retângulo.

        public float Base1 { get; set; }
        public float Altura { get; set; }
        public float Resultado { get; set; }

      


        public void  Dimensão ()
        {
            Resultado = Base1 * Altura;
        }
    }
}