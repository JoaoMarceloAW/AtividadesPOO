using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class TemperaturaFahrenheit
    {

        public    decimal temperaturaCelcius;
        public decimal temperaturaFahreiheit;
        public decimal convereterparagrauscelcius()
        {
            decimal calculo = 0;

            calculo = (temperaturaFahreiheit - 32) * 5 / 9;

            return calculo;
        }
    }
}
