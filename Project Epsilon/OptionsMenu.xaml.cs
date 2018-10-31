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

namespace Project_Epsilon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class OptionsMenu : Window
    {
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void OpenToolSetupWindow(object sender , RoutedEventArgs e)
        {
            ToolSetupWindow objSecondWindow = new ToolSetupWindow();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            OptionsMenu objOptionsWindow = new OptionsMenu();
            this.Visibility = Visibility.Hidden;
            objOptionsWindow.Show();
        }
    }
}
