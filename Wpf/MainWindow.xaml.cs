﻿using System;
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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        private void ComboBox_Clicked(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("spitgw");
        }
    }
}