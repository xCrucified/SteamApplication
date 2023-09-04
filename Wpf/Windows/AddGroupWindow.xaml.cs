using data_access.Entities;
using SteamApplication.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddGroupWindow.xaml
    /// </summary>
    public partial class AddGroupWindow : Window
    {
        public AddGroupWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name1 = Name_txtBlox.Text;
            Random random = new Random();
            int fol = random.Next();
            int fol1 = random.Next(1,5);

            var entity = new Groups
            {
                Name = name1,
                Followers = fol,
                Rate = fol1
            };

            using (var cx = new SteamDb())
            {
                cx.Groups.Add(entity);
                cx.SaveChanges();

                MessageBox.Show("Apply");
            }
        }
    }
}
