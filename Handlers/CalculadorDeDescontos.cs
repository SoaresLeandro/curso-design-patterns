using CursoDesignPatterns.Descontos;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Handlers
{
    public class CalculadorDeDescontos
    {
        public void CalcularDesconto(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisQueCincoItens();
            IDesconto d2 = new DescontoValorMaiorQueQuinhentosReais();
            IDesconto d3 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;

            double desconto = d1.CalcularDesconto(orcamento);

            Console.WriteLine($"Desconto: {desconto}");
        }
    }
}
