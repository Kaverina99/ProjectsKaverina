using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DAL.Entities;
using System.Data.SqlClient;
using System.Windows;

namespace Seals.ViewModels
{
    public class SealVM : INotifyPropertyChanged
    {
        
        public ObservableCollection<Sreda> Sredas { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public ObservableCollection<Sreda> Sr { get; set; }
        Sreda selectSr;
        public Sreda SelectSr

        {
            get { return selectSr; }
            set
            {
                selectSr = value;
                OnPropertyChanged("SelectSr");
            }
        }
        int ComboBoxSr { get; set; }
        public int comboBoxSr
        {
            get { return ComboBoxSr; }
            set
            {
                ComboBoxSr = value;
                OnPropertyChanged("comboBoxSr");
            }
        }


        public ObservableCollection<Tip_Seal> TipSe { get; set; }
        Tip_Seal selectTipSe;
        public Tip_Seal SelectTipSe

        {
            get { return selectTipSe; }
            set
            {
                selectTipSe = value;
                OnPropertyChanged("SelectTipSe");
            }
        }

        int ComboBoxTipSe { get; set; }
        public int comboBoxTipSe
        {
            get { return ComboBoxTipSe; }
            set
            {
                ComboBoxTipSe = value;
                OnPropertyChanged("comboBoxTipSe");
            }
        }

     
        SealDB db;

         public SealVM()
         {
            db = new SealDB();
           
            Sredas = new ObservableCollection<Sreda>(db.Sreda.ToList());

            Sr = new ObservableCollection<Sreda>(db.Sreda);
            TipSe = new ObservableCollection<Tip_Seal>(db.Tip_Seal);

            resS = new ObservableCollection<Res>();
         }

        public class Res
        {
            public string NameSeal { get; set; }
            public double Dv { get; set; }
            public double D1 { get; set; }
            public double D3 { get; set; }
            public double L2 { get; set; }
            public double L1 { get; set; }
            public double D2 { get; set; } 
            public double Dsh { get; set; }
            public double N { get; set; }
            public double A { get; set; }
            public string Nasos { get; set; }
            public string NameS { get; set; }
            public double C { get; set; }
            public double Davl { get; set; }

            public string NameM { get; set; }
            public double M_netto { get; set; }
            public string Features { get; set; }
            public double Cost1 { get; set; }
            public double Cost6 { get; set; }
            public double CostZ { get; set; }
            public int Kolvo { get; set; }
            public double Total { get; set; }

        }


        Double TDavl { get; set; }
        public Double tDavl
        {
            get { return TDavl; }
            set
            {
                TDavl = value;
                OnPropertyChanged("tDavl");
            }
        }

        Double TC { get; set; }
        public Double tC
        {
            get { return TC; }
            set
            {
                TC = value;
                OnPropertyChanged("tC");
            }
        }
        Double TDv { get; set; }
        public Double tDv
        {
            get { return TDv; }
            set
            { 
                TDv = value;
                OnPropertyChanged("tDv");
            }
        }

        Double TD1 { get; set; }
        public Double tD1
        {
            get { return TD1; }
            set
            {
                TD1 = value;
                OnPropertyChanged("tD1");
            }
        }

        Double TL1 { get; set; }
        public Double tL1
        {
            get { return TL1; }
            set
            {
                TL1 = value;
                OnPropertyChanged("tL1");
            }
        }
        Double TL2 { get; set; }
        public Double tL2
        {
            get { return TL2; }
            set
            {
                TL2 = value;
                OnPropertyChanged("tL2");
            }
        }

        Double TD2 { get; set; }
        public Double tD2
        {
            get { return TD2; }
            set
            {
                TD2 = value;
                OnPropertyChanged("tD2");
            }
        }

        Double TD3 { get; set; }
        public Double tD3
        {
            get { return TD3; }
            set
            {
                TD3 = value;
                OnPropertyChanged("tD3");
            }
        }

        Double TKol { get; set; }
        public Double tKol
        {
            get { return TKol; }
            set
            {
                TKol = value;
                OnPropertyChanged("tKol");
            }
        }

       
        public Collection<Res> resS { get; set; }

        private RelayCommand resCommand;

        public RelayCommand ResCommand
        {
            get
            {
                return resCommand ??
                   (resCommand = new RelayCommand(obj =>
                   {
                       if (tDv!=0 && tD1 != 0 && tL2 != 0 && tL1 != 0 && tC != 0)
                       {
                           SqlParameter p1 = new SqlParameter("@NameSreda", comboBoxSr); //int
                           SqlParameter p2 = new SqlParameter("@Tip_Seal", comboBoxTipSe); //int
                           SqlParameter p4 = new SqlParameter("@Dv", tDv);
                           SqlParameter p5 = new SqlParameter("@D1", tD1);
                           SqlParameter p6 = new SqlParameter("@D3", tD3);//-
                           SqlParameter p7 = new SqlParameter("@L2", tL2);
                           SqlParameter p8 = new SqlParameter("@L1", tL1);
                           SqlParameter p9 = new SqlParameter("@D2", tD2);//-
                           SqlParameter p10 = new SqlParameter("@Davl", tDavl);//-
                           SqlParameter p11 = new SqlParameter("@Kol", tKol);//-

                           List<Res> sPs = null;

                           int comboBoxTipHol = 0;
                           if (tC <= 150) comboBoxTipHol = 1;
                           else comboBoxTipHol = 2;
                           SqlParameter p3 = new SqlParameter("@Tip_Hol", comboBoxTipHol); //int

                           if (tKol <= 6)
                           {
                               sPs = db.Database.SqlQuery<Res>("Res1 @NameSreda, @Tip_Seal, @Tip_Hol, @Dv, @D1, @D3, @L2, @L1, @D2, @Davl, @Kol", new object[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11 }).ToList();
                           }
                           else
                           {
                               sPs = db.Database.SqlQuery<Res>("Res6 @NameSreda, @Tip_Seal, @Tip_Hol, @Dv, @D1, @D3, @L2, @L1, @D2, @Davl, @Kol", new object[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11 }).ToList();
                           }

                           if (sPs.Count == 0)
                           {
                               SqlParameter pp1 = new SqlParameter("@Tip_Seal", comboBoxTipSe);
                               SqlParameter pp2 = new SqlParameter("@Tip_Hol", comboBoxTipHol);
                               SqlParameter pp3 = new SqlParameter("@Dv", tDv);
                               SqlParameter pp4 = new SqlParameter("@Kol", tKol);

                               MessageBox.Show("Внимание!     Не удалось подобрать УТ по введенным параметрам. Ниже представлены УТ подобранные по указаному типу и Dвала (стоимость заказа указана средняя). Для добавления нового УТ в БД зайдите в раздел 'Добавить торцевое уплотнение'");
                               sPs = db.Database.SqlQuery<Res>("Res @Tip_Seal, @Tip_Hol, @Dv, @Kol", new object[] { pp1, pp2, pp3, pp4 }).ToList();

                           }


                           resS.Clear();
                           foreach (Res res in sPs)
                           {
                               resS.Add(res);
                           }
                       }
                       else
                           MessageBox.Show("Ошибка! Проверьте корректность введенных данных");


                   }));
            }
        }
    }
}
