﻿using CursoDesignPatterns.Models;

namespace CursoDesignPatterns
{
    public abstract class TemplateImpostoCondicional : Imposto
    {
        public override double CalcularImposto(Orcamento orcamento) => 
            DeveUsarATaxacaoMaxima(orcamento) ? TaxacaoMaxima(orcamento) : TaxacaoMinima(orcamento);
        public abstract bool DeveUsarATaxacaoMaxima(Orcamento orcamento);
        public abstract double TaxacaoMinima(Orcamento orcamento);
        public abstract double TaxacaoMaxima(Orcamento orcamento);
    }
}
