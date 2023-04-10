using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class TemperaturaCelsius
    {

     public   decimal temperaturaCelcius;
       
        
        
      public  decimal ObterCalculo()
        {
            decimal calculo;

            calculo = (temperaturaCelcius * 9 / 5) + 32;


            return calculo;
        }

    }
}
