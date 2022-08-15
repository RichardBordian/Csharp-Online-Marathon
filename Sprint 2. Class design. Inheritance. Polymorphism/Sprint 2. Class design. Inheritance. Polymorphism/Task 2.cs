//Create abstract class Car and two derived classes: SportCar and Lory.
//Class Car should have the next fields: internal string mark, internal int prodYear.
//Class SportCar should have the next fields: internal string mark, internal int prodYear, private int maxSpeed.
//Class Lory should have internal string mark, internal int prodYear and private double loadCapacity.
//Create also appropriable constructors that allow create class instances with all the fields.
//Every class should have public void method ShowInfo().
//For class Car this method should display message:
//“Mark: < mark >,
//Producted in < prodYear >”
//For SportCar this method should display message:
//“Mark: < mark >,
//Producted in < prodYear >
//Maximum speed is < maxSpeed >”
//For Lory this method should display message.
//“Mark: < mark >,
//Producted in < prodYear >
//The load capacity is <loadCapacity>”
//Please organize the code optimally.

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

