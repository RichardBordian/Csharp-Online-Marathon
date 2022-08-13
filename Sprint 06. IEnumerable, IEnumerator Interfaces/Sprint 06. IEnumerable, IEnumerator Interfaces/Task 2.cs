//Suppose, you have class Book :
//Please, implement class Library with public property Books of generic IEnumerable type that can be set only inside the class,
//and public property Filter(generic predicate) that sets a condition on book. The default value of Filter: any book satisfies the condition.
//The constructor of Library class takes 1 parameter for initialization Books property.
//Implement GetEnumerator method that will allow to enumerate by only those books that satisfy the condition in Filter.
//Do not use yields in this task.
//Create  MyEnumerator class that implements IEnumerator<Book>.
//The constructor of MyEnumerator takes 2 parameters: for initialization books and filter.
//Implement all the necessary methods and properties in MyEnumerator.
//Implement MyUtils class with public static method GetFiltered that takes generics IEnumerable and Predicate and returns list of filtered books using Library class and its enumerator.

//using System.Collections;

//public class Library
//{
//    IEnumerable Books { get; private set }
//}

//public sealed class MyEnumerator : //base interface here
//{
//    //your implementation
//}

//public class MyUtils
//{
//    //your implementation
//}
