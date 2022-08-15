class MyProgram
{
    static void Factorial(object ab)
    {
        int a = (int)ab;
        int factorial = 1;
        for (int i = 1; i <= a; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Factorial is: {factorial}");
    }
    static void Fibbonaci(object ab)
    {
        int a = (int)ab;
        int[] arr = new int[a];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < 2) arr[i] = 1;
            if (i > 1) arr[i] = arr[i - 1] + arr[i - 2];
        }
        Console.WriteLine($"Fibbonaci number is: {arr[a - 1]}");
    }
    public static (Thread, Thread) Counter(int a)
    {
        Thread Fib = new Thread(new ParameterizedThreadStart(Fibbonaci));
        Thread Fact = new Thread(new ParameterizedThreadStart(Factorial));
        Fact.Start(a);
        Fib.Start(a);
        Thread.Sleep(1000);
        var result = (Fact, Fib);
        return result;
    }

}