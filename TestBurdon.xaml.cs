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
    /// Логика взаимодействия для TestBurdon.xaml
    /// </summary>
    public partial class TestBurdon : Page
    {
        /// <summary>
        /// Количество просмотренных строк
        /// </summary>
        private int amountLines;
        /// <summary>
        /// Количество ошибок
        /// </summary>
        private int amountMistakes;
        /// <summary>
        /// Количество букв за минуту
        /// </summary>
        private int amountLettersInOneMinute;
        /// <summary>
        /// Количество букв за 2 минуты
        /// </summary>
        private int amountLettersInTwoMinutes;
        /// <summary>
        /// Количество букв за 3 минуты
        /// </summary>
        private int amountLettersInThreeMinutes;
        /// <summary>
        /// Количество букв за 4 минуты
        /// </summary>
        private int amountLettersInFourMinutes;
        /// <summary>
        /// Количество букв за 5 минут
        /// </summary>
        private int amountLettersInFiveMinutes;
        /// <summary>
        /// Максимальный темп выполнения
        /// </summary>
        private int maxPaceInTime;
        /// <summary>
        /// Минимальный темп выполнения
        /// </summary>
        private int minPaceInTime;

        public TestBurdon()
        {
            InitializeComponent();
        }
        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void button_CalculateResult(object sender, EventArgs e)
        {
            if (EmptyData())
            {
                MessageBox.Show("Введены не все данные", "Предупреждение", MessageBoxButton.OK);
            }

            else
            {
                ReadData();
                CalculateResult();
                MessageBox.Show(FormatOutputString(), "Результат", MessageBoxButton.OK);
                ResetValueTest();
                NavigationService.Navigate(new Menu());
            }
        }

        private bool EmptyData()
        {
            if (entryNumberOfLines.Text == "" || entryNumberOfMistakes.Text == "" || entryNumberOfLetters1.Text == "" ||
                entryNumberOfLetters2.Text == "" || entryNumberOfLetters3.Text == "" || entryNumberOfLetters4.Text == "" ||
                entryNumberOfLetters5.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Считывание данных из полей ввода
        /// </summary>
        private void ReadData()
        {
            amountLines = Int32.Parse(entryNumberOfLines.Text);
            amountMistakes = Int32.Parse(entryNumberOfMistakes.Text);
            amountLettersInOneMinute = Int32.Parse(entryNumberOfLetters1.Text);
            amountLettersInTwoMinutes = Int32.Parse(entryNumberOfLetters2.Text);
            amountLettersInTwoMinutes = Int32.Parse(entryNumberOfLetters2.Text);
            amountLettersInThreeMinutes = Int32.Parse(entryNumberOfLetters3.Text);
            amountLettersInFourMinutes = Int32.Parse(entryNumberOfLetters4.Text);
            amountLettersInFiveMinutes = Int32.Parse(entryNumberOfLetters5.Text);
        }


        /// <summary>
        /// Подсчет результатов
        /// </summary>
        private void CalculateResult()
        {
            if (amountMistakes == 0)
            {
                App.patient.scoreBourdon.ConcentrationOfAtention = 2 * amountLines;
            }
            else
            {
                App.patient.scoreBourdon.ConcentrationOfAtention = (int)Math.Round(2.0 * amountLines / amountMistakes, 0);
            }

            App.patient.scoreBourdon.PaceArray[0] = (int)Math.Round(amountLettersInOneMinute / 1.0, 0);
            App.patient.scoreBourdon.PaceArray[1] = (int)Math.Round(amountLettersInTwoMinutes / 2.0, 0);
            App.patient.scoreBourdon.PaceArray[2] = (int)Math.Round(amountLettersInThreeMinutes / 3.0, 0);
            App.patient.scoreBourdon.PaceArray[3] = (int)Math.Round(amountLettersInFourMinutes / 4.0, 0);
            App.patient.scoreBourdon.PaceArray[4] = (int)Math.Round(amountLettersInFiveMinutes / 5.0, 0);

            App.patient.scoreBourdon.PaceString =
                App.patient.scoreBourdon.PaceArray[0].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[1].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[2].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[3].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[4].ToString();

            maxPaceInTime = App.patient.scoreBourdon.PaceArray.Max();
            minPaceInTime = App.patient.scoreBourdon.PaceArray.Min();
            App.patient.scoreBourdon.AttentionSpan = maxPaceInTime - minPaceInTime;
        }


        /// <summary>
        /// Форматированная строка вывода
        /// </summary>
        private string FormatOutputString()
        {
            string lineOne;
            string lineTwo;
            lineOne = "Концентрация внимания = " + App.patient.scoreBourdon.ConcentrationOfAtention.ToString() + "\n";
            lineTwo = "Устойчивость внимания = " + App.patient.scoreBourdon.AttentionSpan.ToString();
            switch (App.patient.scoreBourdon.AttentionSpan)
            {
                case 0:
                case 1:
                case 2:
                    lineTwo += " - очень высокая";
                    break;
                case 3:
                case 4:
                    lineTwo += " - высокая";
                    break;
                case 5:
                case 6:
                    lineTwo += " - средняя";
                    break;
                case 7:
                case 8:
                    lineTwo += " - низкая";
                    break;
                case 9:
                case 10:
                    lineTwo += " - очень низкая";
                    break;
            }

            return lineOne + lineTwo;
        }

        /// <summary>
        /// Сброс полей для ввода данных
        /// </summary>
        private void ResetValueTest()
        {
            entryNumberOfLines.Text = null;
            entryNumberOfMistakes.Text = null;
            entryNumberOfLetters1.Text = null;
            entryNumberOfLetters2.Text = null;
            entryNumberOfLetters3.Text = null;
            entryNumberOfLetters4.Text = null;
            entryNumberOfLetters5.Text = null;
        }

        private void textbox_onlyNumbers(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ".")
               && (!e.Text.Contains(".")
               && e.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
    }

}
