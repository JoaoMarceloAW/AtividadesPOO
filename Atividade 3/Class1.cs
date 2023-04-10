using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Cilindro

    {


        public double altura = 0;

      public double raio = 0;
       
        public double calcularVolume()
        {

        
        
            double calculo = 0;

            calculo = Math.PI * Math.Pow(raio, 2) * altura;


            return calculo;




        }
    }
}
