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

namespace Events
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!";
            Button novoDugme = new Button();
            novoDugme.Content = "novi Button!";
            novoDugme.Margin = new Thickness(10, 10, 200, 200);
            novoDugme.Click += NovoDugme_Click;
            ((Grid)((Button)sender).Parent).Children.Add(novoDugme);
        }

        private void NovoDugme_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "Clicked!!";
        }
    }
}
