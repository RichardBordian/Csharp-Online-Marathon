bool ListDictionaryCompare1(List<string> list, Dictionary<string, string> dict)
{
    bool compare = list.SequenceEqual(dict.Values?.ToList());
    return compare;
}

List<string> lst = new List<string>() { "aa", "bb", "aa", "cc" };
List<string> lst2 = new List<string>() { "aa", "bb", "aa", "cc", "ddd" };
List<string> lst3 = new List<string>() { "aa", "bb", "aa", "cc" };
Dictionary<string, string> dct = new Dictionary<string, string>()
{
    { "1=", "cc"},
    { "2=", "bb"},
    { "3=", "cc"},
    { "4=", "aa"},
   // { "5=", "cc"},
};
Dictionary<string, string> dct2 = new Dictionary<string, string>()
{
    { "1=", "cc"},
    { "2=", "bb"},
    { "3=", "cc"},
    { "4=", "aa"},
    { "5=", "cc"},
};
Dictionary<string, string> dct3 = new Dictionary<string, string>()
{
    { "1=", "cc"},
    { "2=", "bb"},
    { "3=", "cc"},
    { "4=", "aa"},
    { "5=", "cc"},
    { "6=", "ddd"},
};
Console.WriteLine(ListDictionaryCompare1(lst, dct));
Console.WriteLine(ListDictionaryCompare1(lst2, dct2));
Console.WriteLine(ListDictionaryCompare1(lst3, dct3));