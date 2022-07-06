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
    /// Логика взаимодействия для TestPraxisAndGnosis.xaml
    /// </summary>
    public partial class TestPraxisAndGnosis : Page
    {
        int resultTest = 0;
        int resultMotor = 0;
        int resultDynamic = 0;
        int resultConstructive = 0;
        int resultSubject = 0;

        public TestPraxisAndGnosis()
        {
            InitializeComponent();
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {

            resultTest += Int32.Parse(textBoxPointsWatch.Text);
            SetResults();
            MessageBox.Show($"Общий результат = {resultTest}\n" +
                                      $"Моторный праксис = {resultMotor}\n" +
                                      $"Динамический праксис = {resultDynamic}\n" +
                                      $"Конструктивный праксис = {resultConstructive}\n" +
                                      $"Объектный гнозис = {resultSubject}\n" +
                                      $"Повторение часов = {Int32.Parse(textBoxPointsWatch.Text)}\n", "Результат",
                                      MessageBoxButton.OK);


            motorPraxisFirst.IsChecked = false;
            motorPraxisSecond.IsChecked = false;
            motorPraxisThird.IsChecked = false;
            motorPraxisFourth.IsChecked = false;
            motorPraxisFifth.IsChecked = false;

            dynamicPraxisFirst.IsChecked = false;
            dynamicPraxisSecond.IsChecked = false;
            dynamicPraxisThird.IsChecked = false;
            dynamicPraxisFourth.IsChecked = false;
            dynamicPraxisFifth.IsChecked = false;
            dynamicPraxisSixth.IsChecked = false;

            constructivePraxisFirst.IsChecked = false;
            constructivePraxisSecond.IsChecked = false;
            constructivePraxisThird.IsChecked = false;

            subjectGnosisFirst.IsChecked = false;
            subjectGnosisSecond.IsChecked = false;
            subjectGnosisThird.IsChecked = false;

            resultTest = 0;
            resultMotor = 0;
            resultDynamic = 0;
            resultConstructive = 0;
            resultSubject = 0;
            textBoxPointsWatch.Text = "0";


            NavigationService.Navigate(new Menu());
        }

        private void SetResults()
        {
            App.patient.resultPraxisAndGnosis.resultMotorPraxis = resultMotor;
            App.patient.resultPraxisAndGnosis.resultDynamicPraxis = resultDynamic;
            App.patient.resultPraxisAndGnosis.resultConstructivePraxis = resultConstructive;
            App.patient.resultPraxisAndGnosis.resultSubjectGnosis = resultSubject;
            App.patient.resultPraxisAndGnosis.resultClock = Int32.Parse(textBoxPointsWatch.Text);
            App.patient.resultPraxisAndGnosis.TotalResultPraxisAndGnosis = resultTest;
        }
      

        private void subjectGnosis_Checked(object sender, RoutedEventArgs e)
        {
            resultSubject++;
            resultTest++;
        }

        private void subjectGnosis_Unchecked(object sender, RoutedEventArgs e)
        {
            resultSubject--;
            resultTest--;
        }


        private void motorPraxis_Checked(object sender, RoutedEventArgs e)
        {
            resultMotor++;
            resultTest++;
        }

        private void motorPraxis_Unchecked(object sender, RoutedEventArgs e)
        {
            resultMotor--;
            resultTest--;
        }


        private void dynamicPraxis_Checked(object sender, RoutedEventArgs e)
        {
            resultDynamic++;
            resultTest++;
        }

        private void dynamicPraxis_Unchecked(object sender, RoutedEventArgs e)
        {
            resultDynamic--;
            resultTest--;
        }

        private void constructivePraxis_Checked(object sender, RoutedEventArgs e)
        {
            resultConstructive++;
            resultTest++;
        }

        private void constructivePraxis_Unchecked(object sender, RoutedEventArgs e)
        {
            resultConstructive--;
            resultTest--;
        }


        private void textBoxPointsWatch_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox entry = sender as TextBox;

            int points = 0;

            try
            {
                points = Int32.Parse(entry.Text);
            }
            catch
            {
                points = 0;
            }

            finally
            {
                if (points > 8) points = 8;
                if (points < 0) points = 0;
                entry.Text = points.ToString();
            }
        }
    }
}