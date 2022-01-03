using System;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray(); //cria um array sem numeros repetidos


            System.Console.WriteLine($"Mínimo: {minimo}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma : {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

            // var numerosParesQuery =  //forma LINQ Query de pesquisar numeros pares dentro de um array
            //          from num in arrayNumeros
            //          where num % 2 == 0
            //          orderby num
            //          select num;
            
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList(); //forma LINQ metodo de pesquisar numeros pares dentro de um array

            // System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            // System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));


        
        
        //    Dictionary<string, string> estados = new Dictionary<string, string>();

        //    estados.Add("SP", "São Pulo");
        //    estados.Add("RS", "Rio Grande do Sul");  //o valor da chave é unico não pode ser repetido
        //    estados.Add("BA", "Bahia");

        //     foreach (KeyValuePair<string, string> item in estados)
        //     {
        //         //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        //     }

        //    string valorProcurado = "SC"; 

        //    //var teste = estados["SC"]; //esta forma retorna um erro pois interrompe a execução por não estar tratado o valor inexistente

        //    if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
        //    {
        //        System.Console.WriteLine(estadoEncontrado);
        //    }
        //    else
        //    {
        //        System.Console.WriteLine($"Chave {valorProcurado} não existe no dicionario");
        //    } 

        //    System.Console.WriteLine($"Removendo o valor: {valorProcurado}"); //removendo um valor do dictionery

        //    estados.Remove(valorProcurado);

        //    foreach (KeyValuePair<string, string> item in estados)
        //     {
        //         System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        //     }

        //    System.Console.WriteLine("Valor original: "); //processo para atualizar um valor
        //    System.Console.WriteLine(estados[valorProcurado]);

        //    estados[valorProcurado] = "BA - teste atualização";

        //    System.Console.WriteLine("Valor atualizado: ");
        //    System.Console.WriteLine(estados[valorProcurado]);


            //    Stack<string> pilhaLivros = new Stack<string>();

            //    pilhaLivros.Push(".Net"); //Push inclui o elemento
            //    pilhaLivros.Push("DDD");
            //    pilhaLivros.Push("Código Limpo");

            //    System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
            //    while (pilhaLivros.Count > 0)
            //    {
            //        System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}"); //Peek lê o ultimo elemento
            //        System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso"); //Pop Exclui o ultimo elemento
            //    }

            //    System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");


        //     Queue<string> fila = new Queue<string>(); //coleção tipo fila

        //     fila.Enqueue("Leonardo"); //Enqueue inclui
        //     fila.Enqueue("Eduardo");
        //     fila.Enqueue("André");

        // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

        // while (fila.Count > 0)
        // {
        //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
        //     System.Console.WriteLine($"{fila.Dequeue()} atendido"); //Dequeue exclui
        // }

        // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");


            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> {"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};
            // estados.Add("SP"); //PODE SER ADICIONADO DESTA FORMA TAMBÉM
            // estados.Add("MG");
            // estados.Add("BA");

            //System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            //opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");

            //estados.AddRange(estadosArray); //adiciona um estado no final da lista
            //estados.Insert(1, "RS"); //adiciona um estado em uma determinada posição

            //opLista.ImprimirListaString(estados);

            //ou pode ser listado com foreach também cfe exemplo:
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }



            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] { 6, 3, 8, 1, 9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            //int valorProcurado = 8;



            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");

            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"o indice do elemento {valorProcurado} é : {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }

        //    int valorAchado = op.ObterValor(array, valorProcurado);

        //    if (valorAchado > 0)
        //    {
        //        System.Console.WriteLine("Encontrei o valor");
        //    }
        //    else
        //    {
        //        System.Console.WriteLine("Não encontrei o valor");
        //    }

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (TodosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado);
            // }


            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original: ");
            // op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array apos a cópia: ");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int [4,2]
            // {
            //     { 8, 9 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //     System.Console.WriteLine(matriz[i, j]);
            //     }

            // }


        //    int[] arrayInteiros = new int[3];

        //     arrayInteiros[0] = 10;
        //     arrayInteiros[1] = 20;
        //     arrayInteiros[2] = int.Parse("30"); //conversão de string do tipo inteiro

            // System.Console.WriteLine("Percorrendo o array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        }
    }
}
