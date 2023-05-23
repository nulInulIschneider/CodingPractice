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

namespace WpfVerschlüsselung
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

        List<int> nichtDruckbar = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,127,129,141,143,144,157
        };
     


        private void btnVerschlüsseln_Click(object sender, RoutedEventArgs e)
        {
            int key = Convert.ToInt16(txtKey.Text);
            char[] cInput = txtInput.Text.ToCharArray();
            int[] wInput = new int[cInput.Length];

            for (int i = 0; i < cInput.Length; i++) {
                wInput[i] = (int)cInput[i];
            }

            for (int s = 0; s < key % 256;s++)
            {
                for (int i = 0;i < wInput.Length;i++)
                {
                    wInput[i] = wInput[i] + 1;
                    while (nichtDruckbar.Contains(wInput[i])) {
                        wInput[i] = wInput[i] + 1;
                    }
                }
            }
            /*for (int i = 0;i < wInput.Length; i++)
            {
                if (wInput[i] + key > 255)
                {
                    wInput[i] = (wInput[i] + key % 255) + 31;
                }
                else
                {
                    wInput[i] = wInput[i] + key;
                }
            }*/

            for (int i = 0; i<wInput.Length; i++)
            {
                cInput[i] = (char)wInput[i];
            }
            txtOutput.Text = String.Join("", cInput);
        }

        private void btnEntschlüsseln_Click(object sender, RoutedEventArgs e)
        {
            int key = Convert.ToInt16(txtKey.Text);
            char[] cInput = txtInput.Text.ToCharArray();
            int[] wInput = new int[cInput.Length];

            for (int i = 0; i < cInput.Length; i++)
            {
                wInput[i] = (int)cInput[i];
            }

            /*for (int i = 0; i < wInput.Length; i++)
            {
                if (wInput[i] - key < 32)
                {
                    wInput[i] = 255 - (31 - (wInput[i] - key));
                }
                else
                {
                    wInput[i] = wInput[i] - key;
                }
            }*/

            for (int s = 0; s < key % 256; s++)
            {
                for (int i = 0; i < wInput.Length; i++)
                {
                    wInput[i] = wInput[i] + 1;
                    while (nichtDruckbar.Contains(wInput[i]))
                    {
                        wInput[i] = wInput[i] + 1;
                    }
                }
            }


            for (int i = 0; i < wInput.Length; i++)
            {
                cInput[i] = (char)wInput[i];
            }
            txtOutput.Text = String.Join("", cInput);

        }
    }
}
