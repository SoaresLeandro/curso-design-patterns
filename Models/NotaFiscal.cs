using System.Text;

namespace CursoDesignPatterns.Models
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public ICollection<Item> Itens { get; set; }
        public string Empresa { get; set; }
        public DateTime Data { get; set; }

        public NotaFiscal(double valor, ICollection<Item> itens, string empresa, DateTime data)
        {
            Valor = valor;
            Itens = itens;
            Empresa = empresa;
            Data = data;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Empresa: {Empresa} ");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Data: {Data} ");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Valor: {Valor}");

            return stringBuilder.ToString();
        }
    }
}
