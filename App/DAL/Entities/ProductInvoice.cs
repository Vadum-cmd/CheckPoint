namespace DAL.Entities
{
    public class ProductInvoice
    {
        required public int InvoiceId { get; set; }

        required public int ProductId { get; set; }

        required public int Amount { get; set; }

        required public Invoice Invoice { get; set; }

        required public Product Product { get; set; }
    }
}