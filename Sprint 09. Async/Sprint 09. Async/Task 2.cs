//class Calc
//{
//    public static int Seq(int n)
//    {
//        return n * n;
//    }
//}
//static class CalcAsync
//{
//    public async static Task TaskPrintSeqAsync(int n)
//    {
//        int a = await Task.Run(() => Calc.Seq(n));
//        Console.WriteLine($"Seq[{n}] = {a}");
//    }
//    public static void PrintStatusIfChanged(this Task task, ref TaskStatus status)
//    {
//        var s = status;
//        if (status != s)
//        {
//            Console.WriteLine(s);
//            status = s;
//        }
//    }
//    public static void TrackStatus(this Task task)
//    {
//        Console.WriteLine(TaskPrintSeqAsync(3));
//        Console.WriteLine(task.Status);
//        var s = task.Status;
//        while (task.Status == s)
//        {

//        }
//        Console.WriteLine(task.Status);
//    }
//}