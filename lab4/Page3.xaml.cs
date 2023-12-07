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

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            int n = int.Parse(BB.Text);
            double a, R1, R2, S;
            switch (n)
            {
                case 1:
                    {
                        a = x;
                        R1 = x * Math.Sqrt(3) / 4;
                        R2 = R1 * 2;
                        S = a * a * Math.Sqrt(3) / 4;
                        MessageBox.Show($" R1 ={R1} R2={R2} S={S}", "ответ");
                        break;
                    }
                case 2:
                    {
                        R1 = x;
                        a = R1 * 4 / Math.Sqrt(3);
                        R2 = 2 * R1;
                        S = a * a * Math.Sqrt(3) / 4;
                        MessageBox.Show($" S ={S} R2={R2} a={a}", "ответ");
                        break;
                    }
                case 3:
                    {
                        R2 = x;
                        R1 = R2 / 2;
                        a = R1 * 4 / Math.Sqrt(3);
                        S = a * a * Math.Sqrt(3) / 4;
                        MessageBox.Show($" R1 ={R1} S={S} a={a}", "ответ");
                        break;
                    }
                case 4:
                    {
                        S = x;
                        a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                        R1 = a * Math.Sqrt(3) / 4;
                        R2 = 2 * R1;
                        MessageBox.Show($" R1 ={R1} R2={R2} a={a}", "ответ");
                        break;
                    }
            }
        }
    }
}
