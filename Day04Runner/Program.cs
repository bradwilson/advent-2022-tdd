using Advent2022.Day04;

#if false
// Expected results for simple: 2, 4
var testData = File.ReadAllLines("data-simple.txt");
#else
// Expected results for complete: 532, 854
var testData = File.ReadAllLines("data-complete.txt");
#endif

var parser = new PairParser();
var contains = 0;

foreach (var line in testData)
{
	var (first, second) = parser.Parse(line);
	if (first.Contains(second) || second.Contains(first))
		contains++;
}

Console.WriteLine($"Part 1: {contains}");

var overlaps = 0;

foreach (var line in testData)
{
	var (first, second) = parser.Parse(line);
	if (first.Overlaps(second) || second.Overlaps(first))
		overlaps++;
}

Console.WriteLine($"Part 2: {overlaps}");
