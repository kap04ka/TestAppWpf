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

namespace TestAppWpf
{
    /// <summary>
    /// Логика взаимодействия для TestCOVID.xaml
    /// </summary>
    public partial class TestCOVID : Page
    {
        public TestCOVID()
        {
            InitializeComponent();
        }
        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void checkBoxDiseases_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBoxDiseases_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBoxActivity_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBoxActivity_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonEducation_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonAbilityToWork_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonPerfomance_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonLeisure_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void slider_ValueChanged(object sender, RoutedEventArgs e)
        {

        }

        private void radioButtonGender_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
