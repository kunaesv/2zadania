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

namespace _2zadania
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            // Задание 1

            int a, b;
            if (!int.TryParse(TbNumberA.Text, out a) || !int.TryParse(TbNumberB.Text, out b) || a >= b)
            {
                TextBlockAnswer.Text = "Введите два натуральных числа a и b, при этом a должно быть меньше b!";
                return;
            }

            string result = "";
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz\n";
                }
                else if (i % 3 == 0)
                {
                    result += "Fizz\n";
                }
                else if (i % 5 == 0)
                {
                    result += "Buzz\n";
                }
                else
                {
                    result += $"{i}\n";
                }
            }

            TextBlockAnswer.Text = result;
           

        }
    }
}
