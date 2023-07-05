using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }
        public ICPP() { }
        public override bool DeveUsarATaxacaoMaxima(Orcamento orcamento) => orcamento.Valor >= 500;

        public override double TaxacaoMaxima(Orcamento orcamento) => orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);

        public override double TaxacaoMinima(Orcamento orcamento) => orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
    }
}
