using System.Windows;
using Seals.ViewModels;

namespace Seals
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Tab.DataContext = new SealVM();
            Tab2.DataContext = new AddVM();
        }
        
    }
}
