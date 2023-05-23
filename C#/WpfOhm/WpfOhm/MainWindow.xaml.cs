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

namespace WpfOhm
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

        private void btnBerechnen_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (txtInputSpannung.Text == "")
                {
                    txtInputSpannung.Text = "0";
                }
                else if (txtInputStrom.Text == "")
                {
                    txtInputStrom.Text = "0";
                }
                else
                {
                    txtInputWiderstand.Text = "0";
                }
                double Spannung = double.Parse(txtInputSpannung.Text);
                double Widerstand = double.Parse(txtInputWiderstand.Text);
                double Strom = double.Parse(txtInputStrom.Text);
                if (Spannung == 0)
                {
                    Spannung = Widerstand * Strom;
                    txtInputSpannung.Text = Spannung.ToString();
                }
                else if (Widerstand == 0)
                {
                    Widerstand = Spannung / Strom;
                    txtInputWiderstand.Text = Widerstand.ToString();
                }
                else
                {
                    Strom = Spannung / Widerstand;
                    txtInputStrom.Text = Strom.ToString();
                }


            } catch (Exception ex) {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte überprüfen Sie Ihre Eingabe.");
            }
        }
    }
}
