using System.ComponentModel;
using System.Runtime.CompilerServices;
using DAL.Entities;
using System.Windows;

namespace Seals.ViewModels
{
    public class NewSrVM : INotifyPropertyChanged
    {
        SealDB db;
        SrWindow win;

        public NewSrVM(SealDB context, SrWindow w)
        {
            win = w;
            db = context;
        }

        Sreda sreda;

        public NewSrVM(SealDB context, SrWindow w, Sreda sr)
        {
            win = w;
            db = context;
            NameS = sr.NameS;
            sreda = sr;
        }

        public NewSrVM()
        {
        }

        string NameS;

        public string newNameS
        {
            get { return NameS; }
            set
            {
                NameS = value;
                OnPropertyChanged("NameS");
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        if (newNameS != null)
                        {
                            Sreda sreda = new Sreda();
                            sreda.Id = 1;
                            sreda.NameS = newNameS;

                            db.Sreda.Add(sreda);
                            db.SaveChanges();
                            MessageBox.Show("Новое наименование Среды успешно добавлено в Базу данных");

                            win.Close();
                        }
                        else
                            MessageBox.Show("Ошибка! Для сохранения поле обязательно должно быть заполнено");
                    }));
            }
        }

        private RelayCommand clCommand;
        public RelayCommand ClCommand
        {
            get
            {
                return clCommand ??
                    (clCommand = new RelayCommand(obj =>
                    {
                        win.Close();
                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
