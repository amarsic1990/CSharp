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

namespace PrimTipPod
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

        private void tipovi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem odabraniTip = (tipovi.SelectedItem as ListBoxItem);

            switch (odabraniTip.Content.ToString())
            {
                case "int":
                    pokaziInt();
                    break;

                case "long":
                    pokaziLong();
                    break;

                case "float":
                    pokaziFloat();
                    break;

                case "double":
                    pokaziDouble();
                    break;

                case "decimal":
                    pokaziDecimalu();
                    break;

                case "string":
                    pokaziString();
                    break;

                case "char":
                    pokaziChar();
                    break;

                case "bool":
                    pokaziBool();
                    break;

            }
        }

        private void pokaziInt()
        {
            int intVar = 4321;
            rezultat.Text = intVar.ToString();
        }

        private void pokaziLong()
        {
            long longVar = 435125L;
            rezultat.Text = longVar.ToString();
        }
        private void pokaziFloat()
        {
            float floatVar = 0.457F;
            rezultat.Text = floatVar.ToString();
        }
        private void pokaziDouble()
        {
            double doubleVar = 0.58936;
            rezultat.Text = doubleVar.ToString();
        }
        private void pokaziDecimalu()
        {
            decimal decVar = 0.12M;
            rezultat.Text = decVar.ToString();
        }
        private void pokaziString()
        {
            string stringVar = "samo pomalo :D";
            rezultat.Text = stringVar;
        }
        private void pokaziChar()
        {
            char charVar = 'X';
            rezultat.Text = charVar.ToString();
        }
        private void pokaziBool()
        {
            bool boolVar = true;
            rezultat.Text = boolVar.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
