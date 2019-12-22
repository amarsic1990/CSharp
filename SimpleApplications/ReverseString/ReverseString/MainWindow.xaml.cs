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

namespace ReverseString
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string tekst = UneseniTekst.Text;
            string tekstIspis = null;

            if (tekst.Length < 2)
            {
                MessageBox.Show("u polje morate unijeti najmanje 2 slova/broja!");
            }
            else
            {
                for(int i = tekst.Length-1; i >= 0; i--)
                {
                    tekstIspis += tekst[i];
                }
                TextBoxIspis.Text = tekstIspis;
            }
        }
    }
}
