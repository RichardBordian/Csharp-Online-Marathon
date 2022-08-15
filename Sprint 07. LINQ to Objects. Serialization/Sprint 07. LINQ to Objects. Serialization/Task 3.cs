//Please, create a method ProductWithCondition that takes a list of integers as a parameter and returns a product of elements that satisfy a condition that is passed as a second parameter.
//The second parameter should be a Func that takes an integer as a parameter and returns bool.
//If the first parameter or result of filtering contains 0 elements the method must return 1.
class Task3
{
    public static int ProductWithCondition(List<int> list, Func<int, bool> predicate)
    {
        if (list.Count == 0)
            return 1;
        var c = list.Where(predicate).Aggregate((n1, n2) => n1 * n2);
        if (c == 0)
            return 1;
        else return c;
    }
}