static class Calc
{
    public static int Seq(int n)
    {
        return n * n;
    }
}
static class CalcAsync
{
    public async static Task<int> SeqAsync(int n) => await Task.Run(() => Calc.Seq(n));

    public static async void PrintSeqElementsConsequentlyAsync(int quant)
    {
        var tasks = new List<Task>();

        for (int i = 0; i < quant; i++)
        {
            var j = i;
            tasks.Add(Task.Run(() =>
            {
                SeqAsync(j);
                Console.WriteLine($"Seq[{j}] = {SeqAsync(j)}");
            }));
        }
        await Task.WhenAll(tasks.ToArray());
    }
    public static async void PrintSeqElementscaInParallelAsync(int quant)
    {
        var tasks = new List<Task>();

        for (int i = 0; i < quant; i++)
        {
            var j = i;

            tasks.Add(Task.Run(() => SeqAsync((int)j)));
        }
        await Task.WhenAll(tasks.ToArray());
    }
}