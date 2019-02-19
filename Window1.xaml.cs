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

namespace Test1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            if ((App.Current as App).Age != 0)
            {
                AgeBox.Text = (App.Current as App).Age.ToString();
            }
            if ((App.Current as App).Sex == "Mężczyzna")
            {
                ManRadioButton.IsChecked = true;
            }
            else if ((App.Current as App).Sex == "Kobieta")
            {
                WomanRadioButton.IsChecked = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((ValidateAge()) && (ValidateSex()))
            {
                SetSex();
                SetAge();
                Window2 window2 = new Window2();
                window2.Show();
                this.Close();
            }
        }



        private bool ValidateAge()
        {
            int i;
            if ((!int.TryParse(AgeBox.Text, out i)) || (string.IsNullOrWhiteSpace(AgeBox.Text)) || (int.Parse(AgeBox.Text) <= 0))
            {
                MessageBox.Show("Proszę podać prawidłowy wiek");
                return false;
            }
            else
            {
                return true;
            }

        }
        private bool ValidateSex()
        {
            if ((ManRadioButton.IsChecked == false) && (WomanRadioButton.IsChecked == false))
            {
                MessageBox.Show("Proszę wybrać płeć");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void SetSex()
        {

            if (ManRadioButton.IsChecked == true)
                (App.Current as App).Sex = ManRadioButton.Content.ToString();
            else
                (App.Current as App).Sex = WomanRadioButton.Content.ToString();
        }
        private void SetAge()
       {
            
            (App.Current as App).Age = int.Parse(AgeBox.Text);
        }
    }
}
