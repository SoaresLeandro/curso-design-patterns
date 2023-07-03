using CursoDesignPatterns.Models;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }

        public abstract double CalcularImposto(Orcamento orcamento);
        protected double CalculoDoOutroImposto(Orcamento orcamento) => 
            OutroImposto is null ? 0 : OutroImposto.CalcularImposto(orcamento);
    }
}
