// Cálculo de IMC com Classificação
// Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
// • Abaixo de 18.5: Abaixo do peso
// • 18.5 a 24.9: Peso normal
// • 25 a 29.9: Sobrepeso
// • 30 ou mais: Obesidade

namespace projeto_C_.exercicio08
{
    abstract class Exercicio08
    {
        public static void Execute()
        {
            Console.Clear();
            //Variáveis peso e altura
            float weight = 0;
            float height = 0;
            bool isValid;

            //Verifies if the input is in correct format
            //Verifica se a entrada está no formato correto
            do
            {
                Console.WriteLine("Qual seu peso? ");

                isValid = float.TryParse(Console.ReadLine(), out weight);
                    if (!isValid)
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
            }while(!isValid);
            
            //Verifies if the input is in correct format
            //Verifica se a entrada está no formato correto
            do
            {
                Console.WriteLine("Qual sua altura? ");
                
                isValid = float.TryParse(Console.ReadLine(), out height);
                    if (!isValid)
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
            }while(!isValid);
                
            //Calculate body development index
            //Calcula o IMC
            float IMC = weight / (height * 2);
            Console.WriteLine("\nSeu IMC é " + IMC);
            

            if (IMC < 18.5){
                Console.WriteLine("Abaixo do peso");
            }else if(IMC > 18.5 || IMC < 24.9){
                Console.WriteLine("Peso Normal");
            }else if(IMC > 25 || IMC < 29.9){
                Console.WriteLine("Sobrepeso");
            }else{
                Console.WriteLine("Obesidade");
            }
        }
    }
}
