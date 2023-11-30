using DAL.Entities;
using DAL;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation.Views
{
    /// <summary>
    /// Interaction logic for SaleStatisticView.xaml
    /// </summary>
    public partial class SaleStatisticView : UserControl
    {
        public List<SaleStatistic> Data { get; set; }
        public List<SaleStatisticViewModel> StatisticsViewModels { get; set; }
        public SaleStatisticView()
        {
            InitializeComponent();
            DataContext = this;

            Data = UserQueries.GetStatistics();
            StatisticsViewModels = new List<SaleStatisticViewModel>();

            foreach (var statistic in Data)
            {
                StatisticsViewModels.Add(new SaleStatisticViewModel
                {
                    Id = statistic.Id,
                    SaleStatisticProductId = statistic.SaleStatisticProductId,
                    SoldOut = statistic.SoldOut == null ? 0 : (int)statistic.SoldOut,
                    SaleDate = statistic.SaleDate == null ? DateTime.MinValue : (DateTime)statistic.SaleDate,
                    Expired = statistic.Expired == null ? 0 : (int)statistic.Expired
                });
            }
        }
    }
}
