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
        User TLUser = new User();
        User TRUser = new User();
        User BRUser = new User();
        User BlUser = new User();

        public MainWindow()
        {
            InitializeComponent();
            TLFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            TRFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BRFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            BLFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;

            TLFrame.Navigated += TLFrame_Navigated;
            TRFrame.Navigated += TRFrame_Navigated;
            BRFrame.Navigated += BRFrame_Navigated;
            BLFrame.Navigated += BLFrame_Navigated;
        }

        void BLFrame_Navigated(object sender, NavigationEventArgs e)
        {
            BLFrame.DataContext = BlUser;
            (BLFrame.Content as Page).DataContext = BlUser;
        }

        void BRFrame_Navigated(object sender, NavigationEventArgs e)
        {
            BRFrame.DataContext = BRUser;
            (BRFrame.Content as Page).DataContext = BRUser;
        }

        void TRFrame_Navigated(object sender, NavigationEventArgs e)
        {
            TRFrame.DataContext = TRUser;
            (TRFrame.Content as Page).DataContext = TRUser;
        }

        void TLFrame_Navigated(object sender, NavigationEventArgs e)
        {
            TLFrame.DataContext = TLUser;
            (TLFrame.Content as Page).DataContext = TLUser;
        }

        private void TLButtonClick(object sender, RoutedEventArgs e)
        {
            TLFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            TLFrame.DataContext = new User();
        }

        private void TRButtonClick(object sender, RoutedEventArgs e)
        {
            TRFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            TRFrame.DataContext = new User();
        }

        private void BRButtonClick(object sender, RoutedEventArgs e)
        {
            BRFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            BRFrame.DataContext = new User();
        }

        private void BLButtonClick(object sender, RoutedEventArgs e)
        {
            BLFrame.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            BLFrame.DataContext = new User();
        }

    }
}
