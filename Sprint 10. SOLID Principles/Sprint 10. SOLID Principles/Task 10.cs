public interface ILogger
{
    public void LogMessage(string s);
}
public class DbLogger : ILogger
{
    public void LogMessage(string mMessage)
    {
    }
}

public class FileLogger : ILogger
{
    public void LogMessage(string mStackTrace)
    {
    }
}

public class ExceptionLogger
{
    private ILogger _logger;
    public ExceptionLogger(ILogger i)
    {
        _logger = i;
    }
    public void LogException(Exception mException)
    {
        DbLogger objDbLogger = new DbLogger();
        objDbLogger.LogMessage(GetUserReadableMessage(mException));
        FileLogger objFileLogger = new FileLogger();
        objFileLogger.LogMessage(GetUserReadableMessage(mException));
    }
    private string GetUserReadableMessage(Exception ex)
    {
        string strMessage = string.Empty;
        //code to convert Exception's stack trace and message to user   
        // readable format.  
        return strMessage;
    }
}

public class DataExporter
{
    public void ExportDataFromFile()
    {
        try
        {
            //code to export data from files to database.  
        }
        catch (IOException ex)
        {
        }
        catch (Exception ex)
        {
        }
    }
}