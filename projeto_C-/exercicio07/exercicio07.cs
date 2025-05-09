namespace projeto_C_.exercicio07
{
    abstract class Exercicio07
    {
        public static void Execute() 
        {
            while(true)
            {
                try{
  
                    int[] numbers = new int[10];
                    ArrayStorage(numbers);
                    int sumEvenNums = SumEvenNumers(numbers);

                    Console.WriteLine("O resultado é " + sumEvenNums);
                    
                    Console.WriteLine("\n=============================");
		            Console.WriteLine("Pressione ENTER para continuar!");
                    Console.ReadKey();
                    return;
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

        //Método que valida e armazena as entradas do usuário em um vetor
        //Method than validate and store user's inputs in an array
        private static void ArrayStorage(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int input;
                bool valid;

                do
                {
                    Console.WriteLine("=== Armazenador de números ===");
                    Console.WriteLine($"\nDigite {i + 1}° número: ");
                    
                    valid = int.TryParse(Console.ReadLine(), out input);
                    if (!valid)
                    {
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
                }while (!valid);
                
                arr[i] = input;
            }
        }

        //Method than receive the vector's numbers and sum even numbers
        //Método que recebe o vetor numbers e soma os números pares 
        static int SumEvenNumers(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

    }
}
