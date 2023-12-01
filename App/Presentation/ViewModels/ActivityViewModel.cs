namespace Presentation.ViewModels
{
    using System;

    public class ActivityViewModel : ViewModelBase
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public DateTime Time { get; set; }
    }
}