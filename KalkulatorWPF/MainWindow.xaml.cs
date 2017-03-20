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

namespace KalkulatorWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void NumberButton_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                    {
                        zeroButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad1:
                    {
                        oneButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad2:
                    {
                        twoButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad3:
                    {
                        threeButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad4:
                    {
                        fourButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad5:
                    {
                        fiveButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad6:
                    {
                        sixButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad7:
                    {
                        sevenButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad8:
                    {
                        eightButton_Click(sender, e);
                        break;
                    }
                case Key.NumPad9:
                    {
                        nineButton_Click(sender, e);
                        break;
                    }
                case Key.Decimal:
                    {
                        commaButton_Click(sender, e);
                        break;
                    }
            }
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "" || Display.Text.Contains(',') || !String.IsNullOrEmpty(Display.Text) && Display.Text[0] != '0')
            {
                Display.Text += "0";
                number = double.Parse(Display.Text);

            }
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
            number = double.Parse(Display.Text);
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
            number = double.Parse(Display.Text);
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
            number = double.Parse(Display.Text);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
            number = double.Parse(Display.Text);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
            number = double.Parse(Display.Text);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
            number = double.Parse(Display.Text);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
            number = double.Parse(Display.Text);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
            number = double.Parse(Display.Text);
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
            number = double.Parse(Display.Text);
        }

        private void clearButon_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            number = 0;
        }

        private void commaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Display.Text.Contains(','))
                Display.Text += ",";
        }
    }
}
