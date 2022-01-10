namespace ExemploColecoes.Helper
{
    public class OperacoesArrays
    {
        public void ImprimirVetor(int[] vetor)
        {
            foreach (var item in vetor)
            {
                System.Console.WriteLine(item);
            }
        }

        
        public void BubbleVetor(ref int[] vetor)
        {
            int temp = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if(vetor [j] > vetor[j+1])
                    {
                        temp = vetor[j+1];
                        vetor[j+1] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }

        public void OrdenaVetor(int[] vetor)
        {
            Array.Sort(vetor);
        }

        public void CopiaVetor(ref int[] vetor,ref int[] vetor2)
        {
            Array.Copy(vetor, vetor2, vetor.Length);
        }

        public bool ExisteVetor(int[] vetor, int valor)
        {
            return Array.Exists(vetor, elemento => elemento == valor);
        }

        public string[] ConverteVetor(int[] vetor)
        {
         return Array.ConvertAll(vetor, elemento => elemento.ToString()+ "oi");
        }
    }
}