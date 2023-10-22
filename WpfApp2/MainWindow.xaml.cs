using System.Collections.Generic;
using System.Windows;
using WpfApp2.BaseTools;
using WpfApp2.bd;
using WpfApp2.ViewVomeds;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowVM();
           
        }
    }
}
