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

namespace WpfBubblesort
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
        Boolean check = true;
        string result = "";
        private void rdbtnBubbelsortAufst_Checked(object sender, RoutedEventArgs e)
        {
            //lblBubblesortResult.Content = "";
            //result = "";
            try
            {
                List<int> numbers = new List<int>();
                string inputnumbers = txtBubblesortInput.Text;
                foreach (var s in inputnumbers.Split(','))
                {
                    int number = Convert.ToInt32(s);
                    numbers.Add(number);
                }

                Boolean check = false;
                while (check != true)
                {
                    check = true;
                    for (int position = 0; position < numbers.Count - 1;)
                    {


                        if (numbers[position] <= numbers[position + 1])
                        {
                            position++;

                        }
                        else
                        {
                            int tmp = numbers[position];
                            numbers[position] = numbers[position + 1];
                            numbers[position + 1] = tmp;
                            position++;
                            check = false;
                        }
                    }
                }
                result = string.Join(",", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten. Bitte überprüf deine Eingabe.");
            }

        }

        private void rdbtnBubbelsortAbst_Checked(object sender, RoutedEventArgs e)
        {
            //lblBubblesortResult.Content = "";
            //result = "";
            try
            {
                List<int> numbers = new List<int>();
                string inputnumbers = txtBubblesortInput.Text;
                foreach (var s in inputnumbers.Split(','))
                {
                    int number = Convert.ToInt32(s);
                    numbers.Add(number);
                }

                Boolean check = false;
                while (check != true)
                {
                    check = true;
                    for (int position = 0; position < numbers.Count - 1;)
                    {


                        if (numbers[position] >= numbers[position + 1])
                        {
                            position++;

                        }
                        else
                        {
                            int tmp = numbers[position];
                            numbers[position] = numbers[position + 1];
                            numbers[position + 1] = tmp;
                            position++;
                            check = false;
                        }
                    }
                }
                result = string.Join(",", numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten. Bitte überprüf deine Eingabe.");
            }

        }

        private void btnBubblesortSortieren_Click(object sender, RoutedEventArgs e)
        {
            /*string inputnumbers = txtBubblesortInput.Text;
            foreach(var s in inputnumbers.Split(','))
            {
               int number = Convert.ToInt32(s);
                numbers.Add(number);
            }*/
            lblBubblesortResult.Content = result;
            lblBubblesortResult.Visibility = Visibility.Visible;

        }

    }
}
