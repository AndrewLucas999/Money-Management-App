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
using InternalLibrary.View_Model;

namespace MoneyManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowViewModel Model { get; } = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Model;
        }

        private void EnterBalance_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OpenDaySpendingUpdateWindow_OnClick(object sender, RoutedEventArgs e)
        {
            DaySpendingUpdate daySpendWindow = new DaySpendingUpdate();
            daySpendWindow.Show();
        }
    }
}