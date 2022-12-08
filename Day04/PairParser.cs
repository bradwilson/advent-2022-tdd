using System.Text.RegularExpressions;

namespace Advent2022.Day04;

public partial class PairParser
{
	static Regex regex = PairRegex();

	public (Range first, Range second) Parse(string input)
	{
		if (input == null)
			throw new ArgumentNullException(nameof(input));

		var match = regex.Match(input);
		if (!match.Success)
			throw new ArgumentException("Expected data in format of '##-##,##-##", nameof(input));

		return (
			new(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value)),
			new(int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value))
		);
	}

	[GeneratedRegex("(\\d+)-(\\d+),(\\d+)-(\\d+)")]
	private static partial Regex PairRegex();
}
