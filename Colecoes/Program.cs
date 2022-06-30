using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesLista opLista = new OperacoesLista();
            List<string> estados = new List<string>() {"SP", "MG", "BA"};
            string[] estadosArray = new string [2] {"SC", "MT"};

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count} ");

            opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("removendo o elemento");
            // estados.Remove("MG");

//adicionando elementos de outro array
            //estados.AddRange(estadosArray);
            
//inserindo um item no indice escolhido empurrando os demais 
            estados.Insert(1,"RJ");
            opLista.ImprimirListaString(estados);



            // Operacoes op = new Operacoes ();
            // int [] array = new int [5] {6,3,8,1,9};
            // int [] arrayCopia = new int [10];
            // string [] arrayString = op.ConverterParaArrayString(array);

            // int valorProcurado = 8;

            // System.Console.WriteLine($"capacidade atual do array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length*2);
            // System.Console.WriteLine($"capacidade do array após redimensionar: {array.Length}");


            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1){
            //     System.Console.WriteLine("o indice do elemtno {0} é: {1}", valorProcurado, indice);
            // }
            // else {
            //     System.Console.WriteLine("valor não existente no array");
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if (valorAchado > 0){
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue){
            //     System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado);
            // }
            // else{
            //     System.Console.WriteLine("Existem valores que não são maiores do que {}", valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if (existe){
            //     System.Console.WriteLine("encontrei o valor: {0}", valorProcurado);
            // }
            // else{
            //     System.Console.WriteLine("não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            // //op.OrdenarBubleSort(ref array);
            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado");

            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);   
            // System.Console.WriteLine("Array após da cópia");
            // op.ImprimirArray(arrayCopia);



            // int [] arrayInteiros = new int [3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("percorrendo o array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("percorrendo o array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}

