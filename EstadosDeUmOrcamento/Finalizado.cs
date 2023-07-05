using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.EstadosDeUmOrcamento
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) =>            
            throw new Exception("Orçamentos finalizados não recebem descontos.");

        public void Aprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos finalizados não podem ser aprovados.");

        public void Finaliza(Orcamento orcamento) =>
            throw new Exception("Orçamentos finalizados não podem ser finalizados novamente.");

        public void Reprova(Orcamento orcamento) =>
            throw new Exception("Orçamentos finalizados não podem ser reprovados.");
    }
}
