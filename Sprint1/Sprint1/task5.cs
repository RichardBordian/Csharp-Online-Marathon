//Please, make refactoring of the code:
//      We know that adult  doesn't have childIDNumber 
//       child doesn't have passportNumber.
//       Create a public constructor in each class to initialize all their fields (make the first parameter of type int and the second one for name initialization).
//       Accessibility of the fields should be the least possible, but the same in all assemblies.
//       Add ToString() method to Child and Adult classes that will return a string in the format: "name document_number"
//    public class Person
//{
//    protected string childIDNumber;
//}
//public class Child
//{
//    private int yearOfBirth;
//    private string healthInfo;
//    private string name;
//    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
//}
//public class Adult
//{
//    private int yearOfBirth;
//    private string healthInfo;
//    private string passportNumber;
//    private string name;
//    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
//}

public class Person
{

    protected int yearOfBirth;
    protected string healthInfo;
    protected string name;
    public Person(int a, string s1, string s2)
    {
        yearOfBirth = a;
        healthInfo = s2;
        name = s1;

    }
    internal Person()
    {
    }
    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
}
public class Child : Person
{
    private string childIDNumber;
    private Child() : base()
    { }

    public Child(int a, string s1, string s2, string s3) : base(a, s1, s2)
    {
        childIDNumber = s3;
    }
    public override string ToString()
    {
        return this.name + " " + this.childIDNumber;
    }
}
public class Adult : Person
{
    private string passportNumber;
    private Adult() { }
    public Adult(int a, string s1, string s2, string s3) : base(a, s1, s2)
    {
        passportNumber = s3;
    }
    public override string ToString()
    {
        return this.name + " " + this.passportNumber;
    }
}