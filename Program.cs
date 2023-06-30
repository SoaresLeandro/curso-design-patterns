using CursoDesignPatterns;

Orcamento orcamento = new Orcamento(500);
CalculadorDeImpostos calculadorDeImpostos = new CalculadorDeImpostos();

calculadorDeImpostos.Calcular(orcamento, new ICMS());
calculadorDeImpostos.Calcular(orcamento, new ISS());
