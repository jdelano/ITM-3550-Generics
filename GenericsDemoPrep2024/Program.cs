namespace GenericsDemoPrep2024;

class Program
{
    static void Main(string[] args)
    {
        var pair = new PairOld("Hello", 5);
        // Note that the compiler does not see the line below as an error, but
        // this line will cause the code to crash!
        //int value = (int)pair.First;

        var pair2 = new Pair<string>("Hello", "World");
        // If you uncomment the line below, the compiler knows this is an error
        //int value2 = (int)pair2.First;

        List<int> numbers = new List<int> { 1,2,3,4 };
        var largerThan2 = ListComparer.GetLargerThan(numbers, 2);
        largerThan2.ForEach(Console.WriteLine);
    }
}


