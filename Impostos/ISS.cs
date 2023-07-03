using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impostos
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }
        public ISS() { }

        public override double CalcularImposto(Orcamento orcamento) => 
            orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
    }
}
