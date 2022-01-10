using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDirs(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDir(string caminho)
        {
            var retornaArquivos = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);
            foreach (var retorno  in retornaArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDir(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDir(string caminho)
        {
            Directory.Delete(caminho);
        }
        public void CriarTxt(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho,conteudo);
            }
        }
        
        public void CriarTxtStream (string caminho,List <string> conteudo)
        {
            using (var stream = File.CreateText(caminho))   
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }   

        public void AddTexto (string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }  

        public void AddTextoStream (string caminho,List <string> conteudo)
        {
            using (var stream = File.AppendText(caminho))   
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }     

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }

        }

        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho,novoCaminho);
        }

        public void CopiarArquivo (string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo (string caminho)
        {
            File.Delete(caminho);
        }
    }
}