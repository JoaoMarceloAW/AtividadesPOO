namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Crie um programa para calcular o volume de uma esfera 
            //O cálculo do volume é sempre dado pela multiplicação da altura (h), vezes a largura (L), vezes o comprimento (C).

            Esfera novaEsfera = new Esfera();


            Console.WriteLine("Bem Vindo,programa para calcular o volume de uma esfera!!");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o altura da sua esfera: ");
            novaEsfera. altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a largura da sua esfera: ");
            novaEsfera. largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comprimento da sua esfera: ");
            novaEsfera. comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Clear();


            Console.WriteLine("O Volume total da sua esfera será de :" + novaEsfera.CalcularVoulume());

            Console.ReadLine();

           

        }
    }
}