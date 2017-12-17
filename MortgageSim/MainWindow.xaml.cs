using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MortgageSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////// Income and expanses 

        private void textBoxMonthlyIncome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxMonthlyIncome.Text == "" && textBoxMonthlyExpenses.Text == "")
            {
                labelMonthlySavings.Content = 0;
            }
            else if (textBoxMonthlyExpenses.Text == "")
            {
                labelMonthlySavings.Content = textBoxMonthlyIncome.Text;
            }
            else if (textBoxMonthlyIncome.Text == "")
            {
                int income = 0;
                int expenses = int.Parse(textBoxMonthlyExpenses.Text);
                labelMonthlySavings.Content = income - expenses;
            }
            else
            {
                int income = int.Parse(textBoxMonthlyIncome.Text);
                int expenses = int.Parse(textBoxMonthlyExpenses.Text); 
                labelMonthlySavings.Content = income - expenses;
            }
        }

        private void textBoxMonthlyExpenses_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBoxMonthlyIncome.Text == "" && textBoxMonthlyExpenses.Text == "")
            {
                labelMonthlySavings.Content = 0;
            }
            else if (textBoxMonthlyExpenses.Text == "")
            {
                labelMonthlySavings.Content = textBoxMonthlyIncome.Text;
            }
            else if (textBoxMonthlyIncome.Text == "")
            {
                labelMonthlySavings.Content = 0;
            }
            else
            {
                int income = int.Parse(textBoxMonthlyIncome.Text);
                int expenses = int.Parse(textBoxMonthlyExpenses.Text);
                labelMonthlySavings.Content = income - expenses;
            }
        }

        private void textBoxMonthlyIncome_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void textBoxMonthlyExpenses_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }
        ///////////////////////////////////////////////////////////////////// Income and expanses  



        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
