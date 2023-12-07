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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(AA.Text);
            int M = int.Parse(BB.Text);
            string s = "";
            switch (N)
            {
                case 6: s += "шестерка"; break;
                case 7: s += "семерка"; break;
                case 8: s += "восьмерка"; break;
                case 9: s += "девятка"; break;
                case 10: s += "десятка"; break;
                case 11: s += "велет"; break;
                case 12: s += "дама"; break;
                case 13: s += "король"; break;
                case 14: s += "туз"; break;
            }
            switch (M)
            {
                case 1: s += " пики"; break;
                case 2: s += " треф"; break;
                case 3: s += " бубн"; break;
                case 4: s += " черв"; break;
            }
            MessageBox.Show(s);
        }
    }
}
