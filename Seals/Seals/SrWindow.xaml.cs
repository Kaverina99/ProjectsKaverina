using System.Windows;
using DAL.Entities;
using Seals.ViewModels;

namespace Seals
{
    /// <summary>
    /// Логика взаимодействия для SrWindow.xaml
    /// </summary>
    public partial class SrWindow : Window
    {
        public SrWindow(SealDB context)
        {
            InitializeComponent();
            DataContext = new NewSrVM(context, this);
        }


        public SrWindow(SealDB context, Sreda sr)
        {
            InitializeComponent();
            DataContext = new NewSrVM(context, this, sr);
        }
    }
}
