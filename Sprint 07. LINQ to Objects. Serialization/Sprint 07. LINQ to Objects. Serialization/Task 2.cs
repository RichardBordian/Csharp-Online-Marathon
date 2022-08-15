//Please, implement EvaluateAggregate method that takes 
//     an array of doubles as the first parameter,
//     a delegate that defines an aggregate behavior as the second,
//     a delegate that defines a condition for the index as the third parameter.
//The method should return a result of an aggregate operation for the elements with indexes that satisfy the condition set by the third parameter
class Task2
{
    public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate)
    {
        double result = inputData.Aggregate((d1, d2) => aggregate(d1, d2));
        return result;
    }
}