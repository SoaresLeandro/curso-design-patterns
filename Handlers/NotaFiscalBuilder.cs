using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Handlers
{
    public class NotaFiscalBuilder
    {
        public string Empresa { get; set; }
        public DateTime Data { get; set; }
        public ICollection<Item> Itens =  new List<Item>();
        public double ValorTotal { get; set; }

        public NotaFiscalBuilder ParaAEmpresa(string empresa)
        {
            Empresa = empresa;
            return this;
        }

        public NotaFiscalBuilder NaData()
        {
            Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(Item item)
        {
            Itens.Add(item);
            ValorTotal += item.Preco += item.Preco *= 0.05;
            return this;
        }

        public NotaFiscal Construir()
        {
            return new NotaFiscal(ValorTotal, Itens, Empresa, Data);
        }
    }
}
