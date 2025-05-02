// 5. Verificador de Palíndromos
// Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
// (lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos).

using System.Text;
using System.Text.RegularExpressions;

namespace projeto_C_.exercicio05{
    abstract class Exercicio05
    {
        public static void Execute()
        {

            //input
            //entrada
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Digite uma palavra ou frase");
            String palavra = Console.ReadLine();

           string textoLimpo;

		   //It basically makes sure input comes without accents and other symbols
           //Isso basicamente serve para que a entrada venha sem acentos ou outros símbolos
		   textoLimpo = Regex.Replace(
				palavra.Normalize(NormalizationForm.FormD),
				@"\p{Mn}", ""
			);

		   //Remove espaços e caracteres especiais
           //Remove spaces and special caracters
           textoLimpo = Regex.Replace(textoLimpo, @"[^a-zA-Z0-9]", "").ToLower();
		   
            //The native method reverse revert the "string" caracter
            //O método nativo reverse reverte a "string" de caracteres 
           	char[] letras = textoLimpo.ToCharArray();
			Array.Reverse(letras);
			string palavraInvertida = new string(letras);

            //Verificates if it's a palindrom or not
            //Verifica se é um palindromo ou não
            if(palavraInvertida == textoLimpo){
                Console.WriteLine("É um palíndromo");
            }else
            {
                Console.WriteLine("Não é um palíndromo");
            }



        }
    }
}
