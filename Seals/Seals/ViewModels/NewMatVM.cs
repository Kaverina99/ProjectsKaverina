using System.ComponentModel;
using System.Runtime.CompilerServices;
using DAL.Entities;
using System.Windows;

namespace Seals.ViewModels
{
    public class NewMatVM : INotifyPropertyChanged
    {
        SealDB db;
        MatWindow win;

        public NewMatVM(SealDB context, MatWindow w)
        {
            win = w;
            db = context;
        }

        Material material;

        public NewMatVM(SealDB context, MatWindow w, Material mat)
        {
            win = w;
            db = context;
            NameM = mat.NameM;
            material = mat;
        }

        string NameM;

        public string newNameM
        {
            get { return NameM; }
            set
            {
                NameM = value;
                OnPropertyChanged("NameM");
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
                        if (newNameM != null)
                        {
                            Material material = new Material();
                            material.Id = 1;
                            material.NameM = newNameM;

                            db.Material.Add(material);
                            db.SaveChanges();
                            MessageBox.Show("Новое наименование Материала успешно добавлено в Базу данных");
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
