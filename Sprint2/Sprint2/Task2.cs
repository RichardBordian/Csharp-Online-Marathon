abstract class Car
{
    internal string mark = "h";
    internal int prodYear = 12;
    public Car(string mark, int prodYear)
    {
        mark = this.mark;
        prodYear = this.prodYear;
    }
    public void ShowInfo() => Console.WriteLine($"Mark : {mark};\nProducted in {prodYear}");
}
class SportCar : Car
{
    private int maxSpeed = 1;
    public SportCar(string mark, int prodYear, int maxSpeed) : base(mark, prodYear)
    { }
    public new void ShowInfo() => Console.WriteLine($"Mark : {mark};\nProducted in {prodYear}\nMaximum speed is {maxSpeed}");

}
class Lory : Car
{
    private double loadCapacity = 1.5;
    public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
    {
        loadCapacity = this.loadCapacity;
    }
    public new void ShowInfo() => Console.WriteLine($"Mark : {mark};\nProducted in {prodYear}\nThe load capacity is {loadCapacity}");
}