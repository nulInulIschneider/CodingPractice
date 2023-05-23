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

namespace WpfSummeUndQuersumme
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
            char[] cZeichen = txtInput.Text.ToCharArray();
            int counter = 0;
            int counterQuer = 0;
            for (int i = 0; i < cZeichen.Length; i++)
            {
                counter += (int)cZeichen[i];
            }
            lblSumme.Visibility = Visibility.Visible;
            lblSumme.Content = "Summe: " + counter.ToString();

            int[] quersumme = counter.ToString().Select(o => int.Parse(o.ToString())).ToArray();
            for (int i = 0;i < quersumme.Length;i++)
            {
                counterQuer += quersumme[i];
            }
            lblQuersumme.Visibility = Visibility.Visible;
            lblQuersumme.Content = "Quersumme: " + counterQuer.ToString();
        }
    }
}
