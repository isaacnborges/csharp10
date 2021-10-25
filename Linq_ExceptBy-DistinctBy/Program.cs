using System.Text.Json;

var paises = new Pais[]{
                new () { Nome = "Alemanha", Continente = "Europa" },
                new () { Nome = "Australia", Continente = "Oceania" },
                new () { Nome = "Brasil", Continente = "America do Sul" },
                new () { Nome = "Canada", Continente = "America do Norte" },
                new () { Nome = "Chile", Continente = "America do Sul" },
                new () { Nome = "Espanha", Continente = "Europa" },
                new () { Nome = "Egito", Continente = "Africa" },
                new () { Nome = "Estados Unidos", Continente = "America do Norte" },
                new () { Nome = "Inglaterra", Continente = "Europa" },
                new () { Nome = "Italia", Continente = "Europa" },
                new () { Nome = "Japao", Continente = "Asia" },
                new () { Nome = "Russia", Continente = "Europa" },
            };

var paisesUniaoEuropeia = new Pais[]{
                new () { Nome = "Alemanha", Continente = "Europa" },
                new () { Nome = "Espanha", Continente = "Europa" },
                new () { Nome = "Franca", Continente = "Europa" },
                new () { Nome = "Italia", Continente = "Europa" }
            };

Console.WriteLine($"No. de elementos nos arrays: " +
                $"{nameof(paises)} = {paises.Length}, " +
                $"{nameof(paisesUniaoEuropeia)} = {paisesUniaoEuropeia.Length} ");

var paisesExcetoUniaoEuropeia = paises.ExceptBy(paisesUniaoEuropeia.Select(x => x.Nome), p => p.Nome);
ExibirResultado("Testes com ExceptBy (ignorando países da Uniao Europeia)", paisesExcetoUniaoEuropeia);

var paisesParcial = paises.Union(paisesUniaoEuropeia);
Console.WriteLine($"No. de elementos no Enumerable {nameof(paisesParcial)} = {paisesParcial.Count()}");

var paisesDistinct = paisesParcial.DistinctBy(p => p.Nome);
ExibirResultado($"Testes com DistinctBy (todos os países distintos em {nameof(paisesDistinct)})", paisesDistinct);

static void ExibirResultado(string tipoTeste, IEnumerable<Pais> paises)
{
    Console.WriteLine();
    Console.WriteLine($"*** {tipoTeste} ***");
    Console.WriteLine();

    Console.WriteLine($"No. de elementos: {paises.Count()}");
    Console.WriteLine();

    Console.WriteLine($"Dados: {JsonSerializer.Serialize(paises)}");
    Console.WriteLine();

    Console.WriteLine("Países:");
    foreach (var pais in paises)
        Console.WriteLine($"  * {pais.Nome} ({pais.Continente})");
    Console.WriteLine();
}

public class Pais
{
    public string? Nome { get; set; }
    public string? Continente { get; set; }
}