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

namespace kalkulator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Izrac_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)zbrajanje.IsChecked)
                {
                    Zbroji();
                }
                else if ((bool)oduzimanje.IsChecked)
                {
                    Oduzmi();
                }
                else if ((bool)mnozenje.IsChecked)
                {
                    Mnozenje();

                }
                else if ((bool)djeljenje.IsChecked)
                {
                    Djeljenje();
                }
                else if ((bool)ostatak.IsChecked)
                {
                    Ostatak();
                }
            }


            catch (Exception xxx)
            {
                MessageBox.Show(xxx.Message);
            }
        }

        public void Zbroji()
        {
            double lo = Convert.ToDouble(LiviOp.Text);
            double dop = Convert.ToDouble(DesniOp.Text);

            double rez = lo + dop;
            rezTextBox.Text = rez.ToString();
        }
        public void Oduzmi()
        {
            double rez  = Convert.ToDouble(LiviOp.Text) - Convert.ToDouble(DesniOp.Text);
            rezTextBox.Text = rez.ToString();
        }
        public void Mnozenje()
        {
            double rez = Convert.ToDouble(LiviOp.Text) * Convert.ToDouble(DesniOp.Text);
            rezTextBox.Text = rez.ToString();
        }
        public void Djeljenje()
        {
            double rez = double.Parse(LiviOp.Text) / double.Parse(DesniOp.Text);
            rezTextBox.Text = rez.ToString();
        }

        public void Ostatak()
        {
            double rez = double.Parse(LiviOp.Text) % double.Parse(DesniOp.Text);
            rezTextBox.Text = rez.ToString();
        }

    }
}

