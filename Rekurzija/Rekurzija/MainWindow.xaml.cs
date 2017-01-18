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

namespace Rekurzija
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

        private void Pomnozi_Click(object sender, RoutedEventArgs e)
        {
            double Pomnozi(double broj1, double broj2)
            {
                if ((broj1 == 0) || (broj2 == 0))
                    return 0;

                if (broj2 == 1)
                    return broj1;
                else
                    return broj1 + Pomnozi(broj1, broj2 - 1);
            }

            try
            {
                double broj1 = Convert.ToDouble(txtBox1.Text);
                double broj2 = Convert.ToDouble(txtBox2.Text);

                double rezultat = Pomnozi(broj1, broj2);

                txtBox3.Text = Convert.ToString(rezultat);
            }
            catch
            {
                MessageBox.Show($"Molim unesite brojeve!");
            }
        }
    }
}
