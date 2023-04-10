namespace Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Crie um programa para calcular a média ponderada de duas provas  realizadas por um aluno

            double nota1, nota2, nota3, nota4;
            double peso1, peso2, peso3, peso4;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da primeira nota: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da segunda nota: ");
            peso2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da terceira nota: ");
            peso3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());
            Console.Write("Digite o peso da quarta nota: ");
            peso4 = double.Parse(Console.ReadLine());

            double media_ponderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3 + nota4 * peso4) / (peso1 + peso2 + peso3 + peso4);

            Console.WriteLine("A média ponderada das notas é: {0:F2}", media_ponderada);


            Console.ReadLine();
        }




    }

}

