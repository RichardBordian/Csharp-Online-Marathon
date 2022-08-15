//We have class MainThreadProgram. Please create three methods: Calculator, Product and Sum.
//Method Sum() should ask user to enter 5 numbers in form “Enter the 1st number :”, “Enter the 2nd number :” etc.and calculate their sum. After that it should output the message “Sum is <sum>”. 
//Method Product() should generate a List of 10 consequent integer numbers from 1 to 10 and calculate their product. Then it should wait for 10 seconds. After that it should output the message “Product is <product>”. 
//The Calculator() method should create two threads: productThread and sumThread, and call the Product and Sum methods in appropriate threads. This method should return a tuple of two threads: (sumThread, productThread).

class MainThreadProgram
{
    public static void Sum()
    {
        double sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            if (i == 1) Console.WriteLine($"Enter the {i}st number:");
            if (i == 2) Console.WriteLine($"Enter the {i}nd number:");
            if (i == 3) Console.WriteLine($"Enter the {i}rd number:");
            if (i >= 4) Console.WriteLine($"Enter the {i}th number:");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Sum is: {sum}");
    }
    public static void Product()
    {
        Thread.Sleep(10000);
        int product = 1;
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for (int i = 0; i < list.Count; i++)
        {
            product *= list[i];
        }
        Console.WriteLine($"Product is: {product}");

    }
    public static (Thread, Thread) Calculator()
    {
        Thread sum = new Thread(Sum);
        Thread product = new Thread(Product);
        sum.Start();
        product.Start();
        Thread.Sleep(5000);
        var result = (sum, product);
        return result;
    }
}