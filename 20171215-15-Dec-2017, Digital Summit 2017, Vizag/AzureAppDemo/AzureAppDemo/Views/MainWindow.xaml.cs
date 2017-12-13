using AzureAppDemo.Models;
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

namespace AzureAppDemo.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Cart> MyCart
        {
            get { return (ObservableCollection<Cart>)GetValue(MyCartProperty); }
            set { SetValue(MyCartProperty, value); }
        }

        public static readonly DependencyProperty MyCartProperty =
            DependencyProperty.Register("MyCart", typeof(ObservableCollection<Cart>), typeof(MainWindow), new PropertyMetadata(null));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnRefreshButtonClicked(object sender, RoutedEventArgs e)
        {
            RefreshCart();
        }

        private void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var cartWindow = new AddCartWindow();
            cartWindow.Closed += (s, args) => RefreshCart();
            cartWindow.ShowDialog();
        }

        private void OnUpdateButtonClicked(object sender, RoutedEventArgs e)
        {
            var cartWindow = new UpdateWindow(myCartGrid.SelectedItem as Cart);
            cartWindow.Closed += (s, args) => RefreshCart();
            cartWindow.ShowDialog();
        }

        private void OnDeleteButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        private async void RefreshCart()
        {
            var result = await App.MobileService.GetTable<Cart>().ReadAsync();
            MyCart = new ObservableCollection<Cart>(result);
        }
    }
}
