//Please, create MyAccessModifiers class with next members:
//int field birthYear is unavailable anywhere except this class
//string field personalInfo that is accessible within descendants of this class
//string field IdNumber that is accessible only within descendants in the current assembly
//constructor should be available from everywhere in the program and accept int for birth year, string for idNumber, string for personalInfo parameters to initialize three fields mentioned above. (Note, that the order of parameters must be exact as described
//int property Age which returns the difference between the current year and birthYear and can be accessed everywhere, but only for reading
//common for all instances of the class byte field averageMiddleAge with default value 50
//string property Name accessible anywhere in the current assembly
//string property NickName that can be read anywhere in the program and set only in the current assembly
//method HasLivedHalfOfLife available only for descendants of the class in other assemblies and for all in the current.
//overload operator ==. The operator returns true if name, age, and personalInfo  of objects are equal
class MyAccessModifiers
{
    internal string Name { get; set; }
    private int birthYear;
    protected string personalInfo;
    private protected string IdNumber;
    int value;
    public int Age { get; } = 2022;
    byte averageMiddleAge = 50;
    public string NickName { get; internal set; } = "value";
    protected internal void HasLivedHalfOfLife()
    { }
    private MyAccessModifiers()
    { }
    public MyAccessModifiers(int a, string b, string c)
    {
        birthYear = a;
        personalInfo = c;
        IdNumber = b;
        Age -= a;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public static bool operator ==(MyAccessModifiers first, MyAccessModifiers second)
    {
        if (first.Name == second.Name && first.Age == second.Age && first.personalInfo == second.personalInfo)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(MyAccessModifiers first, MyAccessModifiers second)
    {

        if (first.Name == second.Name && first.Age == second.Age && first.personalInfo == second.personalInfo)
        {
            return false;
        }
        return true;
    }
}

