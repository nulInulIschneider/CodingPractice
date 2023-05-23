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

namespace WpfGeradeUngerade
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

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(txtZahl.Text);
                lblResult.Visibility = Visibility.Visible;
                if (number % 2 == 0)
                {
                    lblResult.Content = number + " ist eine gerade Zahl.";
                }
                else
                {
                    lblResult.Content = number + " ist eine ungerade Zahl.";
                }
            } catch {
                MessageBox.Show("Es ist ein Fehler aufgetreten! Bitte überprüfen Sie die Eingabe.");
            }
        }
    }
}
