using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PreferencePage.xaml
    /// </summary>
    public partial class PreferencePage : Page
    {
        private int currentPreference = 0;
        private User currentUser;

        public PreferencePage()
        {
            InitializeComponent();
            Loaded += PreferencePage_Loaded;
        }

        void PreferencePage_Loaded(object sender, RoutedEventArgs e)
        {
            DataPanel.DataContext = PreferenceModel.Preferences[currentPreference];
            updateLayout();
            currentUser = DataContext as User;
        }

        private void PreviousButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentPreference >= 1)
            {
                currentPreference--;
                DataPanel.DataContext = PreferenceModel.Preferences[currentPreference];
                updateLayout();
            }
            else
            {
                NavigationService.Navigate(new Uri("StartPage.xaml", UriKind.Relative));
            }
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            if (currentPreference < PreferenceModel.Preferences.Count - 1)
            {
                currentPreference++;
                DataPanel.DataContext = PreferenceModel.Preferences[currentPreference];
                updateLayout();
            }
            else
            {
                NavigationService.Navigate(new Uri("FinishedPreferences.xaml", UriKind.Relative));
            }
        }

        public void updateLayout()
        {
            if (PreferenceModel.Preferences[currentPreference].Type == PreferenceTypes.BOOLEAN)
            {
                SliderPanel.Visibility = System.Windows.Visibility.Collapsed;
                RadioButtonsPanel.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                SliderPanel.Visibility = System.Windows.Visibility.Visible;
                RadioButtonsPanel.Visibility = System.Windows.Visibility.Collapsed;
            }
            FalseRadioButton.IsChecked = false;
            TrueRadioButton.IsChecked = false;
            ActualSlider.Value = 5;
        }

        public void saveValue()
        {
            if (PreferenceModel.Preferences[currentPreference].Type == PreferenceTypes.BOOLEAN)
            {
                currentUser.userPreferences[currentPreference].Preference = TrueRadioButton.IsChecked.Value;
            }
            else
            {
                currentUser.userPreferences[currentPreference].Ranking = (int) Math.Round(ActualSlider.Value);
            }
        }
    }
}
