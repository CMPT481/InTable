﻿using System;
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
    /// Interaction logic for PairingPage.xaml
    /// </summary>
    public partial class PairingPage : Page
    {

        private void TapButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("OrderPage.xaml", UriKind.Relative));
        }

        private void TextBlock_GotTouchCapture(object sender, TouchEventArgs e)
        {
            NavigationService.Navigate(new Uri("OrderPage.xaml", UriKind.Relative));
        }

        private void TextBlock_GotMouseCapture(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new Uri("OrderPage.xaml", UriKind.Relative));
        }
    }
}
