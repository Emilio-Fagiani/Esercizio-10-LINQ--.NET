using Esercizio_10_LINQ__;
using Esercizio_10_LINQ__.NET;

class Program
{
    static void Main()
    {
        Random random = new Random();

        List<int> numbers = Enumerable.Range(1, 100)
            .Select(_ => random.Next(1, 1000))
            .ToList();

        List<NumberMetaData> metaDataList = numbers.Select(number => new NumberMetaData
        {
            IsEven = number % 2 == 0,
            NumberOfCharacters = number.ToString().Length
        }).ToList();

        foreach (NumberMetaData metaData in metaDataList)
        {
            Console.WriteLine($"IsEven: {metaData.IsEven}, NumberOfCharacters: {metaData.NumberOfCharacters}");
        }
    }
}
