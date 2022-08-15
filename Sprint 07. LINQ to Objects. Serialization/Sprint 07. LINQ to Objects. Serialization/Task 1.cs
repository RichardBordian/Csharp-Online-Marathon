//Please, implement the SumOfElementsOddPositions method that returns sum of elements with odd indexes in the array of doubles
class Task1
{
    public static void EvaluateSumOfElementsOddPositions(double[] inputData)
    {
        var c = inputData.Select((num, index) => new
        {
            Numbers = num,
            IndexPosition = index
        }).Where(x => x.IndexPosition % 2 != 0)
                                         .Select(data => new
                                         {
                                             Number = data.Numbers,
                                             IndexPosition = data.IndexPosition
                                         })
                                         ;
        foreach (var c2 in c)
            Console.WriteLine(c2);
    }
}