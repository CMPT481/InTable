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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TLFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            TRFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BRFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BLFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void TLButtonClick(object sender, RoutedEventArgs e)
        {
            TLFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
        }

        private void TRButtonClick(object sender, RoutedEventArgs e)
        {
            TRFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
        }

        private void BRButtonClick(object sender, RoutedEventArgs e)
        {
            BRFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
        }

        private void BLButtonClick(object sender, RoutedEventArgs e)
        {
            BLFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
        }
    }
}
