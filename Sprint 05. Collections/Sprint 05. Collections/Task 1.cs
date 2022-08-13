//In class MyProgram :
//1) Create a method that should take a collection of arguments Position(List<int> numbers) in which find and Console.WriteLine all positions of element 5 in this collection
//2) Create a method that should take a collection of arguments Remove(List<int> numbers) in which remove from collection all elements, which are greater than 20. and print collection
//3) Create a method that should take a collection of arguments Insert(List<int> numbers)  in which insert elements -5,-6,-7 in positions 3, 6, 8 and print collection
//4) Create a method that should take a collec  tion of arguments Sort(List<int> numbers) in which sorting collection and print collection

static class MyProgram
{
    public static void Position(List<int> numbers)
    {
        Enumerable.Range(0, numbers.Count).Where(x => numbers[x] == 5).ToList().ForEach(x => Console.WriteLine(x + 1));

    }
    public static void Remove(List<int> numbers)
    {
        numbers.Where(x => x <= 20).ToList().ForEach(x => Console.WriteLine(x));
    }
    public static void Insert(List<int> numbers)
    {
        numbers.Insert(2, -5);
        numbers.Insert(5, -6);
        numbers.Insert(7, -7);
        numbers.ForEach(x => Console.WriteLine(x));
    }
    public static void Sort(List<int> numbers)
    {
        numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
    }
}