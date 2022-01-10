using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Pessoa p1 = new Pessoa("Nome1","Sobrenome1");   
            // p1.Apresentar();  
            
            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instancia";

            // Log Log2 = Log.GetInstance();
            // System.Console.WriteLine(Log2.PropriedadeLog);

            // Aluno p1 = new Aluno( "Nome2","Sobrenome2","Disciplina2");
            // p1.Apresentar();

            Data data = new Data();
            // data.SetMes(15);
            // data.ApresentarMes();
            data.Mes = 12;
            System.Console.WriteLine(data.Mes);
        }
    }
}