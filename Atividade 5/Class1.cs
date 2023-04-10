using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Esfera
    {
     public   decimal altura;
        public decimal largura;
        public decimal comprimento;
       
     public   decimal CalcularVoulume()
        {
         decimal   calculo;
            calculo = (altura * altura) * largura * comprimento;

            return calculo;
        }

    }
}
