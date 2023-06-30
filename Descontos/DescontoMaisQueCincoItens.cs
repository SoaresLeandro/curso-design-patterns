using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoMaisQueCincoItens : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double CalcularDesconto(Orcamento orcamento) =>
            orcamento.Itens.Count > 5 ? orcamento.Valor * 0.1 : Proximo.CalcularDesconto(orcamento);
    }
}
