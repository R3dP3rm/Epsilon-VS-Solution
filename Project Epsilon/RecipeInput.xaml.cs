using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Epsilon
{
    public partial class RecipeInput
    {

        public RecipeInput()
        {
            InitializeComponent();
        }

        private void optionsBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OptionsMenu winOptionsMenu = new OptionsMenu();
            winOptionsMenu.Show();
            this.Hide();
        }

        private void setupBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            UDIPage winUDIPage = new UDIPage();
            winUDIPage.Show();
            this.Hide();
        }

        private void homeBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow winMainWindow = new MainWindow();
            winMainWindow.Show();
            this.Hide();
        }
    }
}
