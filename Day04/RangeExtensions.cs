namespace Advent2022.Day04;

public static class RangeExtensions
{
	public static bool Contains(this Range range, Range other)
	{
		return
			other.Start.Value >= range.Start.Value &&
			other.End.Value <= range.End.Value;
	}

	public static bool Overlaps(this Range range, Range other)
	{
		return
			(other.Start.Value >= range.Start.Value && other.Start.Value <= range.End.Value) ||
			(other.End.Value >= range.Start.Value && other.End.Value <= range.End.Value);
	}
}
