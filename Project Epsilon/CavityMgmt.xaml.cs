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
    /// Interaction logic for CavityMgmt.xaml
    /// </summary>
    public partial class CavityMgmt : Page
    {
        public CavityMgmt()
        {
            InitializeComponent();
        }
        private void OpenToolSetupWindow(object sender, RoutedEventArgs e)
        {
            CavityMgmt objSecondWindow = new CavityMgmt();
            this.Visibility = Visibility.Hidden;
            objSecondWindow.Show();
        }

        private void Show()
        {
            throw new NotImplementedException();
        }

        private void backButtom_Click(object sender, RoutedEventArgs e)
        {
            {
                OptionsMenu objOptionsWindow = new OptionsMenu();
                this.Visibility = Visibility.Hidden;
                objOptionsWindow.Show();
            }
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }

        private void methodTwoCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (methodTwoCheckBox.IsChecked == true)
            {
                cavityToolLabel.Visibility = Visibility.Visible;
                numbCavToolsTxtBox.Visibility = Visibility.Visible;
                cavMgmtLabel.Visibility = Visibility.Visible;
                responseLabel.Visibility = Visibility.Visible;
            }

            else
            {
                cavityToolLabel.Visibility = Visibility.Hidden;
                numbCavToolsTxtBox.Visibility = Visibility.Hidden;
                cavMgmtLabel.Visibility = Visibility.Hidden;
                responseLabel.Visibility = Visibility.Hidden;
            }
        }
    }
}
