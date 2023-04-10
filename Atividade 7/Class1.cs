using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    internal class Vendedor
    {
       
        public decimal salarioBase;
        public decimal porecentagem;
        public decimal vendas;
        public decimal ObterCalculo()
        {

            decimal salarioTotal;
            decimal calculo;

            calculo = vendas / porecentagem;
            salarioTotal = calculo * salarioBase;

            return salarioTotal;
        }




    }
}
