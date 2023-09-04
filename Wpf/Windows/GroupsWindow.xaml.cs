using data_access.Repositories;
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
using System.Windows.Shapes;

namespace Wpf.Windows
{
    /// <summary>
    /// Interaction logic for GroupsWindow.xaml
    /// </summary>
    public partial class GroupsWindow : Window
    {
        IUoW uoW = new UnitOfWork();
        public GroupsWindow()
        {
            InitializeComponent();

            Groups_DataGrid.ItemsSource = uoW.GroupRepo.Get().Select(x => new
            {
                x.Id,
                x.Name,
            });

            uoW.Save();
        }
    }
}
