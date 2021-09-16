using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using DAL.Entities;
using System.Data.Entity.Validation;
using System.Windows;

namespace Seals.ViewModels
{
    public class AddVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public SealDB db;
        public SealDB context;

        public AddVM()
        {
            db = new SealDB();
            TipSe2 = new ObservableCollection<Tip_Seal>(db.Tip_Seal);
            TipHol = new ObservableCollection<Tip_Hol>(db.Tip_Hol);
            Sr2 = new ObservableCollection<Sreda>(db.Sreda);
            M = new ObservableCollection<Material>(db.Material);
        }


        string NameSeal;
        double Dv;
        double D1;
        double D3;
        double L2;
        double L1;
        double D2;
        double Dsh;
        double N;
        double A;
        string Nasos;
        double C;
        double Davl;
        double M_netto;
        string Features;
        double Cost1;
        double Cost6;
        double CostZ;


        public string dNameSeal
        {
            get { return NameSeal; }
            set
            {
                NameSeal = value;
                OnPropertyChanged("NameSeal");
            }
        }

        public double dDv
        {
            get { return Dv; }
            set
            {
                Dv = value;
                OnPropertyChanged("Dv");
            }
        }

        public double dD1
        {
            get { return D1; }
            set
            {
                D1 = value;
                OnPropertyChanged("D1");
            }
        }
        public double dD3
        {
            get { return D3; }
            set
            {
                D3 = value;
                OnPropertyChanged("D3");
            }
        }
        public double dL2
        {
            get { return L2; }
            set
            {
                L2 = value;
                OnPropertyChanged("L2");
            }
        }
        public double dL1
        {
            get { return L1; }
            set
            {
                L1 = value;
                OnPropertyChanged("L1");
            }
        }
        public double dD2
        {
            get { return D2; }
            set
            {
                D2 = value;
                OnPropertyChanged("D2");
            }
        }

        public double dDsh
        {
            get { return Dsh; }
            set
            {
                Dsh = value;
                OnPropertyChanged("Dsh");
            }
        }
        public double dN
        {
            get { return N; }
            set
            {
                N = value;
                OnPropertyChanged("N");
            }
        }
        public double dA
        {
            get { return A; }
            set
            {
                A = value;
                OnPropertyChanged("A");
            }
        }

        public string dNasos
        {
            get { return Nasos; }
            set
            {
                Nasos = value;
                OnPropertyChanged("Nasos");
            }
        }

        public double dC
        {
            get { return C; }
            set
            {
                C = value;
                OnPropertyChanged("C");
            }
        }

        public double dDavl
        {
            get { return Davl; }
            set
            {
                Davl = value;
                OnPropertyChanged("Davl");
            }
        }

        public double dNetto
        {
            get { return M_netto; }
            set
            {
                M_netto = value;
                OnPropertyChanged("M_netto");
            }
        }
        public string dFeatures
        {
            get { return Features; }
            set
            {
                Features = value;
                OnPropertyChanged("Features");
            }
        }
        public double dCost1
        {
            get { return Cost1; }
            set
            {
                Cost1 = value;
                OnPropertyChanged("Cost1");
            }
        }
        public double dCost6
        {
            get { return Cost6; }
            set
            {
                Cost6 = value;
                OnPropertyChanged("Cost6");
            }
        }
        public double dCostZ
        {
            get { return CostZ; }
            set
            {
                CostZ = value;
                OnPropertyChanged("CostZ");
            }
        }


        public ObservableCollection<Tip_Seal> TipSe2 { get; set; }
        Tip_Seal selectTipSe2;
        public Tip_Seal SelectTipSe2
        { 
            get { return selectTipSe2; }
            set
            {
                selectTipSe2 = value;
                OnPropertyChanged("SelectTipSe2");
            }
        }

        int ComboTipSe2 { get; set; }
        public int comboTipSe2
        {
            get { return ComboTipSe2; }
            set
            {
                ComboTipSe2 = value;
                OnPropertyChanged("comboTipSe2");
            }
        }


        public ObservableCollection<Tip_Hol> TipHol { get; set; }
        Tip_Hol selectTipHol;
        public Tip_Hol SelectTipHol
        {
            get { return selectTipHol; }
            set
            {
                selectTipHol = value;
                OnPropertyChanged("SelectTipHol");
            }
        }
        int ComboTipHol { get; set; }
        public int comboTipHol
        {
            get { return ComboTipHol; }
            set
            {
                ComboTipHol = value;
                OnPropertyChanged("comboTipHol");
            }
        }


        public ObservableCollection<Sreda> Sr2 { get; set; }
        Sreda selectSr2;
        public Sreda SelectSr2
        {
            get { return selectSr2; }
            set
            {
                selectSr2 = value;
                OnPropertyChanged("SelectSr2");
            }
        }
        int ComboSr2 { get; set; }
        public int comboSr2
        {
            get { return ComboSr2; }
            set
            {
                ComboSr2 = value;
                OnPropertyChanged("comboSr2");
            }
        }


        public ObservableCollection<Material> M { get; set; }
        Material selectM;
        public Material SelectM
        {
            get { return selectM; }
            set
            {
                selectM = value;
                OnPropertyChanged("SelectM");
            }
        }
        int ComboM { get; set; }
        public int comboM
        {
            get { return ComboM; }
            set
            {
                ComboM = value;
                OnPropertyChanged("comboM");
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
                      try
                      {
                          if (dNameSeal != null && dDv != 0 && dD1 != 0 && dD3 != 0 && dL2 != 0 && dL1 != 0 && dD2 != 0 && dDsh != 0 && dA != 0 && dC != 0 && selectTipSe2.Id != 0 && selectTipHol.Id != 0 && selectSr2.Id != 0 && selectM.Id != 0)
                          {
                              Seal s = new Seal();
                              s.Id = 1;
                              s.NameSeal = dNameSeal;
                              s.Dv = dDv;
                              s.D1 = dD1;
                              s.D3 = dD3;
                              s.L2 = dL2;
                              s.L1 = dL1;
                              s.D2 = dD2;
                              s.Dsh = dDsh;
                              s.N = dN;//-
                              s.A = dA;
                              s.Nasos = dNasos;//-
                              s.C = dC;
                              s.Davl = dDavl;//-
                              s.M_netto = dNetto;//-
                              s.Features = dFeatures;//-
                              s.Cost1 = dCost1;//-
                              s.Cost6 = dCost6;//-
                              s.CostZ = dCostZ;//-

                              s.TipS = selectTipSe2.Id;
                              s.TipH = selectTipHol.Id;
                              s.NameSreda = selectSr2.Id;
                              s.NameMaterial = selectM.Id;

                              db.Seal.Add(s);
                              db.SaveChanges();

                              MessageBox.Show("Новое торцевое уплотнение успешно добавлено в Базу данных");
                          }
                          else
                              MessageBox.Show("Ошибка! Проверьте корректность введенных данных");

                      }

                      catch (DbEntityValidationException ex)
                      {
                          // Retrieve the error messages as a list of strings.
                          var errorMessages = ex.EntityValidationErrors
                                  .SelectMany(x => x.ValidationErrors)
                                  .Select(x => x.ErrorMessage);

                          // Join the list to a single string.
                          var fullErrorMessage = string.Join("; ", errorMessages);

                          // Combine the original exception message with the new one.
                          var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                          // Throw a new DbEntityValidationException with the improved exception message.
                          throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                      }
                  }
                  
                  ));
            }
        }


        private RelayCommand newMatCommand;
        public RelayCommand NewMatCommand
        {
            get
            {
                return newMatCommand ??
                  (newMatCommand = new RelayCommand(obj =>
                  {
                      Material matt = new Material();

                      MatWindow matW = new MatWindow(db);
                      bool? res = matW.ShowDialog();

                      M.Clear();
                      foreach (Material mat in db.Material)
                      { 
                          M.Add(mat);
                      }
                      selectM = matt;

                  }));
            }
        }


        private RelayCommand newSrCommand;
        public RelayCommand NewSrCommand
        {
            get
            {
                return newSrCommand ??
                  (newSrCommand = new RelayCommand(obj =>
                  {
                      Sreda srr = new Sreda();

                      SrWindow srW = new SrWindow(db);
                      bool? res = srW.ShowDialog();

                      Sr2.Clear();
                      foreach (Sreda sr in db.Sreda)
                      {
                          Sr2.Add(sr);
                      }
                      selectSr2 = srr;

                  }));
            }
        }



    }
}
