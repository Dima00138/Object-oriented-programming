using Microsoft.EntityFrameworkCore;
using MVVM_lab.Commands;
using MVVM_lab.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_lab.ViewModels
{
    internal class ProductionViewModel : INotifyPropertyChanged
    {
        OracleConnection connection = new OracleConnection("User Id = MANAGER; Password = MANAGER_PASS; Data Source = localhost:1521/XE;Persist Security Info=True;");
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product> Cart { get; set; }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
                AddToCart(value);
                if (Products is Product)
                {
                    string insertQuery = "INSERT INTO SCHEDULE (\"ID\", ID_TRAIN, \"DATE\", ROUTE, TIME_IN_WAY, FREQUENCY)" +
                                            " VALUES (:\"id\", :idtrain, :\"date\", :route, :tiw, :freq)";
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(":\"id\"", Convert.ToInt32(connection) + (int)DateTime.Now.Ticks);
                        command.Parameters.Add(":idtrain", connection);
                        command.Parameters.Add(":\"date\"", connection);
                        command.Parameters.Add(":route", 1);
                        command.Parameters.Add(":tiw", connection);
                        command.Parameters.Add(":freq", connection);
                        command.ExecuteNonQuery();
                    }
                }
                    AddToCartCommand.RaiseCanExecuteChanged();
            }
        }
        private Product _removeselect;
        public Product RemoveSelect
        {
            get
            {
                return _removeselect;
            }
            set
            {
                _removeselect = value;
                OnPropertyChanged(nameof(RemoveSelect));
                var caritem = Cart.FirstOrDefault(item => item.Name == value.Name);
                if (caritem.Quantity > 1)
                {
                    Cart.Remove(caritem);
                    caritem.Quantity -= 1;
                    Cart.Add(caritem);
                }
                else {
                    RemoveFromCart(value);
            }
                if (Products is Product)
                {
                    string insertQuery = "DELETE SCHEDULE WHERE ID={:id}";
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(":\"id\"", Convert.ToInt32(connection));
                        command.ExecuteNonQuery();
                    }
                }
                RemoveFromCartCommand.RaiseCanExecuteChanged();
            }
        }
        private RelayCommand _addToCartCommand;
        public RelayCommand AddToCartCommand => _addToCartCommand ??= new RelayCommand(AddToCart, CanAddToCart);

        private void AddToCart(object obj)
        {
            var cartItem = Cart.FirstOrDefault(item => item.Name == SelectedProduct.Name);
            if (cartItem != null)
            {
                Cart.Remove(cartItem);
                cartItem.Quantity++;
                Cart.Add(cartItem);
            }
            else
            {
                Cart.Add(new Product
                (
                    SelectedProduct.Name,
                    SelectedProduct.Price,
                    1
                ));
            }
        }

        private bool CanAddToCart(object obj) => SelectedProduct != null;

        private RelayCommand _removeFromCartCommand;
        public RelayCommand RemoveFromCartCommand => _removeFromCartCommand ??= new RelayCommand(RemoveFromCart, CanRemoveFromCart);
        private void RemoveFromCart(object obj) => Cart.Remove((Product)obj);

        private bool CanRemoveFromCart(object obj) => obj is Product;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductionViewModel()
        {
            Products = new ObservableCollection<Product>
        {
            new Product() { Name = "Product 1", Price = 10.00m, Quantity = 10 },
            new Product() { Name = "Product 2", Price = 15.00m, Quantity = 5 },
            new Product() { Name = "Product 3", Price = 20.00m, Quantity = 3 },
            new Product() { Name = "Product 4", Price = 25.00m, Quantity = 2 }
        };

            Cart = new ObservableCollection<Product>();
        }
    }
}
