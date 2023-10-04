using MVVMMakeSelf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMMakeSelf.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
		private ProductRepo productRepo = new ProductRepo();
		public ObservableCollection<ProductViewModel> ProductsVM { get; set; } = new ();


        //private ProductViewModel productViewModel;
        //public ProductViewModel SelectedProductVM
        //{
        //    get { return productViewModel; }
        //    set
        //    {
        //        productViewModel = value;
        //        OnPropertyChanged("SelectedPersonVM");
        //    }
        //}

        public event PropertyChangedEventHandler? PropertyChanged;

		public MainViewModel()
		{
			foreach (Product p in productRepo.GetAll()) 
			{
				ProductViewModel productVM = new(p);
				ProductsVM.Add(productVM);
			}
		}
        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
        //    if (propertyChanged != null)
        //    {
        //        propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
