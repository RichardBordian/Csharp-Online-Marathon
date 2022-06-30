//Create class Employee.
//Create two derived classes: Developer and Tester.
//Class Employee should contain internal string field name and private DateTime field hiringDate.
//Class Developer should contain private string field programmingLanguage.
//Class Tester should contain private bool field isAuthomation.
//Class Employee should contain public constructor that accepts two arguments (name and hiringDate).
//Class Employee should contain public int method Experience() that calculates the count off full years of experience. This method should be the same for the derived classes.
//Class Tester should contain the constructor that accepts three arguments: name, hiringDate and isAuthomation.
//Class Developer should contain the constructor that accepts three arguments: name, hiringDate and programmingLanguage.
//Class Employee should contain public void method ShowInfo() that prints the such string:
//"<name> has <Experience> years of experience".
//Class Developer should contain public void method ShowInfo() that prints the such string:
//"<name> has <Experience> years of experience
//< name > is < programmingLanguage > programmer".
//Please, pay attention that the first line as the same as for appropriate Employee’s method.
//Class Tester should contain public void method ShowInfo() that prints the such string
//“<name> is authomated tester and has <Experience> year(s) of experience”
//If isAuthomated field is true
//Or
//“<name> is manual tester and has <Experience> year(s) of experience”
//If isAuthomated field is false.

class Employee
{
    internal string name = "Programer";
    private DateTime hiringDate = new DateTime(2015);
    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }
    public int Experience()
    {
        TimeSpan TD = DateTime.Now.Subtract(hiringDate);
        return (int)(TD.TotalDays / 365.2425);
    }
    public void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}
class Developer : Employee
{
    private string programmingLanguage = "c#";
    public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
    {
        programmingLanguage = this.programmingLanguage;
    }
    public new void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience()} years of experience\n{name} is {programmingLanguage} programmer");
    }
}
class Tester : Employee
{
    private bool isAuthomation = false;
    public Tester(string name, DateTime hiringDate, bool isAuthomation) : base(name, hiringDate)
    {
        isAuthomation = this.isAuthomation;
    }
    public new void ShowInfo()
    {
        if (isAuthomation) Console.WriteLine($"{name} is authomated tester and has {Experience()} year(s) of experience");
        else Console.WriteLine($"{name} is manual tester and has {Experience()} year(s) of experience");
    }
}