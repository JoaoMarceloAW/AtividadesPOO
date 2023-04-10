namespace Atividade_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {//crie um programa para calcular o volume de uma caixa retangular 
         //Qual é a fórmula para calcular o volume?O cálculo do volume é sempre dado pela multiplicação da altura(h), vezes a largura(L), vezes o comprimento(C).
         
           Retangulo meuretangulo = new Retangulo();

            Console.WriteLine("Bem vindo, sistema de calculo do volume de caixas!");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Digite a altura da caixa: ");
            meuretangulo.altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a largura da caixa: ");
            meuretangulo.largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o comprimento da caixa: ");
            meuretangulo.comprimento = Convert.ToInt32(Console.ReadLine());
           
            Console.Clear();


            Console.WriteLine("O volume do seu retangulo é de: " + meuretangulo.CalcularoVolume());


            Console.ReadLine();











        }
    }
}