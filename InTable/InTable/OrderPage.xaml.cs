using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        //private ObservableCollection<Dish> ordredSoFar = new ObservableCollection<Dish>();

        public OrderPage()
        {
            InitializeComponent();
            Loaded += OrderPage_Loaded;
        }

        void OrderPage_Loaded(object sender, RoutedEventArgs e)
        {
            AppsList.ItemsSource = Dish.Apps.OrderBy(a => Guid.NewGuid());
            MainsList.ItemsSource = Dish.Mains.OrderBy(a => Guid.NewGuid());
            DessertList.ItemsSource = Dish.Desserts.OrderBy(a => Guid.NewGuid());
            ColdList.ItemsSource = Dish.Cold.OrderBy(a => Guid.NewGuid());
            HotList.ItemsSource = Dish.Hot.OrderBy(a => Guid.NewGuid());
            DrunkList.ItemsSource = Dish.Alchoholic.OrderBy(a => Guid.NewGuid());
            BoughtItems.ItemsSource = (DataContext as User).ordredSoFar;
        }

        private void FoodButtonClick(object sender, RoutedEventArgs e)
        {
            if (FoodsGrid.Visibility == System.Windows.Visibility.Collapsed)
            {
                FoodsGrid.Visibility = System.Windows.Visibility.Visible;
                DrinksGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrawingGrid.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                FoodsGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrinksGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrawingGrid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void DrinkButtonClick(object sender, RoutedEventArgs e)
        {
            if (DrinksGrid.Visibility == System.Windows.Visibility.Collapsed)
            {
                FoodsGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrinksGrid.Visibility = System.Windows.Visibility.Visible;
                DrawingGrid.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                FoodsGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrinksGrid.Visibility = System.Windows.Visibility.Collapsed;
                DrawingGrid.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void BuyButtonClick(object sender, RoutedEventArgs e)
        {
            (DataContext as User).ordredSoFar.Insert(0,(sender as Button).DataContext as Dish);
        }
    }
}
