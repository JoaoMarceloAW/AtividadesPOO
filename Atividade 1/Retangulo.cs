using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{


    internal class Retangulo
    {
        public  int volume;
        public  int altura;
        public  int largura;
        public  int comprimento;

        public int CalcularoVolume()
        {
            volume = altura * largura * comprimento;

            return volume;
        }


    }
}
