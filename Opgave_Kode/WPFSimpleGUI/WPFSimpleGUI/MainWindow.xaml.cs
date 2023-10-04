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

namespace WPFSimpleGUI
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


        private void Textbox_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tekstbox_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tekstbox_3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tekstbox_4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string temp1, temp2, temp3, temp4;
            temp1 = Tekstbox_1.Text;
            temp2 = Tekstbox_2.Text;
            temp3 = Tekstbox_3.Text;
            temp4 = Tekstbox_4.Text;

            Tekstbox_1.Text = temp2;
            Tekstbox_2.Text = temp3;
            Tekstbox_3.Text = temp4;
            Tekstbox_4.Text = temp1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tekstbox_1.Text = string.Empty; 
            Tekstbox_2.Text = string.Empty;
            Tekstbox_3.Text = string.Empty;
            Tekstbox_4.Text = string.Empty;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string temp1, temp2, temp3, temp4;
            temp1 = Tekstbox_1.Text;
            temp2 = Tekstbox_2.Text;
            temp3 = Tekstbox_3.Text;
            temp4 = Tekstbox_4.Text;

            Tekstbox_1.Text = temp4;
            Tekstbox_2.Text = temp1;
            Tekstbox_3.Text = temp2;
            Tekstbox_4.Text = temp3;
        }
    }
}
