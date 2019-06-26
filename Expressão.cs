
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Expressão
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Resultado { get; set; }

        public void Result()
        {
            Resultado = (X + 5 + 300 + 3 - Y);
        }

    }
}
