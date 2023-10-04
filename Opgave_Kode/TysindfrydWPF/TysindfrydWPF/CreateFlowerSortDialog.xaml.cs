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
using System.Windows.Shapes;

namespace TysindfrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        public string inName;
        public string inPicName;
        public string inProdTid;
        public string inHalfTid;
        public string inSize;
         
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }

        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            
           inName = TBO_Name.Text;
           inPicName = TBO_Pic.Text;
           inProdTid = TBO_ProdTid.Text;
           inHalfTid = TBO_HalvTId.Text;
           inSize = TBO_St.Text;
           DialogResult = true;
        }

        private void BT_FO_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TBO_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBO_Pic_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBO_ProdTid_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBO_HalvTId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TBO_St_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
