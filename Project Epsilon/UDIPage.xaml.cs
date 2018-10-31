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

namespace Project_Epsilon
{
    /// <summary>
    /// Interaction logic for UDI.xaml
    /// </summary>
    public partial class UDIPage
    {
        public UDIPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            RecipeInput winRecipeInput = new RecipeInput();
            winRecipeInput.Show();
            this.Hide();
        }

        //private void chkUseUDI_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    txtUDIRecipe.Text = string.Empty;
        //}

        //private void chkUseUDI_Checked(object sender, RoutedEventArgs e)
        //{
        //    //if (chkUseUDI.IsCheckesd == true)
        //    //{
        //        txtUDIRecipe.Text = "1234567890";
        //    //}
        //    //else
        //    //{
        //    //    txtUDIRecipe.Text = string.Empty;
        //    //}
        //}

        private void chkCompareUDI_Checked(object sender, RoutedEventArgs e)
        {
            //txtUDIEntireOrPartial.KeyDown
        }

        private void chkUseUDI_Click(object sender, RoutedEventArgs e)
        {
            if(chkUseUDI.IsChecked.Equals(true))
            {
                txtUDIRecipe.Text = "test";
            }
            else
            {
                txtUDIRecipe.Text = string.Empty;
            }
        }

        private void txtUDIEntireOrPartial_TextChanged(object sender, TextChangedEventArgs e)
        {
            var input = txtUDIEntireOrPartial.Text.ToString().ToUpper();
            if(input == "E")
            {
                //Do entire
                txtUDIFirstPosition.IsEnabled = txtUDIEndingPosition.IsEnabled = false;
            }
            else if(input == "P")
            {
                txtUDIFirstPosition.IsEnabled = txtUDIEndingPosition.IsEnabled = true;
                //do partial
            }
            else
            {
                txtUDIFirstPosition.IsEnabled = txtUDIEndingPosition.IsEnabled = false;
                //invalid input, clear textfield.
            }

            //if (input != "e" && input != "p")
            //{
            //    txtUDIEntireOrPartial.Text = string.Empty;
            //}

        }

        //private void txtUDIEntireOrPartial_KeyDown(object sender, KeyEventArgs e)
        //{
        //    txtUDIEntireOrPartial.TextChanged
        //    if (e.Key == Key.E)
        //        txtUDIEntireOrPartial.Text = string.Empty;
        //}
    }
}
