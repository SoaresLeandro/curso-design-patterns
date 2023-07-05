using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.EstadosDeUmOrcamento
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) =>
            throw new Exception("Orçamentos reprovados não recebem descontos.");

        public void Aprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos reprovados não podem ser aprovados.");

        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos reprovados não podem ser reprovados novamente.");
    }
}
