namespace CursoDesignPatterns.Models
{
    public class Item
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Item(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
