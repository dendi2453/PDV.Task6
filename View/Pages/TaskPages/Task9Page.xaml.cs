﻿using PDV.Task6.Core;
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

namespace PDV.Task6.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }
        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}
