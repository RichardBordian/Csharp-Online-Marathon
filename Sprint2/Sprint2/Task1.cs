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