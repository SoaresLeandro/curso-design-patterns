using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double CalcularDesconto(Orcamento orcamento) => 0;
    }
}
