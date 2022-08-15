//Define an Interface IShape with declared method Area() returning 0 by default(double type)
//Define a class named Rectangle implementing the IShape interface.
//In this class, define Length and Width properties(double type)
//Implement the Area() method to calculate a rectangle area
//Define a class named Trapezoid implementing the IShape interface.
//In this class, define Length1, Length2 and Width properties(double type)
//Implement the Area() method to calculate a trapezoid area
//Define a generic class named Room<> depending on a shape of it's floor.
//Impose a constraint for type argument of the Room generic class so that it should implement the IShape interface
//In this class, define a Height property(double type) and the Floor property(type argument)
//Implement the Volume() method to calculate a volume of the room.
//Add an implementation of ICloneable interface for the Room<> class
//Implement deep cloning
//Add an implementation of IComparable interface for the Room<> class.
//Implement a comparison by area of the floor.
//Define a generic class RoomComparerByVolume<> implementing IComparer interface.
//Impose a constraint on the type argument so that it should implement the IShape interface.
//This comparer should perform comparison of rooms by room volume.

public interface IShape
{
    sealed public double Area() => 0;
}
public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Area(double Length, double Width) => Length * Width;
}
public class Trapezoid : IShape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Width { get; set; }
    public double Area(double Length1, double Length2, double Width) => 0.5 * (Length1 + Length2) * Width;
}

public class Room<T> where T : IShape
{
    public double Height { get; set; }
    public double Volume(double Height, ref T Floor) => Height * (double)((object)Floor);
}
