// Cálculo de IMC com Classificação
// Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
// • Abaixo de 18.5: Abaixo do peso
// • 18.5 a 24.9: Peso normal
// • 25 a 29.9: Sobrepeso
// • 30 ou mais: Obesidade

namespace projeto_C_.exercicio8
{
    abstract class Exercicio08
    {
        public static void Execute()
        {
            Console.Clear();
            
            Console.WriteLine("Qual seu peso? ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura? ");
            float altura = float.Parse(Console.ReadLine());
            
            float IMC = peso / (altura * 2);
            Console.WriteLine("Seu IMC é " + IMC);

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