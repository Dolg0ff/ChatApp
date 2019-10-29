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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatApp.Desktop.Views
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private MainWindow _window;
        public Login()
        {
            InitializeComponent();
            _window = (MainWindow)Application.Current.MainWindow;
            if(_window != null)
            {
                _window.Width = 540;
                _window.Height = 420;
                _window.MinWidth = 540;
                _window.MinHeight = 420;
                _window.MaxWidth = 540;
                _window.MaxHeight = 420;
            }
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Username.Text))
            {
                User
            }
        }
    }
}
