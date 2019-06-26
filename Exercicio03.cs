using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAlgoritmos
{
    class Exercicio03
    {
      /* 12. Elabore um algoritmo que dada a idade de um nadador classifica-o em uma das seguintes categorias: 



infantil A = 5 - 7 anos

infantil B = 8-10 anos

juvenil A = 11-13 anos

junior B = 14-17 anos

adulto = maiores de 18 anos

    */
     
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public string strFraudinha = "Fraudinha";
        public string strDentedeLeite = "DentedeLeite";
        public string strMirin = "Mirin";
        public string strJuvenil = "Juvenil";
        public string strJunior = "Junior";
        public string strAdulto = "Adulto";
        public string strVeterano = "Veterano";
        public string strResultado;



        public void Calcular()
        {
            if ( Idade <= 7)
            {
                Categoria = strFraudinha;

            }
             
            if ( Idade <= 10 && Idade >=7)
            {
                Categoria = strDentedeLeite;

            }
            if (Idade <= 11 && Idade >= 8)
            {
                Categoria = strMirin;

            }
            if (Idade <= 14 && Idade >=12 )
            {
                Categoria = strJuvenil;

            }
            if (Idade <= 18 && Idade >= 15)
            {
                Categoria = strJunior;

            }
            if (Idade <= 40 && Idade >= 18)
            {
                Categoria = strAdulto;

            }
            if (Idade >=41)
            {
                Categoria = strVeterano;

            }

            strResultado = "O Nome: " + Nome +", Categoria: "+  Categoria+ ", idade: " +Idade;




        }

    }
}
