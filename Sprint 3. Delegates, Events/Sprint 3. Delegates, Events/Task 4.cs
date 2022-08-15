//Define a class IListExtensions with an extension method IncreaseWith(…) 
//that takes an instance of a class, that implements the interface list of integers(IList<int>). Method IncreaseWith(…) increases the value of each item by a certain number.     
//Define a class IEnumerableExtensions with an extension method ToString(). 
//ToString() loops through a collection and converts a sequence of elements (list of integers) to a meaningful string (items separated with ', ' and surrounded with '[' and ']').
//Use IncreaseWith() and ToString() extention methods in such a way:

//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//Console.WriteLine(numbers.ToString<int>());
//numbers.IncreaseWith(5);
//Console.WriteLine(numbers.ToString<int>());

//Output:
//[1, 2, 3, 4, 5]
//[6, 7, 8, 9, 10]

static class IListExtensions
{
    public static List<int> IncreaseWith(this List<int> list, int i)
    {
        for (int j = 0; j < list.Count; j++)
            list[j] += i;
        return list;
    }
}

static class IEnumerableExtensions
{
    public static string ToString<T>(this List<int> list)
    {
        string str = string.Empty;
        for (int i = 0; i < list.Count; i++)
        {
            if (i == list.Count - 1) str += list[i];
            else str += list[i] + ", ";
        }
        return "[" + str + "]";
    }
}

