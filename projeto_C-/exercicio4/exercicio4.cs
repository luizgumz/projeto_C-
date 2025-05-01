using System;
using System.Threading;

namespace projeto_C_.exercicio4
{
    abstract class Exercicio04
    {
        public static void Execute() 
        {
            while(true)
            {
                try 
                {
                    double inputTemperature;
                

                    Console.WriteLine("=== Conversor de temperaturas === ");
                    Console.WriteLine("1. Celsius para Fahrenheit");
                    Console.WriteLine("2. Fahrenheit para Celsius");
                    Console.WriteLine("3. Sair");

                    Console.WriteLine("\nEscolha uma opção: ");
                    int option = int.Parse(Console.ReadLine());

                    switch(option)
                    {
                        case 1:
                            Console.Write("Digite a temperatura em Celsius: ");
                            inputTemperature = double.Parse(Console.ReadLine());
                            CelciusToFahrenheit(inputTemperature);
                            break;
                        case 2:
                            Console.Write("Digite a temperatura em Fahrenheit: ");
                            inputTemperature = double.Parse(Console.ReadLine());
                            FahrenheitToCelcius(inputTemperature);
                            break;
                        case 3:
                        Console.WriteLine("\n\n\n=============================");
                            Console.WriteLine("Saindo...");
                            Thread.Sleep(3_000);
                            break;
                        default:
                            Console.WriteLine("Digite uma opção válida");
                            break;
                    }

                }
                catch
                {
                    Console.WriteLine("Digite uma opção válida");
                }
                finally
                {
                    Console.WriteLine("\n\n\n=============================");
                    Console.WriteLine("Limpando a tela em 3 segundos!");
                    Thread.Sleep(3_000);
                    Console.Clear();
                }
            }
        }

        private static double CelciusToFahrenheit(double inputTemperature)
        {
            return (inputTemperature * 9 / 5) + 32;
        }

        private static double FahrenheitToCelcius(double inputTemperature)
        {
            return (inputTemperature - 32) * 5 / 9;
        }
    }
}