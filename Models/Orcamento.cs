namespace CursoDesignPatterns.Models
{
    public class Orcamento
    {
        public double Valor;
        public ICollection<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }
    }
}