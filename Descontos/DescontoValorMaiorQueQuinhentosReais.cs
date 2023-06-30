using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoValorMaiorQueQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get ; set; }

        public double CalcularDesconto(Orcamento orcamento) => 
            orcamento.Valor > 500.0 ? orcamento.Valor * 0.05 : Proximo.CalcularDesconto(orcamento);
    }
}
