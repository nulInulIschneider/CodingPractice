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

namespace WpfQuersummen
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

        int counterDurchgang = 1;
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            int counterQuersumme = 0;
            //int counterDurchgang = 1;

            int[] quersumme = txtInput.Text.Select(x => int.Parse(x.ToString())).ToArray();
            if (quersumme.Length > 1 )
            {
                for (int i = 0; i < quersumme.Length; i++)
                {
                    counterQuersumme += quersumme[i];
                }
                //txtblResultList.Text = txtblResultList.Text + "/n" + "Quersumme " + counterDurchgang.ToString() + ": " + counterQuersumme.ToString();
                txtblResultList.Inlines.Add("Quersumme " + counterDurchgang.ToString() + ": " + counterQuersumme.ToString() + System.Environment.NewLine);
                counterDurchgang++;
                txtInput.Text = counterQuersumme.ToString();
            }
            else
            {
                //txtblResultList.Text = txtblResultList.Text + "/n" + "Fertig!";
                txtblResultList.Inlines.Add("Fertig!");
                btnResult.Visibility = Visibility.Collapsed;
                btnAgain.Visibility = Visibility.Visible;
            }
        }

        private void btnAgain_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
            txtblResultList.Text = "";
            counterDurchgang = 1;
            btnAgain.Visibility = Visibility.Collapsed;
            btnResult.Visibility = Visibility.Visible;
        }
    }
}
