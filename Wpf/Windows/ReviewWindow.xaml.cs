using data_access.Entities;
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
using data_access;
using Microsoft.EntityFrameworkCore;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for ReviewWindow.xaml
    /// </summary>
    public partial class ReviewWindow : Window
    {
        IUoW uoW = new UnitOfWork();
        public ReviewWindow()
        {
            InitializeComponent();

            DataGrid_Review.ItemsSource = uoW.UserRepo.Get(includeProperties: "Position").Select(x => new
            {
                x.Id,
                x.NickName,
                x.Country,
                x.Date,
                PositionName = x.Position.Name
            });

            uoW.Save();

        }
    }
}
