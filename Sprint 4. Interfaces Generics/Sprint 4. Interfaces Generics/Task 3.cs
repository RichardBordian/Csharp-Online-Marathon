//Define ColourEnum enum consisting of 3 colours: red, green, blue(give names according to the convention).
//Define an interface IColoured with read-only property Colour returning red colour by default (use default implementation for this property).
//Define an interface IDocument with the following members:
//- static field defaultText with the value "Lorem ipsum";
//- public property Pages, which means the number of pages, with default implementation returning 0 by default;
//- public property Name without default implementation(String);
//-method AddPages with default implementation that increments the property Pages by the number which is input parameter of the method;
//-method Rename with default implementation that changes the property Name to the one specified as input parameter of the method.
//Define a class ColouredDocument implementing both interfaces above. The class should have public properties Name, Pages and Colour.Do not implement any methods in the class. Define a constructor for this class with colour parameter along with default constructor.
//Define a class Example with a void static method Do.In this method, create an instance doc1 of the class ColouredDocument with Name = "Document1".Change the name of the document to "Document2" using the Rename method.Print into console this property before and after renaming.
enum ColourEnum
{
    Red,
    GBluereen,
    Blue
}

interface IColoured
{
    ColourEnum Colour { get => ColourEnum.Red; }
}
interface IDocument
{
    static string defaultText = "Lorem ipsum";
    public int Pages { get => 0; set { } }
    public string Name { get; set; }
    public void AddPages(int pages) => Pages += pages;
    public void Rename(string newName) => Name = newName;
}
class ColouredDocument : IColoured, IDocument
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public ColourEnum Colour { get; set; }
    public ColouredDocument(ColourEnum colour)
    {
        Colour = colour;
    }
    public ColouredDocument()
    {
    }
}
class Example
{
    public static void Do()
    {
        IDocument doc1 = new ColouredDocument();
        doc1.Name = "Document1";
        Console.WriteLine(doc1.Name);
        doc1.Rename("Document2");
        Console.WriteLine(doc1.Name);
    }
}