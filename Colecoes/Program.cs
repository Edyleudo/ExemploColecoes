using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes op = new Operacoes ();
            int [] array = new int [5] {6,3,8,1,9};
            int [] arrayCopia = new int [10];

            int valorProcurado = 10;

            bool existe = op.Existe(array, valorProcurado);

            if (existe){
                System.Console.WriteLine("encontrei o valor: {0}", valorProcurado);
            }
            else{
                System.Console.WriteLine("não encontrei o valor: {0}", valorProcurado);
            }

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

