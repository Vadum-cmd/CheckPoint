namespace DAL.Entities
{
    public class ProductReceipt
    {
        required public int ReceiptId { get; set; }

        required public int ProductId { get; set; }

        required public int Amount { get; set; }

        required public float Price { get; set; }

        public int? ActionId { get; set; }

        required public Receipt Receipt { get; set; }

        required public Product Product { get; set; }

        public Action? Action { get; set; }
    }
}