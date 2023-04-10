using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    internal class LataDeOleo
    {

        public  double pi = 3.14;
        public double areaDaBase;
        public double altura;
        public double ObterCalculo()
        {
            double calculo;

            calculo = pi * (areaDaBase * areaDaBase) * altura;

            return calculo;


        }
    }
}
