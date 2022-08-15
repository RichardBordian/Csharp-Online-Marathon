class MyTasks
{

    public static void Tasks()
    {
        Console.WriteLine("Calculated!");
        int[] sequence_array = new int[10];

        Task[] task1 = new Task[2]
        {
        new Task(() =>
        {
            for (int i=0; i<10;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bye!");
        }),
        new Task(() =>
        {
            for (int i =0; i<10; i++)
            {
                sequence_array[i] = i*i;
                Console.WriteLine(sequence_array[i]);
            }
            Console.WriteLine("Bye!");
        })
        };
        foreach (var v in task1)
        {
            v.Start();
            v.Wait();
        }
        Console.WriteLine("Main done!");
    }
}