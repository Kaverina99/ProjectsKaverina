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
    public class PokypkiVM : INotifyPropertyChanged
    {

        private PokypkaModel selectedPokypki;

        public ObservableCollection<PokypkaModel> Pokypki { get; set; }
        public PokypkaModel SelectedPokypki
        {
            get { return selectedPokypki; }
            set
            {
                selectedPokypki = value;
                OnPropertyChanged("SelectedPokypki");
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
                      PokypkaModel pokypki = new PokypkaModel();
                      Pokypki.Insert(0, pokypki);
                      SelectedPokypki = pokypki;
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
                      PokypkaModel pokypka = obj as PokypkaModel;
                      if (pokypka != null)
                      {
                          Pokypki.Remove(pokypka);
                      }
                  },
                 //условие, при котором будет доступна команда
                 (obj) => (Pokypki.Count > 0 && selectedPokypki != null)));
            }
        }


        public PokypkiVM()
        {
            DBDataOperation ClassWorkDB = new DBDataOperation();
            Pokypki = new ObservableCollection<PokypkaModel>(ClassWorkDB.GetAllPokypki());


        }

    }
}
