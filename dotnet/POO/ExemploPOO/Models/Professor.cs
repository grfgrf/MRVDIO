namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public  override void Apresentar()
        {
            Console.WriteLine($"salario:{Salario} nome:{Nome} idade:{Idade}");
        }    
    }
}