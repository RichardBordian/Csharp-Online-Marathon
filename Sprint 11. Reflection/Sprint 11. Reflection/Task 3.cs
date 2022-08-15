using System.Reflection;
class ReflectProperties
{
    public class TestProperties
    {
        public string FirstName { get; set; }
        internal string LastName { get; set; }
        protected int Age { get; set; }
        private string PhoneNumber { get; set; }
    }
    public static void WriteProperties()
    {
        Type t = typeof(TestProperties);
        foreach (var property in t.GetProperties(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        {
            bool isPublic = property.GetGetMethod(true).IsPublic;
            bool isPrivate = property.GetGetMethod(true).IsPrivate;
            bool isProtected = property.GetGetMethod(true).IsFamily;
            bool isAssembly = property.GetGetMethod(true).IsAssembly;
            Console.WriteLine($"Property name: {property.Name}");
            Console.WriteLine($"Property type: {property.PropertyType}");
            Console.WriteLine($"Read-Write:    {property.CanWrite}");
            if (isPublic) Console.WriteLine($"Accessibility: Public");
            if (isPrivate) Console.WriteLine($"Accessibility: Private");
            if (isProtected) Console.WriteLine($"Accessibility: Protected");
            if (isAssembly) Console.WriteLine($"Accessibility: Internal");
            Console.WriteLine();
        }
    }
}