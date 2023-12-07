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
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(AA.Text);
            string S = "";
            string K = "";
            string I = "";

            if (N >= 100 && N <= 999)
            {
                switch (N / 100)
                {
                    case 1:I = "Сто";break;
                        
                        
                    case 2:I = "Двести"; break;
                        
                       
                    case 3:I = "Тристо";break;
                        
                        
                    case 4:
                        I = "Четыресто";
                        break;
                    case 5:
                        I = "Пятсот";
                        break;
                    case 6:
                        I = "Шестьсот";
                        break;
                    case 7:
                        I = "Семьсот";
                        break;
                    case 8:
                        I = "Восемьсот";
                        break;
                    case 9:
                        I = "Девятсот";
                        break;
                }
                if (N % 100 / 10 == 1)
                {
                    switch (N % 100)
                    {
                        case 10: K = "десять"; break;
                        case 11: K = "одинадцать"; break;
                        case 12: K = "двенадцать"; break;
                        case 13: K = "тринадцать"; break;
                        case 14: K = "четырнадцать"; break;
                        case 15: K = "пятнадцать"; break;
                        case 16: K = "шестнадцать"; break;
                        case 17: K = "семнадцать"; break;
                        case 18: K = "восемнадцать"; break;
                        case 19: K = "девятнадцать"; break;
                    }
                }
                else
                {


                    switch (N % 100 / 10)
                    {
                        case 1:
                            K = "десять";
                            break;
                        case 2:
                            K = "двадцать";
                            break;
                        case 3:
                            K = "тридцать";
                            break;
                        case 4:
                            K = "сорок";
                            break;
                        case 5:
                            K = "пятьдесят";
                            break;
                        case 6:
                            K = "шестьдесят";
                            break;
                        case 7:
                            K = "семьдесят";
                            break;
                        case 8:
                            K = "восемьдесят";
                            break;
                        case 9:
                            K = "девяносто";
                            break;
                    }
                    switch (N % 10)
                    {
                        case 1:
                            S = "один";
                            break;
                        case 2:
                            S = "два";
                            break;
                        case 3:
                            S = "три";
                            break;
                        case 4:
                            S = "четыре";
                            break;
                        case 5:
                            S = "пять";
                            break;
                        case 6:
                            S = "шесть";
                            break;
                        case 7:
                            S = "семь";
                            break;
                        case 8:
                            S = "восемь";
                            break;
                        case 9:
                            S = "девять";
                            break;
                    }
                }
                MessageBox.Show($"Заданное число- {I} {K} {S}", "Ошибка: ");
            }
            else
            {
                MessageBox.Show($"Введите корректное значение Х от 100 до 999", "Ошибка: ");
            }

        }
    }
}
