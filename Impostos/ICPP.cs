using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impostos
{
    public class ICPP : TemplateImpostoCondicional
    {
        public ICPP() { }
        public override bool DeveUsarATaxacaoMaxima(Orcamento orcamento) => orcamento.Valor >= 500;

        public override double TaxacaoMaxima(Orcamento orcamento) => orcamento.Valor * 0.07;

        public override double TaxacaoMinima(Orcamento orcamento) => orcamento.Valor * 0.05;
    }
}
