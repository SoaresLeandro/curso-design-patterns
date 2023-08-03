using CursoDesignPatterns.Handlers;
using CursoDesignPatterns.Impostos;
using CursoDesignPatterns.Models;

Orcamento orcamento = new Orcamento(5000);
orcamento.Itens.Add(new Item("PC", 4000));
orcamento.Itens.Add(new Item("Celular", 2400));
orcamento.Itens.Add(new Item("Camera", 1200));
orcamento.Itens.Add(new Item("Caneta", 2.5));
orcamento.Itens.Add(new Item("Lapis", 2));
orcamento.Itens.Add(new Item("Lampada", 20));
orcamento.Valor = orcamento.Itens.Sum(i => i.Preco);

//Console.WriteLine(orcamento.Valor);
//CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();
//calculadorDeImpostos.Calcular(orcamento, new ImpostoMuitoAlto(new ICMS()));

//orcamento.AplicaDescontoExtra();
//Console.WriteLine(orcamento.Valor);
//orcamento.Aprova();
//orcamento.AplicaDescontoExtra();
//Console.WriteLine(orcamento.Valor);
//orcamento.Finaliza();
//orcamento.AplicaDescontoExtra();
//calculadorDeImpostos.Calcular(orcamento, new ISS(new ICMS()));
//calculadorDeImpostos.Calcular(orcamento, new ICMS());

//calculadorDeImpostos.Calcular(orcamento, new ICPP());
//calculadorDeImpostos.Calcular(orcamento, new ICKV());

//Console.WriteLine("********** Desconto **********");
//Console.WriteLine($"Total do Orçamento: {orcamento.Valor}");
//CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();
//calculadorDeDescontos.CalcularDesconto(orcamento);

NotaFiscalBuilder notaFiscalBuilder = new NotaFiscalBuilder();

NotaFiscal notaFiscal = notaFiscalBuilder
    .ParaAEmpresa("UCDB")
    .NaData()
    .ComItem(new Item("Lapis", 2.00))
    .ComItem(new Item("Caneta", 5.00))
    .Construir();

Console.WriteLine(notaFiscal);

