using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Handlers
{
    public class CalculadorDeImpostos
    {
        public void Calcular(Orcamento orcamento, Imposto imposto) => Console.WriteLine(imposto.CalcularImposto(orcamento));
    }
}
