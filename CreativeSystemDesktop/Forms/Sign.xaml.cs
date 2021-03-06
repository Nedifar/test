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
    /// Логика взаимодействия для Sign.xaml
    /// </summary>
    public partial class Sign : Window
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void clSign(object sender, RoutedEventArgs e)
        {
            var user = Models.context.aGetContext().Users.Where(p => p.UserLogin == tbLogin.Text && p.UserPassword == tbPas.Password).FirstOrDefault();
            if (user != null)
            {
                new ClientForm(user).Show();
                Close();
            }
            else
                MessageBox.Show("Неправильные данные.");
        }

        private void clSignHost(object sender, RoutedEventArgs e)
        {

        }
    }
}
