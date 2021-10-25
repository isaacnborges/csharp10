Console.WriteLine("*** Example Chunk ***");

var numbers = Enumerable.Range(1, 1000);
var chunks = numbers.Chunk(100);

foreach (var chunk in chunks)
{
    Console.WriteLine($"{chunk.First()}...{chunk.Last()}");
}