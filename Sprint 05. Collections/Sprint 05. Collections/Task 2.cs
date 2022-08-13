//1) In class MyProgram please create a method that should take a collection of arguments SearchKeys(Dictionary<string, string> persons) in which print all keys from this collection
//2) method that should take a collection of arguments SearchValues(Dictionary<string, string> persons) in which print all values from this collection
//3) and method that should take a collection of arguments SearchAdmin(Dictionary<string, string> persons) in which search value "Admin" and print information in format Key + " " + Value 

class MyProgra
{
    public static void SearchKeys(Dictionary<string, string> persons)
    {
        List<string> keylist = new List<string>(persons.Keys);
        keylist.ForEach(p => Console.WriteLine(p));
    }
    public static void SearchValues(Dictionary<string, string> persons)
    {
        List<string> valuelist = new List<string>(persons.Values);
        valuelist.ForEach(p => Console.WriteLine(p));
    }
    public static void SearchAdmin(Dictionary<string, string> persons)
    {
        var pers = persons.ToDictionary(x => x.Value, x => x.Key).Where(x => x.Key == "Admin");
        foreach (var person in pers)
            Console.WriteLine(person.Value + " " + person.Key);
    }
}