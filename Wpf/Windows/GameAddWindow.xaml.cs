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
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using data_access.Entities;
using MaterialDesignThemes.Wpf;
using System.Runtime.ConstrainedExecution;
using SteamApplication.DatabaseContext;

namespace Wpf.Windows
{
    /// <summary>
    /// Interaction logic for GameListWindow.xaml
    /// </summary>
    public partial class GameListWindow : Window
    {
        public GameListWindow()
        {
            InitializeComponent();
        }

        private void Btn_ApproveClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            string nameEntity = Name_txtBlox.Text;
            string descEntity = Desc_txtBlox.Text;
            int costEntity = int.Parse(Cost_txtBlox.Text);
            int rateEntity = random.Next(1, 5);
            int catEntity = int.Parse(Cat_txtBlox.Text);
            int compEntity = int.Parse(Comp_txtBlox.Text);
            int platEntity = int.Parse(Planf_txtBlox.Text);

            var entity = new Game
            {
                Name = nameEntity,
                Description = descEntity,
                Cost = costEntity,
                Rate = rateEntity,
                CategoryId = catEntity,
                CompanyId= compEntity,
                PlatformId = platEntity,
                
            };

            using (var cx = new SteamDb())
            {
                cx.Game.Add(entity);
                cx.SaveChanges();

                MessageBox.Show("Apply");
            }
        }
        
    }
}
