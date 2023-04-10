using System.Xml;

namespace Atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) Crie um programa para calcular a média harmônica das notas de um  aluno 

         
            Aluno novoAluno = new Aluno();


            Console.WriteLine("Bem vindo,  um programa para calcular a média harmônica das notas de um  aluno!!!");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite a primeira nota do seu aluno: ");

            novoAluno. nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Digite a segunda nota do seu aluno");
            novoAluno. nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a terceira nota do seu aluno");
            novoAluno. nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a quarta nota do seu aluno");
            novoAluno. nota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

           
            
            Console.WriteLine($"A média harmonica do aluno é de {novoAluno.ObterCalculo}");

            Console.ReadLine();







        }
    }
}