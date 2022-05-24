using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Window
    {
        Models.Product product = new Models.Product();
        public AddEdit(Models.Product _product)
        {
            InitializeComponent();
            if (_product != null)
                product = _product;
            DataContext = product;
        }

        private void clSave(object sender, RoutedEventArgs e)
        {
            try
            {
                if (product.ProductCost > 0)
                {
                    if (Models.context.aGetContext().Products.Where(p => p.ProductArticleNumber == product.ProductArticleNumber).FirstOrDefault() == null)
                    {
                        if (product.ProductPhoto == null)
                            product.ProductPhoto = "";
                        Models.context.aGetContext().Products.Add(product);
                    }
                    Models.context.aGetContext().SaveChanges();
                    MessageBox.Show("Успешно сохранено.");
                    Close();
                }
                else
                { MessageBox.Show("Ошибка в данных."); }
            }
            catch { MessageBox.Show("Ошибка в данных."); }
        }

        private void clPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                string partPath = openFile.FileName.Split('\\').LastOrDefault();
                if(!File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}Images/{partPath}"))
                File.Copy(openFile.FileName, $"{AppDomain.CurrentDomain.BaseDirectory}Images/{partPath}");
                product.ProductPhoto = partPath;
                img.Source = new BitmapImage(new Uri($"{AppDomain.CurrentDomain.BaseDirectory}Images/{partPath}"));
            }
        }
    }
}
