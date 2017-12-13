using AzureAppDemo.Models;
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
using System.Windows.Shapes;

namespace AzureAppDemo.Views
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public Cart Product
        {
            get { return (Cart)GetValue(ProductProperty); }
            set { SetValue(ProductProperty, value); }
        }

        public static readonly DependencyProperty ProductProperty =
            DependencyProperty.Register("Product", typeof(Cart), typeof(UpdateWindow), new PropertyMetadata(null));


        public UpdateWindow(Cart cart)
        {
            InitializeComponent();

            Product = cart;
        }

        private async void OnUpdateCartClicked(object sender, RoutedEventArgs e)
        {
            await App.MobileService.GetTable<Cart>().UpdateAsync(Product);
            Close();
        }
    }
}
