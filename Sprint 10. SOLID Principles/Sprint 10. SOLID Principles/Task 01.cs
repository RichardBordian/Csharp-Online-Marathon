//public class Customer
//{
//    public void Register(string email, string password)
//    {
//        MailService ms = new MailService();
//        try
//        {
//            if (ms.ValidEmail(email))
//            {
//                ms.SendEmail(email, "Email title", "Email body");
//            }
//        }
//        catch (Exception ex)
//        {
//            throw;
//        }
//    }
//}
//public class MailService
//{
//    public bool ValidEmail(string email)
//    {
//        return email.Contains("@");
//    }
//    public void SendEmail(string mail, string emailTitle, string emailBody)
//    {
//        Console.WriteLine(string.Format($"Mail:{mail}, Title:{emailTitle}, Body:{emailBody}"));
//    }
//}