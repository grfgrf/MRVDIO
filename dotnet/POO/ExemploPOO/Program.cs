using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.IO;
using System.Collections.Generic;
namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\Users\\admin\\Desktop\\Git\\MRVDIO\\dotnet\\ExemploPOO\\ExArquivos";
            FileHelper helper = new FileHelper();
            // helper.ListarDirs(caminho);
            // helper.ListarArquivosDir(caminho);
            //helper.CriarDir(Path.Combine(caminho,"Teste3","SubTeste3"));            
            //helper.ApagarDir(Path.Combine(caminho,"Teste3","SubTeste3"));
            //helper.CriarTxt(Path.Combine(caminho,"teste2","oi2.txt"),"conteudo txt");
            
            var listaString = new List<string> {"linha1","linha2"};
            var listaString2 = new List<string> {"linha3","linha4"};
            //helper.CriarTxtStream(Path.Combine(caminho,"Teste3","stream.txt"), listaString);
            // helper.CriarTxtStream(Path.Combine(caminho,"Teste1","stream2.txt"),listaString );
            // helper.AddTextoStream(Path.Combine(caminho,"Teste1","stream2.txt"),listaString2);
            // helper.LerArquivoStream(Path.Combine(caminho,"Teste3","stream.txt"));
            // helper.MoverArquivo(Path.Combine(caminho,"Teste1","stream2.txt"),
            //                     Path.Combine(caminho,"Teste3","stream2.txt"));
            // helper.CopiarArquivo(Path.Combine(caminho,"Teste3","stream2.txt"),
            //                     Path.Combine(caminho,"Teste1","stream2.txt"),
            //                     true);^
            helper.DeletarArquivo(Path.Combine(caminho,"Teste3","stream2.txt"));
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(1,1));
            // Computador pc = new Computador();
            // System.Console.WriteLine(pc.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(20);
            // c.ExibirSaldo();
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(0, 0);

            // System.Console.WriteLine($"Area:{r.ObterArea()}");


            // Aluno p1 = new Aluno();
            // Professor p2 = new Professor();
            // Calculadora calc = new Calculadora();

            // p1.Nota = 1;
            // p1.Nome = "Aluno";
            // p1.Idade = 20;
            // p1.Apresentar();

            // p2.Salario = 0;
            // p2.Nome = "Prof";
            // p2.Idade = 200;
            // p2.Apresentar();

            // System.Console.WriteLine($"Soma1 {calc.Somar(1,2)}");
            // System.Console.WriteLine($"Soma2 {calc.Somar(1,2,3)}");

        }

    }


}