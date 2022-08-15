public class Parrot : Bird, IFlyable, IEating, IBasking, IKryaking, IMoving
{
    public void Eat() => Console.WriteLine("Oh! My seeds and fruits!");

    public void Bask() => Console.WriteLine("Chuh-Chuh-Chuh...");
    public void Krya() => Console.WriteLine("Krya-Krya-Krya...");
    public void Move() => Console.WriteLine("I can jump!");
}
public class Bird : IFlyable, IEating, IMoving
{
    public void Fly() => Console.WriteLine("I believe, I can fly");
    public void Eat() => Console.WriteLine("Oh! My corn!");
    public void Move() => Console.WriteLine("I can jump!");
}
public class Duck : Bird, IFlyable, IEating, IMoving, IKryaking
{
    public void Eat() => Console.WriteLine("Oh! My corn!");
    public void Move() => Console.WriteLine("I can swimm!");
    public void Krya() => Console.WriteLine("Krya-Krya!");
}
public class Cat : IMoving, IEating, IBasking
{
    public void Move() => Console.WriteLine("I can jump!");
    public void Eat() => Console.WriteLine("Oh! My milk!");
    public void Bask() => Console.WriteLine("Mrrr-Mrrr-Mrrr...");
}
public interface IFlyable
{
    public void Fly();
}
public interface IEating
{
    public void Eat();
}
public interface IMoving
{
    public void Move();
}
public interface IBasking
{
    public void Bask();
}
public interface IKryaking
{
    public void Krya();
}