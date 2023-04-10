namespace Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para calcular o salário total de um vendedor.Deverá
            // ser informado o salário base e o total de vendas.A comissão é calculada
            // com um percentual(informado pelo usuário) sobre o total de vendas.

           Vendedor novoVendedor = new Vendedor();
            

            Console.WriteLine("Bem vindo, um programa para calcular o salário total de um vendedo");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Digite o salario base do vendedor: ");
            novoVendedor. salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("Digite quanto o vendedor vendeu no mês: ");
            novoVendedor .vendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();



            Console.WriteLine("Digite a porcentagem que o vendedor ganha no total de vendas: ");
            novoVendedor. porecentagem = Convert.ToDecimal(Console.ReadLine());

           
            Console.Clear();

            Console.WriteLine($"O Salario do vendedor será de:{novoVendedor.ObterCalculo}");




            Console.ReadLine();






           



        }
    }
}