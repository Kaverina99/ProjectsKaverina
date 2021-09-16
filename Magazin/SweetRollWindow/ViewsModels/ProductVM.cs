using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BLL.Models;

namespace SweetRollWindow.ViewsModels
{
    public class ProductVM : INotifyPropertyChanged
    {
        
        private ProduktModel selectedProduct;
        
        public ObservableCollection<ProduktModel> Products { get; set; }
        public ProduktModel SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      ProduktModel product = new ProduktModel();
                      
                      ProductWindow pw = new ProductWindow(product);
                      bool? res = pw.ShowDialog();
                      if (res != null && (bool)res)
                      {
                          Products.Insert(0, product);
                          selectedProduct = product;
                      }
                  }));
            }
        }
        // команда удаления
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      ProduktModel product = obj as ProduktModel;
                      if (product != null)
                      {
                          Products.Remove(product);
                      }
                  },
                 //условие, при котором будет доступна команда
                 (obj) => (Products.Count > 0 && selectedProduct != null)));
            }
        }


        public ProductVM()
        {
            DBDataOperation ClassWorkDB = new DBDataOperation();
            Products = new ObservableCollection<ProduktModel>(ClassWorkDB.GetAllProdukts());


        }

    }
}
