using System;
using System.Threading;

namespace projeto_C_.exercicio04
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
                
                    //Shows the menu and asks the user which option is preferible
                    //Mostra o menu e pergunta ao usuário qual opção é preferível
                    Console.WriteLine("=== Conversor de temperaturas ===");
                    Console.WriteLine("1. Celsius para Fahrenheit");
                    Console.WriteLine("2. Fahrenheit para Celsius");
                    Console.WriteLine("3. Sair");

                    Console.WriteLine("\nEscolha uma opção: ");
                    int option = int.Parse(Console.ReadLine());

                    switch(option)
                    {
                        case 1:
                            //Asks for the temperature and call method calculate CelciusToFahrenheit
                            //Pergunta a temperatura e chama o método calcular Celcius para Fahrenheit
                            Console.Write("Digite a temperatura em Celsius: ");
                            inputTemperature = double.Parse(Console.ReadLine());
                            CelciusToFahrenheit(inputTemperature);
                            break;
                        case 2:
                            //Asks for the temperature and call method calculate FahrenheitToCelcius
                            //Pergunta a temperatura e chama o método calcular Fahrenheit para Celcius
                            Console.Write("Digite a temperatura em Fahrenheit: ");
                            inputTemperature = double.Parse(Console.ReadLine());
                            FahrenheitToCelcius(inputTemperature);
                            break;
                        case 3:
                            //Exit Exercise4
                            //Sai do Exercício4
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

        //Method to calculate Celcius(input) to Fahrenheit(output)
        //Método para calcular Celcius(entrada) para Fahrenheit(saida)
        private static double CelciusToFahrenheit(double inputTemperature)
        {
            return (inputTemperature * 9 / 5) + 32;
        }

        //Method to calculate Fahrenheit(input) to Celcius(output)
        //Método para calcular Fahrenheit(entrada) para Celcius(saida)
        private static double FahrenheitToCelcius(double inputTemperature)
        {
            return (inputTemperature - 32) * 5 / 9;
        }
    }
}
