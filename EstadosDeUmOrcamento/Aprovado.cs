using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.EstadosDeUmOrcamento
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.Valor -= orcamento.Valor * 0.02;

        public void Aprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos aprovados não podem ser aprovados novamente.");

        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();

        public void Reprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos aprovados não podem ser reprovados.");
    }
}
