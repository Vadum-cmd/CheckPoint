using DAL;
using DAL.Entities;
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
    /// Interaction logic for ActivityView.xaml
    /// </summary>
    public partial class ActivityView : UserControl
    {
        public List<EmployeeSession> Data { get; set; }
        public List<ActivityViewModel> ActionsViewModels { get; set; }
        public ActivityView()
        {
            InitializeComponent();
            DataContext = this;

            Data = UserQueries.GetSessions();
            ActionsViewModels = new List<ActivityViewModel>();

            foreach (var action in Data)
            {
                ActionsViewModels.Add(new ActivityViewModel
                {
                    Id = action.Id,
                    EmployeeId = action.EmployeeId,
                    Time = action.Time
                });
            }
        }
    }
}
