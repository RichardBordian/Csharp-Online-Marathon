//public class Invoice
//{
//    MailSender s = new MailSender();

//    public long Amount { get; set; }
//    public DateTime InvoiceDate { get; set; }
//    public void Add()
//    {
//        Console.WriteLine("Adding amount...");
//        // Code for adding invoice
//        // Once Invoice has been added , send mail 
//        string mailMessage = "Your invoice is ready.";
//        s.SendEmail(mailMessage);
//    }
//    public void Delete()
//    {
//        Console.WriteLine("Deleting amount...");
//        // Code for Delete invoice
//    }
//    public void Check()
//    {
//        /// log check result to file
//    }
//    public void Debug()
//    {
//        /// log debug result to file
//    }
//    public void Info()
//    {
//        /// log info result to file
//    }

//}

//class MailSender
//{
//    public string From { get; set; }
//    public string To { get; set; }
//    public string Subject { get; set; }
//    public void SendEmail(string mailMessage)
//    {
//        Console.WriteLine("Sending Email: {0}", mailMessage);
//        // Code for getting Email setting and send invoice mail

//    }
//}
//class FileLogger : IFileLogger
//{
//    public void Check()
//    {
//        /// log check result to file
//    }
//    public void Debug()
//    {
//        /// log debug result to file
//    }
//    public void Info()
//    {
//        /// log info result to file
//    }

//}
//interface IFileLogger
//{
//    public void Check();
//    public void Debug();
//    public void Info();
////}