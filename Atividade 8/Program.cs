using System.Runtime.Intrinsics.X86;

namespace Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Crie um programa para calcular o volume de uma lata de óleo 
            // d) O volume da lata é o volume de um cilindro circular reto, logo é dado pelo produto entre a área da base e a altura da lata em questão,
            // sendo que a área da base é a área do círculo de raio r=50mm.
            
            LataDeOleo novaLata = new LataDeOleo();

            Console.WriteLine("Bem Vindo, um programa para calcular o volume de uma lata de óleo!!!!");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite a área da base do seu cilindro: ");
            novaLata. areaDaBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Digite a altura do seu cilindro: ");
            novaLata. altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();
           
            Console.WriteLine($"O Volumé total é de: {novaLata.ObterCalculo}");

            Console.ReadLine();



        }    }   
}