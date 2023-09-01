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

namespace Wpf.Windows
{
    /// <summary>
    /// Interaction logic for GameListWindow.xaml
    /// </summary>
    public partial class GameListWindow : Window
    {
        string connStr = null;
        public GameListWindow()
        {
            InitializeComponent();
            
        }

        private void Btn_ApproveClick(object sender, RoutedEventArgs e)
        {
            Create();
        }
        public void Create()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                var cmdText = "INSERT INTO Game (Name, Description, Cost) VALUES(@Name, @Description, @Cost)";
                SqlCommand command = new SqlCommand(cmdText, conn);

                command.Parameters.Add("@Name", SqlDbType.NVarChar);
                command.Parameters.Add("@Description", SqlDbType.NVarChar);
                command.Parameters.Add("@Cost", SqlDbType.Decimal);

               
            }
        }
    }
}
