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

namespace CreativeSystemDesktop.Forms
{
    /// <summary>
    /// Логика взаимодействия для ClientForm.xaml
    /// </summary>
    public partial class ClientForm : Window
    {
        int count = 0;
        Models.User user = new Models.User();
        public ClientForm(Models.User user)
        {
            InitializeComponent();
            sortBox.ItemsSource = new string[] { "По возрастанию", "По убыванию" };
            List<string> list = new List<string>();
            filterBox.ItemsSource = Models.context.aGetContext().Products.Select(p => new { Name = p.ProductManufacturer }).Distinct().ToList();
            if (user.UserRole == 1) checkAdmin.IsChecked = true;
            tbName.Text = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
            lv.ItemsSource = Models.context.aGetContext().Products.ToList();
        }

        private void clEdit(object sender, RoutedEventArgs e)
        {
            if (count != 0) return;
            var pr = (sender as Button).DataContext as Models.Product;
            AddEdit addEdit = new AddEdit(pr);
            addEdit.Show();
            count++;
            addEdit.IsVisibleChanged += AddEdit_IsVisibleChanged;
        }

        private void AddEdit_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            sortBox_SelectionChanged(null, null);
            count--;
        }

        private void clDelete(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данный товар?", "Предупреждение", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                var pr = (sender as Button).DataContext as Models.Product;
                Models.context.aGetContext().Products.Remove(pr);
                Models.context.aGetContext().SaveChanges();
                MessageBox.Show("Удаление успешно завершено");
                sortBox_SelectionChanged(null, null);
            }
        }

        private void clAdd(object sender, RoutedEventArgs e)
        {
            if (count != 0) return;
            count++;
            AddEdit addEdit = new AddEdit(null);
            addEdit.Show();
            addEdit.IsVisibleChanged += AddEdit_IsVisibleChanged;
        }

        private void sortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sortBox.SelectedIndex == 0)
                lv.ItemsSource = Models.context.aGetContext().Products.OrderBy(p => p.ProductCost).ToList();
            else if (sortBox.SelectedIndex == 1)
                lv.ItemsSource = Models.context.aGetContext().Products.OrderByDescending(p => p.ProductCost).ToList();
            else
                lv.ItemsSource = Models.context.aGetContext().Products.ToList();
        }

        private void filterBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var send = (sender as ComboBox).SelectedItem.ToString().Replace(" }", "").Replace("{ Name = ", "");
            lv.ItemsSource = Models.context.aGetContext().Products.Where(p => p.ProductManufacturer == send).ToList();
        }
    }
}
