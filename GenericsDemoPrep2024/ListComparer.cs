using System;
namespace GenericsDemoPrep2024;

public class ListComparer
{
    public static List<T> GetLargerThan<T>(List<T> list, T listItem) where T : IComparable<T>
    {
        var newList = new List<T>();
        foreach (var item in list)
        {
            if (item.CompareTo(listItem) > 0)
            {
                newList.Add(item);
            }
        }
        return newList;
    }
}

