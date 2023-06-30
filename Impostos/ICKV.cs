using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impostos
{
    public class ICKV : TemplateImpostoCondicional
    {
        public override bool DeveUsarATaxacaoMaxima(Orcamento orcamento) => orcamento.Valor > 500 && TemItemMaiorQue100Reais(orcamento);

        public override double TaxacaoMaxima(Orcamento orcamento) => orcamento.Valor * 0.10;

        public override double TaxacaoMinima(Orcamento orcamento) => orcamento.Valor * 0.06;

        private bool TemItemMaiorQue100Reais(Orcamento orcamento) => orcamento.Itens.Any(i => i.Preco > 100);
    }
}
