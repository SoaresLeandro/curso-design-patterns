using CursoDesignPatterns.EstadosDeUmOrcamento;

namespace CursoDesignPatterns.Models
{
    public class Orcamento
    {
        public double Valor;
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }
        public ICollection<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra() => EstadoAtual.AplicaDescontoExtra(this);

        public void Aprova() => EstadoAtual.Aprova(this);

        public void Reprova() => EstadoAtual.Reprova(this);

        public void Finaliza() => EstadoAtual.Finaliza(this);
    }
}