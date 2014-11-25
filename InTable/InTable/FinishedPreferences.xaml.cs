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

namespace InTable
{
    /// <summary>
    /// Interaction logic for FinishedPreferences.xaml
    /// </summary>
    public partial class FinishedPreferences : Page
    {
        public FinishedPreferences()
        {
            InitializeComponent();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("SavingPage.xaml", UriKind.Relative));
        }

        private void SkipSaveButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("OrderPage.xaml", UriKind.Relative));
        }
    }
}
