namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Crie um programa para calcular o volume de um Cilindro 

           Cilindro novocilindro = new Cilindro();
            
          
            Console.WriteLine("Bem vindo,para calcular o volume de um Cilindro!!!");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            
            Console.WriteLine("Digite a altura do seu cilindro :");
            novocilindro.raio = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Digite o riao do seu cilindro :");
       novocilindro.altura=Convert.ToInt32(Console.ReadLine()); 
            Console.Clear();


            Console.WriteLine("O volume do cilindro seriá de:" + novocilindro.calcularVolume());

            Console.ReadLine();





        }
    }
}