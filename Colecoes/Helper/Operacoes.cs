using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes.Helper
{
    public class Operacoes
    {
        public void OrdenarBubleSort(ref int [] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array [j+1])
                    {
                        temp = array[j+1];
                        array[j+1] =  array [j];
                        array[j] = temp;
                    }
                }
                
            }
        }
        public void ImprimirArray(int [] array)
        {
            var linha = string.Join(", ", array);
                System.Console.WriteLine(linha);
            

        }

//usando método próprio do system com A maiusculo
        public void Ordenar(ref int [] array)
        {
            Array.Sort(array);
        }

//usando método Copy do Array para copiar de outro array (origem, destino, tamanho)
        public void Copiar (ref int [] array, ref int [] arrayDestino)
        {
            Array.Copy(array, arrayDestino , array.Length);
        }
//usando método Existe para verificar se existem algo no meu array
        public bool Existe (int [] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int [] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor (int [] array, int valor)
        {
            return Array.Find(array, element => element == valor );
        }

        public int ObterIndice (int [] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray (ref int [] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string [] ConverterParaArrayString (int [] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}