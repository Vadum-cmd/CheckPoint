namespace Presentation.ViewModels
{
    public class ReceiptsViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public int ActionId { get; set; }
    }
}