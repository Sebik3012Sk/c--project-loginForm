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

namespace learn_csharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Login_past_click(object sender,RoutedEventArgs e)
        {
            string data_username = input_username.Text.ToString();
            string data_password = input_password.Password.ToString();

;           string[] list_password = { "7259" };

            if(data_username == "Sebastian Kučera" && data_password == list_password[0])
            {
                validData.Text = "Your data is valid :D";
                validData.Foreground = new SolidColorBrush(Colors.DarkBlue);
                validData.FontSize = 18;
            }

        }
    }
}
