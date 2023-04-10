using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Informacoes
    {
        public decimal kmInicial;
        public  decimal kmFinal;
        public decimal consumoCombustivel;
        public decimal kmpercorridos;
        public decimal CalcularConsumo()
        {
            Decimal ConsumoTotal = 0;

            decimal kmpercorridos;

            kmpercorridos = kmInicial + kmFinal;

            ConsumoTotal = kmpercorridos / consumoCombustivel;

            return ConsumoTotal;
        }
    }



    }


