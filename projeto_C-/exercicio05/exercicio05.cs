// 5. Verificador de Palíndromos
// Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
// (lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos).

using System.Text.RegularExpressions;

namespace projeto_C_.exercicio05{
    abstract class Exercicio05
    {
        public static void Execute()
        {
          //  Console.Clear();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Digite uma palavra ou frase");
            String palavra = Console.ReadLine();

           string textoLimpo = palavra;
           textoLimpo = Regex.Replace(textoLimpo, @"[^a-zA-Z0-9]", "").ToLower();

           char[] letras = textoLimpo.ToCharArray();
            Array.Reverse(letras);
            string palavraInvertida = new string(letras);

            Console.WriteLine("Palavre invertido " + palavraInvertida);

            if(palavraInvertida == palavra){
                Console.WriteLine("É um palíndromo");
            }else
            {
                Console.WriteLine("Não é um palíndromo");
            }



        }
    }
}