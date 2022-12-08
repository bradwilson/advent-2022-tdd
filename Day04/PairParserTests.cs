namespace Advent2022.Day04;

public class PairParserTests
{
	[Theory]
	[InlineData("2-4,6-8", 2, 4, 6, 8)]
	[InlineData("2-3,4-5", 2, 3, 4, 5)]
	[InlineData("5-7,7-9", 5, 7, 7, 9)]
	public void CanParsePairOfRanges(
		string input,
		int firstStart,
		int firstEnd,
		int secondStart,
		int secondEnd)
	{
		var sut = new PairParser();

		var (first, second) = sut.Parse(input);

		Assert.Equal(firstStart, first.Start);
		Assert.Equal(firstEnd, first.End);
		Assert.Equal(secondStart, second.Start);
		Assert.Equal(secondEnd, second.End);
	}

	[Fact]
	public void CannotParseNull()
	{
		var sut = new PairParser();

		Assert.Throws<ArgumentNullException>("input", () => sut.Parse(null!));
	}

	[Fact]
	public void EmptyStringThrows()
	{
		var sut = new PairParser();

		var ex = Assert.Throws<ArgumentException>("input", () => sut.Parse(""));
		Assert.StartsWith("Expected data in format of '##-##,##-##", ex.Message);
	}
}
