using System.Reflection;
class ReflectFields
{
    public static string Name;
    public static int MeasureX, MeasureY, MeasureZ;
    public static void OutputField()
    {
        Type t = typeof(ReflectFields);
        int i = 0;
        string s = "string";
        foreach (FieldInfo member in t.GetFields())
        {
            i++;
            if (i > 1) s = "int";
            var value = member;
            Console.WriteLine(String.Format($"{member.Name} ({s}) = {value.GetValue(t)}"));
        }
    }
}