﻿using System;

namespace Presentation.ViewModels
{
    public class InvoicesViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public DateTime DateOf { get; set; }
        public string Provider { get; set; }
        public int TotalPrice { get; set; }
    }
}