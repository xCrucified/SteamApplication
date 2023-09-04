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
using Wpf.Windows;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ReviewWindow rw = new ReviewWindow();
        LibraryWindow lw = new LibraryWindow();
        GameListWindow gw = new GameListWindow();
        GroupsWindow gpw = new GroupsWindow();
        AddGroupWindow agw = new AddGroupWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void ClearOutlinedComboBox_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxTxt.Text = string.Empty;
        }

        private void ClearOutlinedComboBox_Click2(object sender, RoutedEventArgs e)
        {
            ComboBoxTxt2.Text = string.Empty;
        }

        private void ClearOutlinedComboBox_Click3(object sender, RoutedEventArgs e)
        {
            ComboBoxTxt3.Text = string.Empty;
        }

        private void ReviewsList_Click(object sender, MouseButtonEventArgs e)
        {
            rw.Show();
        }

        private void LibraryList_Click(object sender, MouseButtonEventArgs e)
        {
            lw.Show();
        }

        private void GameList_Click(object sender, MouseButtonEventArgs e)
        {
            gw.Show();
        }

        private void Groups_Click(object sender, MouseButtonEventArgs e)
        {
            gpw.Show();
        }

        private void AddGroup_Click(object sender, MouseButtonEventArgs e)
        {
            agw.Show();
        }
    }
}
