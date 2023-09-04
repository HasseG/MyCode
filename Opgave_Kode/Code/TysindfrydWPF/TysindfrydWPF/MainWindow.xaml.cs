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

namespace TysindfrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int MyProperty { get; set; }
        public string all;
        FlowerSort flowerSort;
        List<FlowerSort> flowerSorts; 
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
            flowerSort = new FlowerSort();

        }

        private void BT_OBL_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            if (createFlowerSortDialog.ShowDialog() == true)
            {
                flowerSort.Name = createFlowerSortDialog.inName;
                flowerSort.PictureName = createFlowerSortDialog.inPicName;
                flowerSort.HalfLifeTime  = int.Parse(createFlowerSortDialog.inHalfTid);
                flowerSort.ProductionTime = int.Parse(createFlowerSortDialog.inProdTid);
                flowerSort.Size = int.Parse(createFlowerSortDialog.inSize);
                flowerSorts.Add(flowerSort);
                TBL_Blomstersort.Text = null;

            }

            foreach (FlowerSort flowerSort in flowerSorts)
            {
                all = all + flowerSort.ToString(); 
            }
            TBL_Blomstersort.Text += all;
    }
    }
}
