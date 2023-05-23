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

namespace WpfZahlenreihe
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
                double numberOne = Convert.ToDouble(txtNumberOne.Text);
                double numberTwo = Convert.ToDouble(txtNumberTwo.Text);
                double counter = 0;
                while (numberOne <= numberTwo)
                {
                    counter += numberOne;
                    numberOne++;
                }
                lblResult.Visibility = Visibility.Visible;
                lblResult.Content = counter.ToString();
            } catch {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte überprüfen Sie die Eingaben.");
            }

        }
    }
}
