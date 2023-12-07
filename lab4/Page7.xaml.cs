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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(AA.Text);
            int k = N % 10;
            string i = "";
            string S = "";
            string p = "";
            if (N >= 10 && N <= 40)
            {
                if ((N == 21) || (N == 31))
                {
                    p = "учебное здание";
                }
                else if (N >= 11 && N <= 19)
                {
                    p = "учебных зданий";
                }
                else
                {
                    p = "учебных здания";
                }
                if (N >= 21 && N < 30)
                {
                    S = "двадцать";
                }
                else if (N >= 30 && N <= 39)
                {
                    S = "тридцать";
                }
                switch (N)
                {
                    case 11: S = "Одинадцать"; break;
                    case 12: S = "Двенадцать"; break;
                    case 13: S = "Тринадцать"; break;
                    case 14: S = "Четырнадцать"; break;
                    case 15: S = "Пятнадцать"; break;
                    case 16: S = "Шестнадцать"; break;
                    case 17: S = "Семнадцать"; break;
                    case 18: S = "Восемнадцать"; break;
                    case 19: S = "Девятнадцать"; break;
                    case 10: S = "Десять"; break;
                    case 20: S = "Двадцать"; break;
                    case 30: S = "Трицать"; break;
                    case 40: S = "Сорок"; break;
                }
                switch (k)
                {
                    case 1: i = "одно"; break;
                    case 2: i = "два"; break;
                    case 3: i = "три"; break;
                    case 4: i = "четыре"; break;
                    case 5: i = "пять"; break;
                    case 6: i = "шесть"; break;
                    case 7: i = "семь"; break;
                    case 8: i = "восемь"; break;
                    case 9: i = "девять"; break;
                }
                if ((N >= 10 && N <= 20) || (N == 30) || (N == 40))

                {
                    MessageBox.Show($"{S} {p}", "Ответ: ");
                }
                else
                {
                    MessageBox.Show($"{S} {i} {p}", "Ответ: ");
                }
            }
            else
            {
                MessageBox.Show($"Введите корректное значение Х от 10 до 40", "Ошибка: ");
            }

        }
    }
}