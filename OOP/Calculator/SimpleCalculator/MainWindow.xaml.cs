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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Board.Focus();
            Board.SelectAll();
        }

        private void CalculateOperation(string op)
        {
            switch (op)
            {
                case "+":
                    total = total + a;
                    break;
                case "-":
                    total = total - a;
                    break;
                case "*":
                    total = total * a;
                    break;
                case "/":
                    total = total / a;
                    break;
                default:
                    break;
            }  
        }

        private double total = 0;
        private double a = 0;
        private string oper = "+";

        private void GetValue()
        {
            if (double.TryParse(Board.Text, out a)) Board.Text = "0";
        }

        private void AddSymbol(string s)
        {            
            Board.Text = (Board.Text == "0") ? s: Board.Text + s;
        }

        private void ButtonOperation(string o)
        {
            GetValue();
            CalculateOperation(oper);
            a = 0;
            oper = o;
            Board.Focus();
            if (o != "") Board.SelectAll();
        }
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonOperation("+");
        }

        private void EqualButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonOperation("");
            Board.Text = $"{total}";
        }

        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonOperation("-");
        }

        private void MultButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonOperation("*");
        }

        private void DivButtonClick(object sender, RoutedEventArgs e)
        {
            ButtonOperation("/");
        }

        private void MakeDefault(object sender, RoutedEventArgs e)
        {
            Board.Focus();
            Board.Text = "0";
            Board.SelectAll();
        }

        private void RestartCalculator(object sender, RoutedEventArgs e)
        {
            MakeDefault(sender, e);
            total = 0;
            a = 0;
            oper = "+";
        }

        private void DelLast_Click(object sender, RoutedEventArgs e)
        {
            Board.Text = Board.Text.Substring(0, Board.Text.Length - 1);
            if (Board.Text == "") Board.Text = "0";
            Board.Focus();
        }

        private void Add9(object sender, RoutedEventArgs e)
        {
            AddSymbol("9");
        }

        private void Add8(object sender, RoutedEventArgs e)
        {
            AddSymbol("8");
        }

        private void Add7(object sender, RoutedEventArgs e)
        {
            AddSymbol("7");
        }

        private void Add6(object sender, RoutedEventArgs e)
        {
            AddSymbol("6");
        }

        private void Add5(object sender, RoutedEventArgs e)
        {
            AddSymbol("5");
        }

        private void Add4(object sender, RoutedEventArgs e)
        {
            AddSymbol("4");
        }

        private void Add3(object sender, RoutedEventArgs e)
        {
            AddSymbol("3");
        }

        private void Add2(object sender, RoutedEventArgs e)
        {
            AddSymbol("2");
        }

        private void Add1(object sender, RoutedEventArgs e)
        {
            AddSymbol("1");
        }

        private void Add0(object sender, RoutedEventArgs e)
        {
            AddSymbol("0");
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!Board.Text.Contains(".")) Board.Text += ".";
        }

        private void SignReverse_Click(object sender, RoutedEventArgs e)
        {
            Board.Text = (Board.Text[0] == '-') ? Board.Text.Substring(1) : "-" + Board.Text;
            if (Board.Text == "-0") Board.Text = "0";
        }

        private void CheckedTextInput(object sender, RoutedEventArgs e)
        {            
            if (Board.Text.Length > 0 &&
                !(Char.IsDigit(Board.Text[Board.Text.Length - 1]) ||
                (Board.Text[Board.Text.Length - 1] == '.') && Board.Text.IndexOf('.') == Board.Text.Length -1))
            {
                Board.Text = Board.Text.Substring(0, Board.Text.Length - 1);
                Board.Select(Board.Text.Length, 0);
            }

            if (Board.Text == ".")
            {
                Board.Text = "0.";
                Board.Select(Board.Text.Length, 0);
            }

            if (Board.Text.Length > 1 && Board.Text[0] == '0' && !Board.Text.Contains("."))
            {
                Board.Text = Board.Text.Substring(1, Board.Text.Length - 1);
                Board.Select(Board.Text.Length, 0);
            }

            if (Board.Text == "")
            {
                Board.Text = "0";
                Board.SelectAll();
            }
        }
    }
}
