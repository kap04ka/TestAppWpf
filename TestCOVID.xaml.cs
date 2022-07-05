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
        /// <summary>
        /// Ответы пациента на пол
        /// </summary>
        private bool[] answerGender;
        /// <summary>
        /// Ответы пациента на образование
        /// </summary>
        private bool[] answerEducation;
        /// <summary>
        /// Ответы пациента на деятельность
        /// </summary>
        private bool[] answerActivity;
        /// <summary>
        /// Ответы пациента на заболевания
        /// </summary>
        private bool[] answerDiseases;
        /// <summary>
        /// Ответы пациента на трудоспособность
        /// </summary>
        private bool[] answerAbilityToWork;
        /// <summary>
        /// Ответы пациента на работоспособность по дому
        /// </summary>
        private bool[] answerWorkAtHome;
        /// <summary>
        /// Ответы пациента на работоспособность по досуговой активности
        /// </summary>
        private bool[] answerLeisureActivities;

        /// <summary>
        /// Список вариатов для ответа на пол
        /// </summary>
        private List<string> answerTestGender;
        /// <summary>
        /// Список вариатов для ответа на образование
        /// </summary>
        private List<string> answerTestEducation;
        /// <summary>
        /// Список вариатов для ответа на деятельность
        /// </summary>
        private List<string> answerTestActivity;
        /// <summary>
        /// Список вариатов для ответа на заболевания
        /// </summary>
        private List<string> answerTestDiseases;
        /// <summary>
        /// Список вариатов для ответа на трудоспособность
        /// </summary>
        private List<string> answerTestAbilityToWork;
        /// <summary>
        /// Список вариатов для ответа на работоспособность по дому
        /// </summary>
        private List<string> answerTestWorkAtHome;
        /// <summary>
        /// Список вариатов для ответа на досуговая активность
        /// </summary>
        private List<string> answerTestLeisureActivities;

        public TestCOVID()
        {
            InitializeComponent();

            answerGender = new bool[2];
            answerEducation = new bool[5];
            answerActivity = new bool[6];
            answerDiseases = new bool[10];
            answerAbilityToWork = new bool[3];
            answerWorkAtHome = new bool[3];
            answerLeisureActivities = new bool[3];

            answerTestGender = new List<string>() { "Мужской", "Женский" };
            answerTestEducation = new List<string>()
            {
                "Начальная школа", "Неполное среднее общее образование",
                "Полное среднее общее образование", "Среднее профессиональное образование",
                "Высшее образование"
            };
            answerTestActivity = new List<string>()
            {
                "Нетрудоспособен/нетрудоспособна (инвалидность)", "Домохозяин/домохозяйка",
                "На пенсии", "Студент/ студентка",
                "Не работаю/ ищу работу", "Работаю"
            };
            answerTestDiseases = new List<string>()
            {
                "Заболевания легких (например, астма, эмфизема или бронхит)", "Заболевания сердца",
                "Хронические заболевания почек", "Заболевания печени (например, гепатит)",
                "Диабет", "Высокое артериальное давление",
                "Нарушение ритма сердца (мерцательная аритмия)",
                "Проблемы с селезенкой (например, серповидно-клеточная болезнь или если вам удалили селезенку)",
                "Ослабленная иммунная система в результате заболевания, такого как ВИЧ или СПИД, или лекарств, таких как стероидные таблетки или химиотерапия",
                "Ни одно из вышеперечисленных"
            };
            answerTestAbilityToWork = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };
            answerTestWorkAtHome = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };
            answerTestLeisureActivities = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };

            FillingOutTheTest();
        }

        private void FillingOutTheTest()
        {
            radioButtonGender1.Content = answerTestGender[0];
            radioButtonGender2.Content = answerTestGender[1];

            radioButtonEducation1.Content = answerTestEducation[0];
            radioButtonEducation2.Content = answerTestEducation[1];
            radioButtonEducation3.Content = answerTestEducation[2];
            radioButtonEducation4.Content = answerTestEducation[3];
            radioButtonEducation5.Content = answerTestEducation[4];

            checkBoxActivity1.Content = answerTestActivity[0];
            checkBoxActivity2.Content = answerTestActivity[1];
            checkBoxActivity3.Content = answerTestActivity[2];
            checkBoxActivity4.Content = answerTestActivity[3];
            checkBoxActivity5.Content = answerTestActivity[4];
            checkBoxActivity6.Content = answerTestActivity[5];

            checkBoxDiseases1.Content = answerTestDiseases[0];
            checkBoxDiseases2.Content = answerTestDiseases[1];
            checkBoxDiseases3.Content = answerTestDiseases[2];
            checkBoxDiseases4.Content = answerTestDiseases[3];
            checkBoxDiseases5.Content = answerTestDiseases[4];
            checkBoxDiseases6.Content = answerTestDiseases[5];
            checkBoxDiseases7.Content = answerTestDiseases[6];
            checkBoxDiseases8.Content = answerTestDiseases[7];
            checkBoxDiseases9.Content = answerTestDiseases[8];
            checkBoxDiseases10.Content = answerTestDiseases[9];

            radioButtonAbilityToWork1.Content = answerTestAbilityToWork[0];
            radioButtonAbilityToWork2.Content = answerTestAbilityToWork[1];
            radioButtonAbilityToWork3.Content = answerTestAbilityToWork[2];

            radioButtonPerfomance1.Content = answerTestWorkAtHome[0];
            radioButtonPerfomance2.Content = answerTestWorkAtHome[1];
            radioButtonPerfomance3.Content = answerTestWorkAtHome[2];

            radioButtonLeisure1.Content = answerTestLeisureActivities[0];
            radioButtonLeisure2.Content = answerTestLeisureActivities[1];
            radioButtonLeisure3.Content = answerTestLeisureActivities[2];
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
            answerEducation[0] = (bool)radioButtonEducation1.IsChecked;
            answerEducation[1] = (bool)radioButtonEducation2.IsChecked;
            answerEducation[2] = (bool)radioButtonEducation3.IsChecked;
            answerEducation[3] = (bool)radioButtonEducation4.IsChecked;
            answerEducation[4] = (bool)radioButtonEducation5.IsChecked;
        }

        private void radioButtonAbilityToWork_Checked(object sender, RoutedEventArgs e)
        {
            answerAbilityToWork[0] = (bool)radioButtonAbilityToWork1.IsChecked;
            answerAbilityToWork[1] = (bool)radioButtonAbilityToWork2.IsChecked;
            answerAbilityToWork[2] = (bool)radioButtonAbilityToWork3.IsChecked;
        }

        private void radioButtonPerfomance_Checked(object sender, RoutedEventArgs e)
        {
            answerWorkAtHome[0] = (bool)radioButtonPerfomance1.IsChecked;
            answerWorkAtHome[1] = (bool)radioButtonPerfomance2.IsChecked;
            answerWorkAtHome[2] = (bool)radioButtonPerfomance3.IsChecked;
        }

        private void radioButtonLeisure_Checked(object sender, RoutedEventArgs e)
        {
            answerLeisureActivities[0] = (bool)radioButtonLeisure1.IsChecked;
            answerLeisureActivities[1] = (bool)radioButtonLeisure2.IsChecked;
            answerLeisureActivities[2] = (bool)radioButtonLeisure3.IsChecked;
        }

        private void slider_ValueChanged(object sender, RoutedEventArgs e)
        {
            if (sender == sliderAbilityToWork)
            {
                labelAbilityToWork.Content = String.Format("На {0:F0}",sliderAbilityToWork.Value);
                App.patient.resultCovidTest.WorkCapacityAssessment = int.Parse(String.Format("{0:F0}", sliderAbilityToWork.Value));
            }
            if (sender == sliderPerformance)
            {
                labelPerformance.Content = String.Format("На {0:F0}", sliderPerformance.Value);
                App.patient.resultCovidTest.PerformanceEvaluation = int.Parse(String.Format("{0:F0}", sliderPerformance.Value));
            }
            if (sender == sliderLeisure)
            {
                labelLeisure.Content = String.Format("На {0:F0}", sliderLeisure.Value);
                App.patient.resultCovidTest.LeisureEvaluation = int.Parse(String.Format("{0:F0}", sliderLeisure.Value));
            }
        }

        private void radioButtonGender_Checked(object sender, RoutedEventArgs e)
        {
            answerGender[0] = (bool)radioButtonGender1.IsChecked;
            answerGender[1] = (bool)radioButtonGender2.IsChecked;
        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            //пациент пропустил пункт
            if (CheckEmptyValue())
            {
                MessageBox.Show("Введите все требуемые данные", "Ошибка", MessageBoxButton.OK);
            }
            //пациент ввел все данные
            else
            {
                SaveData();
                MessageBox.Show("Данные теста сохранились", "Сохранение", MessageBoxButton.OK);
                NavigationService.Navigate(new Menu());
            }
        }

        private void SaveData()
        {
            App.patient.resultCovidTest.GenderPatient = SaveAnswer(answerGender, answerTestGender);
            App.patient.resultCovidTest.EducationPatient = SaveAnswer(answerEducation, answerTestEducation);
            App.patient.resultCovidTest.ActivityPatient = SaveAnswers(answerActivity, answerTestActivity);
            App.patient.resultCovidTest.DiseasesPatient = SaveAnswers(answerDiseases, answerTestDiseases);
            App.patient.resultCovidTest.AbilityToWorkPatient = SaveAnswer(answerAbilityToWork, answerTestAbilityToWork);
            App.patient.resultCovidTest.WorkAtHomePatient = SaveAnswer(answerWorkAtHome, answerTestWorkAtHome);
            App.patient.resultCovidTest.LeisureActivitiesPatient = SaveAnswer(answerLeisureActivities, answerTestLeisureActivities);
        }

        /// <summary>
        /// Сохранение ответа на вопрос в переменную
        /// </summary>
        /// <param name="arrayAnswers">Массив ответов на определенный вопрос</param>
        /// <param name="listChoiceAnswers">Список ответов на выбор</param>
        /// <returns>Строковое представление результата</returns>
        private string SaveAnswer(bool[] arrayAnswers, List<string> listChoiceAnswers)
        {
            string resultAnswer = "";

            for (int i = 0; i < arrayAnswers.Length; i++)
            {
                if (arrayAnswers[i] == true)
                {
                    resultAnswer = listChoiceAnswers[i];
                    break;
                }
            }

            return resultAnswer;
        }


        /// <summary>
        /// Сохранение ответов на вопрос в переменную
        /// </summary>
        /// <param name="arrayAnswers">Массив ответов на определенный вопрос</param>
        /// <param name="listChoiceAnswers">Список ответов на выбор</param>
        /// <returns>Строковое представление результата</returns>
        private string SaveAnswers(bool[] arrayAnswers, List<string> listChoiceAnswers)
        {
            int[] resultArray = arrayAnswers.
                Select((value, index) => new { Item = value, Index = index }).
                Where(n => n.Item == true).
                Select(n => n.Index).ToArray();

            string resultAnswers = "";

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i == resultArray.Length - 1)
                {
                    resultAnswers += listChoiceAnswers[resultArray[i]];
                }
                else
                {
                    resultAnswers += listChoiceAnswers[resultArray[i]];
                    resultAnswers += ", ";
                }
            }

            return resultAnswers;
        }

        private bool CheckEmptyValue()
        {
            if (answerGender[0] == false && answerGender[1] == false ||
                answerEducation[0] == false && answerEducation[1] == false && answerEducation[2] == false &&
                answerEducation[3] == false && answerEducation[4] == false ||
                answerActivity[0] == false && answerActivity[1] == false && answerActivity[2] == false &&
                answerActivity[3] == false && answerActivity[4] == false && answerActivity[5] == false ||
                answerDiseases[0] == false && answerDiseases[1] == false && answerDiseases[2] == false &&
                answerDiseases[3] == false && answerDiseases[4] == false && answerDiseases[5] == false &&
                answerDiseases[6] == false && answerDiseases[7] == false &&
                answerDiseases[8] == false && answerDiseases[9] == false ||
                answerAbilityToWork[0] == false && answerAbilityToWork[1] == false && answerAbilityToWork[2] == false ||
                answerWorkAtHome[0] == false && answerWorkAtHome[1] == false && answerWorkAtHome[2] == false ||
                answerLeisureActivities[0] == false && answerLeisureActivities[1] == false && answerLeisureActivities[2] == false ||
                App.patient.resultCovidTest.WorkCapacityAssessment == 0 ||
                App.patient.resultCovidTest.PerformanceEvaluation == 0 ||
                App.patient.resultCovidTest.LeisureEvaluation == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
