
//class Calc
//{
//    public static int Seq(int n)
//    {
//        return n * n;
//    }
//}

//static class CalcAsync
//{
//    public async static void PrintSpecificSeqElementsAsync(int[] n)
//    {
//        Task allTasks = null;
//        for (int i = 0; i < n.Length; i++)
//        {
//            try
//            {
//                int a = await Task.Run(() => Calc.Seq(n[i]));
//                Console.WriteLine($"Seq[{n[i]}] = {a}");
//                await Task.WhenAll();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Exception: " + ex.Message);
//                Console.WriteLine("IsFaulted: " + allTasks.IsFaulted);
//                foreach (var inx in allTasks.Exception.InnerExceptions)
//                {
//                    Console.WriteLine("Inner exception: " + inx.Message);
//                }
//            }
//        }
//    }
//}