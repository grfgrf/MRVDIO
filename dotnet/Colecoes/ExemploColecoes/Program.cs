using System.Collections.Generic;
using ExemploColecoes.Helper;
using System.Linq;

int[,] matrizInt = new int[,]{{1,11},{2,22},{3,33}};
string[] vetorStr = new string[]{"SP","AM","BH"};
int[] vetorInt= new int[]{6,2,1};
int[] vetorCopia = new int[vetorInt.Length*2];
OperacoesArrays op = new OperacoesArrays();
List<string> listaStr = vetorStr.ToList();
Queue<int> filaInt = new Queue<int>(vetorInt.ToList());
Stack<int> pilhaInt = new Stack<int>(vetorInt.ToList());
Dictionary<string,int> dictCharInt = new Dictionary<string, int>();

var numerosPares =
        from num in vetorInt
        where num % 2 == 0
        orderby num
        select num;

var numeroesParesMetodo = vetorInt.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

System.Console.WriteLine("oi" + string.Join(", ", numerosPares));

foreach (var item in numeroesParesMetodo)
{
    System.Console.WriteLine(item);
}

// dictCharInt.Add("A",1);
// dictCharInt.Add("B",2);
// System.Console.WriteLine(dictCharInt["A"]);
// System.Console.WriteLine(dictCharInt["A"].Equals(1));
// dictCharInt["A"] = 9999;
// System.Console.WriteLine(dictCharInt["A"].Equals(1));

// foreach (KeyValuePair<string , int> item in dictCharInt)
// {
//     System.Console.WriteLine(item.Value + " oi " + item.Key);
// }

// pilhaInt.Push(000);
// foreach (var item in pilhaInt)
// {
//     System.Console.WriteLine(item);
// }

// filaInt.Enqueue(999);
// foreach (var item in filaInt)
// {
//     System.Console.WriteLine(item);
// }

// listaStr.Add("MG");
// listaStr.RemoveRange(1,2);
// listaStr.ForEach(Console.WriteLine);

// op.ImprimirVetor(vetorInt);
// string[] vetorStr = op.ConverteVetor(vetorInt);
// Array.ForEach(vetorStr, Console.WriteLine);


// bool existe = op.ExisteVetor(vetorInt,6);

// System.Console.WriteLine(existe);

// op.ImprimirVetor(vetorInt);
// op.CopiaVetor(ref vetorInt,ref vetorCopia);
// op.ImprimirVetor(vetorCopia);

// op.ImprimirVetor(vetorInt);
// op.OrdenaVetor(vetorInt);
// op.ImprimirVetor(vetorInt);



// op.ImprimirVetor(vetorInt);
// op.BubbleVetor(ref vetorInt);
// op.ImprimirVetor(vetorInt);

// foreach (var elemento in matrizInt)
// {
//  System.Console.WriteLine(elemento);
// }


// for (int i = 0; i < matrizInt.GetLength(0); i++)
// {
//     for (int j = 0; j < matrizInt.GetLength(1); j++)
//     {
//      System.Console.WriteLine(matrizInt[i,j]);   
//     }
// System.Console.WriteLine("muda linha");
// }

// int[] vetorInt= new int[]{1,2,3};

// for (int i = 0; i < vetorInt.Length; i++)
// {
//     System.Console.WriteLine(vetorInt[i]);
// }

// foreach (var item in vetorInt)
// {
//     System.Console.WriteLine(item+"oi");
    
// }

