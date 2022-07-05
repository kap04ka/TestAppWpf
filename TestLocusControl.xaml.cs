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
    /// Логика взаимодействия для TestLocusControl.xaml
    /// </summary>
    public partial class TestLocusControl : Page
    {
        int testResult = 0;

        public TestLocusControl()
        {
            InitializeComponent();
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        public void button_CalculateResult(object sender, RoutedEventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                MessageBox.Show($"Ваше количетво баллов = {testResult}", "Результат", MessageBoxButton.OK);
                testResult = 0;
                ResetAnswersInTest();
                NavigationService.Navigate(new Menu());
            }
            else
            {
                MessageBox.Show("Введены не все данные", "Предупреждение", MessageBoxButton.OK);
            }
        }

        private void ReadDataPicker()
        {
            App.patient.resultLocus.arrayAnswerLocus[0] = pickerFirstQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[1] = pickerSecondQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[2] = pickerThirdQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[3] = pickerFourthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[4] = pickerFifthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[5] = pickerSixthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[6] = pickerSeventhQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[7] = pickerEighthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[8] = pickerNinthQuestion.SelectedIndex;
        }


        /// <summary>
        /// Сброс ответов теста
        /// </summary>
        private void ResetAnswersInTest()
        {
            pickerFirstQuestion.SelectedIndex = -1;
            pickerSecondQuestion.SelectedIndex = -1;
            pickerThirdQuestion.SelectedIndex = -1;
            pickerFourthQuestion.SelectedIndex = -1;
            pickerFifthQuestion.SelectedIndex = -1;
            pickerSixthQuestion.SelectedIndex = -1;
            pickerSeventhQuestion.SelectedIndex = -1;
            pickerEighthQuestion.SelectedIndex = -1;
            pickerNinthQuestion.SelectedIndex = -1;
        }


        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 9; i++)
            {
                if (App.patient.resultLocus.arrayAnswerLocus[i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Определение количества баллов за тест
        /// </summary>
        private void CalculateResult()
        {
            for (int i = 0; i < 5; i++)
            {
                testResult += (4 - App.patient.resultLocus.arrayAnswerLocus[i]);
            }
            for (int i = 5; i < 9; i++)
            {
                testResult += App.patient.resultLocus.arrayAnswerLocus[i];
            }

            App.patient.resultLocus.TotalResultLocus = testResult;
        }
    }
}
