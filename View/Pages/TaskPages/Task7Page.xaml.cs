using PDV.Task6.Core;
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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2;
        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            int A = Convert.ToInt32(TbA.Text);
            int B = Convert.ToInt32(TbB.Text);
            int k = Convert.ToInt32(TbK.Text);
            int[,] mas = new int[A, B];
            int t1 = 0, t2 = 0;
            Random rnd = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    {
                        if (mas[i, j] == k)
                        {
                            t1 = i;
                            t2 = j;
                        }
                    }
                }
            }
        }

        private void BtnTask7_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}
