//Create a Point class which models a 2D point with x and y coordinates should contain:
//Two instance variables x and y  of int type, that will be available only in this class.
//A constructor that constructs a point with the given x and y coordinates.
//A method GetXYPair() which returns the x and y in a 2-element int array. This method should be available everywhere in the current assembly
//A method called Distance(int x, int y) that returns the distance (double) from this point to another point at the given (x, y) coordinates.
//An overloaded Distance(Point point) method that returns the distance from this point to the given Point instance.
//The distance methods should be available everywhere in the current assembly and in descendant classes in other assemblies;
//Create explicit cast to double operator that returns the distance (double) from this point to the origin (0, 0).
class Point
{
    private Point()
    { }
    readonly int x, y;
    public Point(int _X, int _Y)
    {
        x = _X;
        y = _Y;
    }
    internal int[] GetXYPair()
    {
        int[] array = new int[2] { x, y };
        return array;
    }
    protected internal double Distance(int x, int y)
    {
        double xx = Math.Pow(this.x - x, 2);
        double yy = Math.Pow(this.y - y, 2);
        double a = Math.Sqrt(xx + yy);
        return a;
    }
    protected internal double Distance(Point point)
    {
        double xx = Math.Pow(x - point.x, 2);
        double yy = Math.Pow(y - point.y, 2);
        double a = Math.Sqrt(xx + yy);
        return a;
    }
    public static explicit operator double(Point point)
    {
        double xx = Math.Pow(point.x - 0, 2);
        double yy = Math.Pow(point.y - 0, 2);
        double a = Math.Sqrt(xx + yy);
        return a;
    }
}

