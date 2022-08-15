using System.Reflection;
class ReflectMethod
{
    public static class Methods
    {
        public static void Hello(string par) =>
            Console.WriteLine($"Hello:parameter={par}");

        public static void Welcome(string par) =>
            Console.WriteLine($"Welcome:parameter={par}");
        public static void Bye(string par) =>
            Console.WriteLine($"Bye:parameter={par}");
    }
    public static void InvokeMethod(string[] par)
    {
        Type myType = typeof(Methods);
        int i = 0;
        foreach (MethodInfo method in myType.GetMethods(
             BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public))
        {
            if (i == 3) break;
            i++;
            method?.Invoke(myType, new object[] { par[0] });
            method?.Invoke(myType, new object[] { par[1] });
        }
    }
}