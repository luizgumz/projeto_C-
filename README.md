Luiz Augusto Santos Gumz
Luis Henrique Silva de Lima
Igor Ribeiro Machado

Todos exercícios foram resolvidos em suas enumerações específicas.

Comentamos todos os exercícios explicando como eles funcionam e o que cada código faz.

Explicação dos 2 exercícios
---
8. Cálculo de IMC com classificação

A lógica para calcular o IMC é simples, pegamos do usuário o seu peso e sua altura por meio do leitor do teclado e realizamos o cálculo com a seguinte fórmula: peso / altura² e após isso é realizado uma condicional para dizer se o IMC é abaixo do peso, normal, sobrepeso ou obesidade.

As estruturas utilizadas são:
* if (estrutura condicional)
* do while (estrutura de repetição)

Os comandos utilizados são (métodos):
* WriteLine (comando para exibir uma mensagem na tela)
* float.TryParse (comando para validar se o input do usuário pode ser convertido para float)

Explicação do que foi feito no código:
1. Criação das variáveis do tipo float weight e height
2. Criação da variável booleana isValid
3. Criação de um Do While para ficar solicitando o peso até que o usuário coloque um peso válido
4. Criação de um Do While para ficar solicitando o peso até que o usuário coloque uma altura válida
5. armazenamento do cálculo do IMC em uma variável do tipo float chamada IMC
6. Exibição do valor do IMC para o usuário
7. Verificação condicional para saber qual a categoria do IMC do usuário
8. Exibicação da categoria do usuário

---
10. Lista de Tarefas

A lógica para criar esse exercício foi utilizar um menu para gerenciar esse o que vai ser feito pelo usuário, sendo possível:
* Ver menu;
* listar todas as tarefas;
* listar tarefas para fazer;
* listar tarefas resolvidas;
* mover tarefa para resolvida;
* sair.

E esses passos estão todos dentro de um do while, sendo possível executar as ações dentro do menu diversas vezes até resolver digitar 0 para sair.


As estruturas utilizadas são:
* try catch (estrutura para capturar exceções (erros))
* if (estrutura condicional)
* do while (estrutura de repetição)

Os comandos utilizados são (métodos):
* WriteLine (comando para exibir uma mensagem na tela)
* float.TryParse (comando para validar se o input do usuário pode ser convertido para float)
* Console.Clear (comando para limpar a tela)

Explicação do que foi feito no código:
1. Criação das listas de tarefasParaFazer e tarefasResolvidas
2. Criação do inteiro opção, para receber o comando do usuário sobre qual ação vai ser executada
3. Switch case para identificar qual opção o usuário selecionou e executar o método correto
4. Método de adicionarNovaTarefa solicita ao usuário uma string e adiciona ela na lista
5. Método de ExibirTodasTarefas exibe na tela a lista de todas as tarefas (Resolvidas e não resolvidas)
6. Método de Listar Tarefas para fazer exibe a lista de tarefas não resolvidas
7. Método de Listar Tarefas Resolvidas para fazer exibe a lista de tarefas resolvidas
8. Método de MoverTarefaParaResolvida solicita uma string de uma tarefa que esteja na lista de tarefas não resolvidas para mover para uma tarefa resolvida
