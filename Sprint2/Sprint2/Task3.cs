//Create three classes: Science, Mathematics and Physics. Organize inheritance in the correct way.
//Create method Awards() so that the next code
//  Science science1 = new Mathematics();
//  Science science1 = new Physics();
//  Science science1 = new Science();
//Gives the next output
//  We don't need any awards, but we still can obtain The Abel Prize that nobody else can!
//  We can obtain The Nobel Prize
//  We can obtain The Nobel Prize
//Keep your code as optimized as possible.
//Tip: use virtual method.

class Science
{
    public virtual void Awards() => Console.WriteLine("We can obtain The Nobel Prize");
}
class Mathematics : Science
{
    public override void Awards() => Console.WriteLine("We don't need any awards, but we still can obtain The Abel Prize that nobody else can!");
}
class Physics : Science
{
}