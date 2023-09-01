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
    /// Interaction logic for LibraryWindow.xaml
    /// </summary>
    public partial class LibraryWindow : Window
    {
        IUoW uoW = new UnitOfWork();
        public LibraryWindow()
        {
            InitializeComponent();

            Library_DataGrid.ItemsSource = uoW.GameRepo.Get(includeProperties: "Category").Select(x => new
            {
                x.Id,
                x.Name,
                x.Description,
                x.Rate,
                CategoryName = x.Category.Name,
                //CompanyName = x.Company.Name,
            });

            uoW.Save();
        }
    }
}
