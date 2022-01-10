namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
    
          public override void Apresentar()
        {
            Console.WriteLine($"Nota:{Nota}nome:{Nome} idade:{Idade}");
        }
    }
}