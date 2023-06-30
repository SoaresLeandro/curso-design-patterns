namespace CursoDesignPatterns
{
    public class ISS : IImposto
    {
        public double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
