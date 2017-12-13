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
using System.Windows.Shapes;

namespace AzureAppDemo.Views
{
    /// <summary>
    /// Interaction logic for AddCartWindow.xaml
    /// </summary>
    public partial class AddCartWindow : Window
    {
        public ObservableCollection<Product> Products
        {
            get { return (ObservableCollection<Product>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        public static readonly DependencyProperty ProductsProperty =
            DependencyProperty.Register("Products", typeof(ObservableCollection<Product>), typeof(AddCartWindow), new PropertyMetadata(null));


        public AddCartWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { ID = Guid.NewGuid().ToString(), ProductName = "Product One", Rate = 100.0 },
                new Product { ID = Guid.NewGuid().ToString(), ProductName = "Product Two", Rate = 350.0 },
                new Product { ID = Guid.NewGuid().ToString(), ProductName = "Product Three", Rate = 300.0 },
                new Product { ID = Guid.NewGuid().ToString(), ProductName = "Product Four", Rate = 250.0 },
                new Product { ID = Guid.NewGuid().ToString(), ProductName = "Product Five", Rate = 400.0 },
            };
        }

        private async void OnAddToCartClicked(object sender, RoutedEventArgs e)
        {
            if (products.SelectedItem is Product selectedProduct)
            {
                var product = new Cart { ID = selectedProduct.ID, ProductName = selectedProduct.ProductName, Rate = selectedProduct.Rate, Quantity = int.Parse(quantity.Text) };
                await App.MobileService.GetTable<Cart>().InsertAsync(product);
            }

            Close();
        }
    }
}
