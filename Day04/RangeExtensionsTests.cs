namespace Advent2022.Day04;

public class RangeExtensionsTests
{
	[Theory]
	[InlineData(2, 4, 6, 8, false)]
	[InlineData(2, 8, 3, 7, true)]
	[InlineData(4, 6, 6, 6, true)]
	[InlineData(6, 6, 4, 6, false)]
	public void ContainsTests(int begin1, int end1, int begin2, int end2, bool expected)
	{
		var range1 = new Range(begin1, end1);
		var range2 = new Range(begin2, end2);

		var result = range1.Contains(range2);

		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData(2, 4, 6, 8, false)]
	[InlineData(2, 8, 3, 7, true)]
	[InlineData(5, 7, 7, 9, true)]
	public void OverlapTests(int begin1, int end1, int begin2, int end2, bool expected)
	{
		var range1 = new Range(begin1, end1);
		var range2 = new Range(begin2, end2);

		var result = range1.Overlaps(range2);

		Assert.Equal(expected, result);
	}
}
