using System;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Crie um programa para converter a temperatura da escala Celsius para a  escala Fahrenheit
            //Ou seja, para que você consiga converter de grau Celsius para Fahrenheit, basta multiplicar a temperatura em graus Celsius por 1,8 e somar 32.

           TemperaturaCelsius novaTemperatura = new TemperaturaCelsius();

            Console.WriteLine("Bem vindo, programa para converter a temperatura da escala Celsius para a  escala Fahrenheit!!! ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Digite a temperatura em celcius: ");
           novaTemperatura.temperaturaCelcius = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
         
            Console.Clear();
            Console.WriteLine($"A temperatura em Fihrenheit seria de: "+ novaTemperatura.ObterCalculo());

            Console.ReadLine();



        }
    }
}