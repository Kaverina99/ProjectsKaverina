using System.Windows;
using DAL.Entities;
using Seals.ViewModels;

namespace Seals
{
    /// <summary>
    /// Логика взаимодействия для MatWindow.xaml
    /// </summary>
    public partial class MatWindow : Window
    {
        public MatWindow(SealDB context)
        {
            InitializeComponent();
            DataContext = new NewMatVM(context, this);
        }
 

        public MatWindow(SealDB context, Material mat)
        {
            InitializeComponent();
            DataContext = new NewMatVM(context, this, mat);
        }
    }
}
