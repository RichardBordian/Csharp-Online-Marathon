int[] numbers = { 9, 3, 5, 4, 2, 6, 7, 1, 8 };
var query = numbers.TakeWhile((n, index) => n >= index);
foreach (var i in query)
    Console.WriteLine(i);