﻿namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, IImposto imposto) => Console.WriteLine(imposto.CalcularImposto(orcamento));
    }
}
