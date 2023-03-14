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
    /// Логика взаимодействия для Task8Page.xaml
    /// </summary>
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }
        public int Constant1, Constant2, Constant3, Constant4, Constant5, Constant6, Constant7, Constant8, Constant9;
        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            int[,] A = new int[3, 3];
            int minRowSum = int.MaxValue, indexMinRow = 0;
            Random rnd = new Random();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(0, 100);
                    rowSum += A[i, j];
                    if (rowSum < minRowSum)
                    {
                        minRowSum = rowSum;
                        indexMinRow = i;
                    }
                    A[i, j] *= rowSum;
                }
            }
        }
        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}
