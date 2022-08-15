public class Customer
{
    private INotification _inotification;
    public Customer(INotification i)
    {
        _inotification = i;
    }
    public void SendNotification(INotification not)
    {
        not.SendNotification();
    }
    public void Register(string email, string password)
    {
        try
        {
        }
        catch (Exception ex)
        {

        }
    }

}
public class MailService : INotification, INotificationToDB, INotificationToDBRead
{
    public string Email { get; set; }
    public string EmailTitle { get; set; }
    public string EmailBody { get; set; }
    public bool ValidEmail()
    {
        return Email.Contains("@");
    }
    public void SendNotification()
    {
        Console.WriteLine(String.Format("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody));
    }
    public void AddNotificationToDB()
    {

    }
    public void ReadNotification()
    {

    }
}
public class SmsService : INotification
{
    public string Number { get; set; } = "111 111 111";
    public string SmsText { get; set; } = "User successfully registered...";
    public void SendNotification()
    {
        Console.WriteLine(String.Format("Number:{0}, Message:{1}", Number, SmsText));
    }
}

public interface INotification
{
    public void SendNotification();
}
public interface INotificationToDB
{
    public void AddNotificationToDB();
}
public interface INotificationToDBRead
{
    public void ReadNotification();
}