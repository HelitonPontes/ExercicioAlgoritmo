using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Ingredientes
    {
        public float ingrediente1 { set; get; }
        public float ingrediente2 { set; get; }
        public float ingrediente3 { set; get; }
        public float ingrediente4 { set; get; }
        public float ingrediente5 { set; get; }
        public float porc { set; get; }
        public float porrcetagem { set; get; }

        public float ValorTotal { set; get; }

        public float ValorVenda { set; get; }

        public float Lucro { set; get; }

        public void MValorTotal()
        {
            ValorTotal = ingrediente1 + ingrediente2 + ingrediente3 + ingrediente4 + ingrediente5;
        }


        public void MLucro()
        {
            Lucro = ValorVenda - ValorTotal;
        }
    }
}
