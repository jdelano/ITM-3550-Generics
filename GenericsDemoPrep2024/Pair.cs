using System;
namespace GenericsDemoPrep2024;

public class Pair<T> where T : IComparable<T>
{
	public T First { get; set; }
	public T Second { get; set; }

	public Pair(T first, T second)
	{
		First = first;
		Second = second;
	}

	public T GetLarger()
	{
		return First.CompareTo(Second) > 0 ? First : Second;
	}
}

