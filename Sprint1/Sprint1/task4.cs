//Please, create class DisposePatternImplementer that implements Disposable pattern and inherits from CloseableResource class
//Print such lines of information in the method responsible for releasing managed and unmanaged resources:
//"Disposing by developer" if the object of the class is disposed by developer
//or "Disposing by GC" if the object is disposed by garbage collector
//also, you should ensure that method Close() is called in either case.


//public class DisposePatternImplementer : CloseableResource
//{
//    private bool disposed = false;
//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }

//    protected virtual void Dispose(bool disposing)
//    {
//        if (!disposed)
//        {
//            if (disposing)
//                Console.WriteLine("Disposing by developer\nClosing resource");
//            else
//                Console.WriteLine("Disposing by GC\nClosing resource");
//            disposed = true;
//        }
//    }
//    ~DisposePatternImplementer() => Dispose(false);
//}