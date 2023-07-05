using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.EstadosDeUmOrcamento
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.Valor -= orcamento.Valor * 0.05;

        public void Aprova(Orcamento orcamento) => orcamento.EstadoAtual = new Aprovado();

        public void Finaliza(Orcamento orcamento) => 
            throw new Exception("Orçamentos em estado de aprovação não podem ser finalizados.");

        public void Reprova(Orcamento orcamento) => orcamento.EstadoAtual = new Reprovado();
    }
}
