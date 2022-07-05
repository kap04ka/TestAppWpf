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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click_COVID(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestCOVID());
        }

        private void Button_Click_Cognitive(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestCognitive());
        }

        private void Button_Click_Vasserman(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestVasserman());
        }

        private void Button_Click_Burdon(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestBurdon());
        }

        private void Button_Click_PraxisAndGnosis(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestPraxisAndGnosis());
        }

        private void Button_Click_AnxietyAndDepression(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestAnxietyAndDepression());
        }

        private void Button_Click_Asthenia(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestAsthenia());
        }

        private void Button_Click_LifeQuality(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestLifeQuality());
        }

        private void Button_Click_LocusControl(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestLocusControl());
        }

    }
}
