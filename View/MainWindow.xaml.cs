using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
//using System.Data.SqlClient;

namespace Profitability.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Loaded += MainWindow_Loaded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MainViewModel();
        }

        public void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            object _sender = sender;
            SavingToDB.Save(_sender);
        }        

        public void GenerationButton_Click(object sender, RoutedEventArgs e)
        {
            RepoportGeneration.Generation();
        }
    }
}
