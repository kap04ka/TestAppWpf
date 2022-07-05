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
    /// Логика взаимодействия для TestAsthenia.xaml
    /// </summary>
    public partial class TestAsthenia : Page
    {
        private int[] arrayAnswerMFI;

        public TestAsthenia()
        {
            arrayAnswerMFI = new int[20];
            ResetArray();
            InitializeComponent();
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void button_CalculateResult(object sender, EventArgs e)
        {
            CorrectionScore();
            CalculateScore();

            if (App.patient.scoreMFI20.TotalTestScore <= 30)
            {
                MessageBox.Show($"Количество баллов = {App.patient.scoreMFI20.TotalTestScore}\n" +
                    "Балл в норме", "Результат", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show($"Количество баллов = {App.patient.scoreMFI20.TotalTestScore}\n" +
                    "Балл выше нормы", "Результат", MessageBoxButton.OK);
            }

            CorrectionScore();
            ResetAnswersTest();
            NavigationService.Navigate(new Menu());
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender == sliderFirstAnswer)
            {
                labelFirstAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[0] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSecondAnswer)
            {
                labelSecondAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[1] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderThirdAnswer)
            {
                labelThirdAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[2] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFourthAnswer)
            {
                labelFourthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[3] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFifthAnswer)
            {
                labelFifthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[4] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSixthAnswer)
            {
                labelSixthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[5] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSeventhAnswer)
            {
                labelSeventhAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[6] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEighthAnswer)
            {
                labelEighthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[7] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderNinthAnswer)
            {
                labelNinthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[8] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTenthAnswer)
            {
                labelTenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[9] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEleventhAnswer)
            {
                labelEleventhAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[10] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTwelfthAnswer)
            {
                labelTwelfthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[11] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderThirteenAnswer)
            {
                labelThirteenAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[12] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFourteenthAnswer)
            {
                labelFourteenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[13] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFifteenthAnswer)
            {
                labelFifteenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[14] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSixteenthAnswer)
            {
                labelSixteenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[15] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSeventeenthAnswer)
            {
                labelSeventeenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[16] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEighteenthAnswer)
            {
                labelEighteenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[17] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderNineteenthAnswer)
            {
                labelNineteenthAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[18] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTwentiethAnswer)
            {
                labelTwentiethAnswer.Content = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[19] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
        }


        /// <summary>
        /// Корректировка баллов в соостветствие с таблицей
        /// </summary>
        private void CorrectionScore()
        {
            arrayAnswerMFI[1] = 6 - arrayAnswerMFI[1];
            arrayAnswerMFI[4] = 6 - arrayAnswerMFI[4];
            arrayAnswerMFI[8] = 6 - arrayAnswerMFI[8];
            arrayAnswerMFI[9] = 6 - arrayAnswerMFI[9];
            arrayAnswerMFI[12] = 6 - arrayAnswerMFI[12];
            arrayAnswerMFI[13] = 6 - arrayAnswerMFI[13];
            for (int i = 15; i < 19; i++)
            {
                arrayAnswerMFI[i] = 6 - arrayAnswerMFI[i];
            }
        }


        /// <summary>
        /// Расчет баллов
        /// </summary>
        private void CalculateScore()
        {
            App.patient.scoreMFI20.ScoreAnswerGeneralAsthenia =
                arrayAnswerMFI[0] + arrayAnswerMFI[4] + arrayAnswerMFI[11] + arrayAnswerMFI[15];
            App.patient.scoreMFI20.ScoreAnswerReducedActivity =
                arrayAnswerMFI[2] + arrayAnswerMFI[5] + arrayAnswerMFI[9] + arrayAnswerMFI[16];
            App.patient.scoreMFI20.ScoreAnswerDecreasedMotivation =
                arrayAnswerMFI[3] + arrayAnswerMFI[8] + arrayAnswerMFI[14] + arrayAnswerMFI[17];
            App.patient.scoreMFI20.ScoreAnswerPhysicalAsthenia =
                arrayAnswerMFI[1] + arrayAnswerMFI[7] + arrayAnswerMFI[13] + arrayAnswerMFI[19];
            App.patient.scoreMFI20.ScoreAnswerMentalAsthenia =
                arrayAnswerMFI[6] + arrayAnswerMFI[10] + arrayAnswerMFI[12] + arrayAnswerMFI[18];

            App.patient.scoreMFI20.TotalTestScore = App.patient.scoreMFI20.ScoreAnswerGeneralAsthenia +
                 App.patient.scoreMFI20.ScoreAnswerReducedActivity + App.patient.scoreMFI20.ScoreAnswerDecreasedMotivation +
                 App.patient.scoreMFI20.ScoreAnswerPhysicalAsthenia + App.patient.scoreMFI20.ScoreAnswerMentalAsthenia;
        }

        /// <summary>
        /// Сброс ответов теста
        /// </summary>
        private void ResetAnswersTest()
        {
            sliderFirstAnswer.Value = 0.5;
            sliderSecondAnswer.Value = 0.5;
            sliderThirdAnswer.Value = 0.5;
            sliderFourthAnswer.Value = 0.5;
            sliderFifthAnswer.Value = 0.5;
            sliderSixthAnswer.Value = 0.5;
            sliderSeventhAnswer.Value = 0.5;
            sliderEighthAnswer.Value = 0.5;
            sliderNinthAnswer.Value = 0.5;
            sliderTenthAnswer.Value = 0.5;
            sliderEleventhAnswer.Value = 0.5;
            sliderTwelfthAnswer.Value = 0.5;
            sliderThirteenAnswer.Value = 0.5;
            sliderFourteenthAnswer.Value = 0.5;
            sliderFifteenthAnswer.Value = 0.5;
            sliderSixteenthAnswer.Value = 0.5;
            sliderSeventeenthAnswer.Value = 0.5;
            sliderEighteenthAnswer.Value = 0.5;
            sliderNineteenthAnswer.Value = 0.5;
            sliderTwentiethAnswer.Value = 0.5;
        }


        /// <summary>
        /// Сброс значений массива
        /// </summary>
        private void ResetArray()
        {
            for (int i = 0; i < arrayAnswerMFI.Length; i++)
            {
                arrayAnswerMFI[i] = 1;
            }
        }
    }
}
