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
        private double numberone, numbertwo, result;
        public MainWindow()
        {
            InitializeComponent();
            ButtonsControl();
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
            }
            ButtonsControl();
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
            ButtonsControl();
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";
            ButtonsControl();
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
            ButtonsControl();
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
            ButtonsControl();
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
            ButtonsControl();
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
            ButtonsControl();
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        { 
            Display.Text += "7";
            ButtonsControl();
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
            ButtonsControl();
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
            ButtonsControl();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            firstnum.Text = "";
            secondnum.Text = "";
            operation.Text = "";
            numberone = 0;
            numbertwo = 0;
        }

        private void commaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Display.Text.Contains(','))
                Display.Text += ",";
        }

        private void FunctionButton_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Add:
                    {
                        addButton_Click(sender, e);
                        break;
                    }
                case Key.Subtract:
                    {
                        subtractionButton_Click(sender, e);
                        break;
                    }
                case Key.Multiply:
                    {
                        multiplyButton_Click(sender, e);
                        break;
                    }
                case Key.Divide:
                    {
                        divisonButton_Click(sender, e);
                        break;
                    }
                case Key.Back:
                    {
                        clearButton_Click(sender, e);
                        break;
                    }
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            numberone = double.Parse(Display.Text);
            firstnum.Text = Display.Text;
            operation.Text = "+";
            Display.Text = "";
        }

        private void subtractionButton_Click(object sender, RoutedEventArgs e)
        {
            numberone = double.Parse(Display.Text);
            firstnum.Text = numberone.ToString();
            operation.Text = "-";
            Display.Text = "";
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            numberone = double.Parse(Display.Text);
            firstnum.Text = numberone.ToString();
            operation.Text = "*";
            Display.Text = "";
        }

        private void divisonButton_Click(object sender, RoutedEventArgs e)
        {
            numberone = double.Parse(Display.Text);
            firstnum.Text = numberone.ToString();
            operation.Text = "/";
            Display.Text = "";
        }

        private void exponentiationButton_Click(object sender, RoutedEventArgs e)
        {
            numberone = double.Parse(Display.Text);
            firstnum.Text = numberone.ToString();
            operation.Text = "^";
            Display.Text = "";
        }

        private void reciprocalButton_Click(object sender, RoutedEventArgs e)
        {
            firstnum.Text = "1";
            operation.Text = "/";
            numberone = double.Parse(Display.Text);
            secondnum.Text = numberone.ToString();
            numberone = 1 / numberone;
            Display.Text = numberone.ToString();
        }

        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            numbertwo = double.Parse(Display.Text);
            secondnum.Text = numbertwo.ToString();
            switch (operation.Text)
            {
                case "+":
                    {
                        result = numberone + numbertwo;
                        break;
                    }
                case "-":
                    {
                        result = numberone - numbertwo;
                        break;
                    }
                case "*":
                    {
                        result = numberone * numbertwo;
                        break;
                    }
                case "/":
                    {
                        result = numberone / numbertwo;
                        break;
                    }
                case "^":
                    {
                        result = Math.Pow(numberone, numbertwo);
                        break;
                    }                   
            }
            Display.Text = result.ToString();
        }
        private void ButtonsControl()
        {
            if (Display.Text == "")
            {
                addButton.IsEnabled = false;
                subtractionButton.IsEnabled = false;
                multiplyButton.IsEnabled = false;
                divisonButton.IsEnabled = false;
                exponentiationButton.IsEnabled = false;
                reciprocalButton.IsEnabled = false;
                resultButton.IsEnabled = false;
            }
            else
            {
                addButton.IsEnabled = true;
                subtractionButton.IsEnabled = true;
                multiplyButton.IsEnabled = true;
                divisonButton.IsEnabled = true;
                exponentiationButton.IsEnabled = true;
                reciprocalButton.IsEnabled = true;
                resultButton.IsEnabled = true;
            }
        }
    }
}
