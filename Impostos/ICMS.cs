using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS() { }
        public override double CalcularImposto(Orcamento orcamento) => 
            orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
    }
}
