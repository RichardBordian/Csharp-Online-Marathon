public enum InvoiceType
{
    Final,
    Proposed,
    Recurring,
    Ordinary
};
public abstract class Invoice
{
    public InvoiceType InvoiceType { get; set; }
    public double GetDiscount(double amount) => InvoiceType switch
    {
        InvoiceType.Final => new FinalInvoice().GetDiscount(amount),
        InvoiceType.Proposed => new ProposedInvoice().GetDiscount(amount),
        InvoiceType.Recurring => new RecurringInvoice().GetDiscount(amount),
        InvoiceType.Ordinary => new OrdinaryInvoice().GetDiscount(amount),
    };
}
public class FinalInvoice : Invoice
{
    public double GetDiscount(double amount) => amount - amount * 0.03;
}
public class ProposedInvoice : Invoice
{
    public double GetDiscount(double amount) => amount - amount * 0.05;
}
public class RecurringInvoice : Invoice
{
    public double GetDiscount(double amount) => amount - amount * 0.1;
}
public class OrdinaryInvoice : Invoice
{
    public double GetDiscount(double amount) => amount - amount * 0.01;
}