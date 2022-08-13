//Create a ListDictionaryCompare() method of the MyUtils class to compare the contents of a List of strings and the values of a Dictionary. These collections must be passed as parameters of the method.
//      For example, for a given list [aa, bb, aa, cc] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc }
//you should get true.
//      For a given list [aa, bb, aa, cc, ddd] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc }
//you should get false
//      For a given list [aa, bb, aa, cc] and dictionary {1=cc, 2=bb, 3=cc, 4=aa, 5=cc, 6=ddd }
//you should get false
class abr
{
    public static bool ListDictionaryCompare(List<string> list, Dictionary<string, string> dict)
    {
        bool compare = list.SequenceEqual(dict.Values?.ToList());
        return compare;
    }
}