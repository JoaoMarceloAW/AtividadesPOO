using System;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  2) Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
            // Subtraímos a temperatura em ºF por 32 e dividimos o resultado por 1,8.
            TemperaturaFahrenheit MinhaTemperatura = new TemperaturaFahrenheit();


            Console.WriteLine("Bem vindo,programa para converter a temperatura de graus Fahrenheit para graus Celsius! ");
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("Digite a temperatura em Fahreiheit :");
            MinhaTemperatura.temperaturaFahreiheit = Convert.ToDecimal(Console.ReadLine());
            
            
            Console.Clear();

            Console.WriteLine("Em celsius a temperatura seria igual ao total: " + MinhaTemperatura.convereterparagrauscelcius());

            
            
            
            
            Console.ReadLine();







        }
    }
}