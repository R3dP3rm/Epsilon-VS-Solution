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

namespace Project_Epsilon___Options_Menu
{
    /// <summary>
    /// Interaction logic for ToolSetupWindow.xaml
    /// </summary>
    public partial class ToolSetupWindow : Window
    {
        public ToolSetupWindow()
        {
            InitializeComponent();
        }
   
        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow objOptionsWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objOptionsWindow.Show();
        }

        private void ToolConfChecked(object sender, EventArgs e)
        {
            if (ToolConfCheckBox.IsChecked == true)
            {
                NumCavsTextbox.Visibility = Visibility.Visible;
                NumCavsLabel.Visibility = Visibility.Visible;
                ToolUIDLabel.Visibility = Visibility.Visible;
                ToolUIDTextbox.Visibility = Visibility.Visible;
            }
            else
            {
                NumCavsTextbox.Visibility = Visibility.Hidden;
                NumCavsLabel.Visibility = Visibility.Hidden;
                ToolUIDLabel.Visibility = Visibility.Hidden;
                ToolUIDTextbox.Visibility = Visibility.Hidden;
            }

        }
        /// Allows only numeric input from user for Number of Cavities in the Tool textbox
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }

        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i >= 1 && i <= 8;
        }
        
    }
}
