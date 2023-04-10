namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Crie um programa para calcular o consumo de combustível por Km.
            //Deverá ser informado a kilometragem Inicial e Final do Percurso do  Veículo. Deverá ser informado o Consumo de Combustível 

            Informacoes novasinformacoes = new Informacoes();

            Console.WriteLine("Bem Vindo, programa para calcular o consumo de combustível por Km!!!! ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            
            Console.WriteLine("Digite a kilometragme inicial do seu veiculo: ");
            novasinformacoes.kmInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a kilometragem final do seu veiculo: ");
            novasinformacoes. kmFinal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o consumo de combustivel (em litros)");
            novasinformacoes.consumoCombustivel = Convert.ToDecimal(Console.ReadLine());


            Console.Clear();

            Console.WriteLine($"O consumo de combustivel do seu veiculo foi de totais:" + novasinformacoes.consumoCombustivel+ "KM/L");

            Console.ReadLine();










        }
    }
}