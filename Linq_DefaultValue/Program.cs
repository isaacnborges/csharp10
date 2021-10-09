Console.WriteLine("*** FirstOrDefault, LastOrDefault e SingleOrDefault com parâmetros default ***");

PesquisaUltimasOlimpiadas();
UltimasDerrotasCopas();

void PesquisaUltimasOlimpiadas()
{
    var ultimasOlimpiadas = new string[]
    {
        "Rio de Janeiro 2016",
        "Londres 2012",
        "Pequim 2008",
        "Atenas 2004",
        "Sidney 2000"
    };

    // *** FirstOrDefault ***
    Console.WriteLine();
    Console.WriteLine("*** Pesquisa sobre as últimas 5 Olimpíadas ***");
    var textoPesquisaOlimpiada = ReadSearchString();
    if (!string.IsNullOrWhiteSpace(textoPesquisaOlimpiada))
    {
        var resultadoOlimpiada = ultimasOlimpiadas
            .Where(s => s.Contains(textoPesquisaOlimpiada, StringComparison.InvariantCultureIgnoreCase))
            .FirstOrDefault("### Ocorrência não encontrada! ###");
        Console.WriteLine($"Resultado = {resultadoOlimpiada}");
    }
}

void UltimasDerrotasCopas()
{
    var ultimasDerrotasCopas = new string[]
    {
        "Holanda 1974",
        "Italia 1982",
        "Franca 1986",
        "Argentina 1990",
        "Noruega 1998",
        "Franca 1998",
        "Franca 2006",
        "Holanda 2010",
        "Alemanha 2014",
        "Holanda 2014",
        "Belgica 2018"
    };

    Console.WriteLine();
    Console.WriteLine("*** Pesquisa sobre as 11 últimas derrotas do Brasil em Copas  ***");

    var textoPesquisaUltimaDerrota = ReadSearchString();

    // *** LastOrDefault ***
    if (!string.IsNullOrWhiteSpace(textoPesquisaUltimaDerrota))
    {
        var resultadoDerrota = ultimasDerrotasCopas
            .Where(s => s.Contains(textoPesquisaUltimaDerrota, StringComparison.OrdinalIgnoreCase))
            .LastOrDefault("### Derrota não encontrada! ###");
        Console.WriteLine($"Resultado = {resultadoDerrota}");
    }

    // *** SingleOrDefault ***
    Console.WriteLine();
    Console.WriteLine("*** E quanto a 1994? ***");
    var resultado1978 = ultimasDerrotasCopas
        .Where(s => s.EndsWith("1994"))
        .SingleOrDefault("Não houve derrota");
    Console.WriteLine($"1994 = {resultado1978}");
}


static string ReadSearchString()
{
    Console.Write("Digite um valor para pesquisa (sem caracteres especiais): ");
    var searchString = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(searchString))
        Console.WriteLine("### Não foi informado um valor para pesquisa! ###");

    return searchString;
}