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
    /// Логика взаимодействия для TestAnxietyAndDepression.xaml
    /// </summary>
    public partial class TestAnxietyAndDepression : Page
    {
        int intermediateAnxietyResult = 0;
        int intermediateDepressionResult = 0;
        public TestAnxietyAndDepression()
        {
            InitializeComponent();
            Title = "Тест тревожности и депрессии";
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
        private  void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                var result = CalculateResult();
                MessageBox.Show($"{result.Item1} \n {result.Item2}", "Результат", MessageBoxButton.OK);


                ResetAnswersInTest();
                intermediateAnxietyResult = 0;
                intermediateDepressionResult = 0;
                NavigationService.Navigate(new Menu());
            }
            //пациент ответил не на все вопросы
            else
            {
                MessageBox.Show("Введены не все данные", "Предупреждение", MessageBoxButton.OK);
            }
        }

        private void ResetAnswersInTest()
        {
            firstQuestionAnxiety.SelectedIndex = -1;
            secondQuestionAnxiety.SelectedIndex = -1;
            thirdQuestionAnxiety.SelectedIndex = -1;
            fourthQuestionAnxiety.SelectedIndex = -1;
            fifthQuestionAnxiety.SelectedIndex = -1;
            sixthQuestionAnxiety.SelectedIndex = -1;
            seventhQuestionAnxiety.SelectedIndex = -1;

            firstQuestionDepression.SelectedIndex = -1;
            secondQuestionDepression.SelectedIndex = -1;
            thirdQuestionDepression.SelectedIndex = -1;
            fourthQuestionDepression.SelectedIndex = -1;
            fifthQuestionDepression.SelectedIndex = -1;
            sixthQuestionDepression.SelectedIndex = -1;
            seventhQuestionDepression.SelectedIndex = -1;
        }
        /// <summary>
        /// Считывание ответов из выпадающих списков
        /// </summary>
        private void ReadDataPicker()
        {
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[0] = firstQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[1] = secondQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[2] = thirdQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[3] = fourthQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[4] = fifthQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[5] = sixthQuestionAnxiety.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[6] = seventhQuestionAnxiety.SelectedIndex;

            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[0] = firstQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[1] = secondQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[2] = thirdQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[3] = fourthQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[4] = fifthQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[5] = sixthQuestionDepression.SelectedIndex;
            App.patient.resultAnxietyAndDepression.arrayAnswerDepression[6] = seventhQuestionDepression.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 7; i++)
            {
                if (App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[i] == -1 || App.patient.resultAnxietyAndDepression.arrayAnswerDepression[i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Определение количества баллов за тест
        /// </summary>
        private (string, string) CalculateResult()
        {
            string resultAnxiety;
            string resultDepression;

            for (int i = 0; i < 7; i++)
            {
                intermediateAnxietyResult += App.patient.resultAnxietyAndDepression.arrayAnswerAnxiety[i];
                intermediateDepressionResult += App.patient.resultAnxietyAndDepression.arrayAnswerDepression[i];
            }

            App.patient.resultAnxietyAndDepression.TotalResultAnxiety = intermediateAnxietyResult;
            App.patient.resultAnxietyAndDepression.TotalResultDepression = intermediateDepressionResult;

            resultAnxiety = GetOneResult(intermediateAnxietyResult) + "тревога";
            resultDepression = GetOneResult(intermediateDepressionResult) + "депрессия";

            return (resultAnxiety, resultDepression);

        }

        private string GetOneResult(int score)
        {
            if (score <= 7) return $"Ваш результат {score} - в норме по тесту ";
            else if (score > 7 && score <= 10) return $"Ваш результат {score} - субклинически выраженная ";
            else return $"Ваш результат {score} - клинически выраженная ";
        }
    }
}
