using CursoDesignPatterns.Models;

namespace CursoDesignPatterns
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        double CalcularDesconto(Orcamento orcamento);
    }
}
