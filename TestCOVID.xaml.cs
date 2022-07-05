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
            if (sender == checkBoxDiseases1)
            {
                answerDiseases[0] = (bool)checkBoxDiseases1.IsChecked;

                if (answerDiseases[0] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases2)
            {
                answerDiseases[1] = (bool)checkBoxDiseases2.IsChecked;

                if (answerDiseases[1] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases3)
            {
                answerDiseases[2] = (bool)checkBoxDiseases3.IsChecked;

                if (answerDiseases[2] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases4)
            {
                answerDiseases[3] = (bool)checkBoxDiseases4.IsChecked;

                if (answerDiseases[3] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases5)
            {
                answerDiseases[4] = (bool)checkBoxDiseases5.IsChecked;

                if (answerDiseases[4] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases6)
            {
                answerDiseases[5] = (bool)checkBoxDiseases6.IsChecked;

                if (answerDiseases[5] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases7)
            {
                answerDiseases[6] = (bool)checkBoxDiseases7.IsChecked;

                if (answerDiseases[6] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases8)
            {
                answerDiseases[7] = (bool)checkBoxDiseases8.IsChecked;

                if (answerDiseases[7] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases9)
            {
                answerDiseases[8] = (bool)checkBoxDiseases9.IsChecked;

                if (answerDiseases[8] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases10)
            {
                answerDiseases[9] = (bool)checkBoxDiseases10.IsChecked;

                if (answerDiseases[9] == true)
                {
                    ResetOthersCheckBoxAnswers(answerDiseases, 9);
                    checkBoxDiseases1.IsChecked = false;
                    checkBoxDiseases2.IsChecked = false;
                    checkBoxDiseases3.IsChecked = false;
                    checkBoxDiseases4.IsChecked = false;
                    checkBoxDiseases5.IsChecked = false;
                    checkBoxDiseases6.IsChecked = false;
                    checkBoxDiseases7.IsChecked = false;
                    checkBoxDiseases8.IsChecked = false;
                    checkBoxDiseases9.IsChecked = false;
                }
            }
        }

        /// <summary>
        /// Сброс check box в исходное состояние
        /// </summary>
        /// <param name="arrayCheckBoxAnswers">Массив ответов на вопрос</param>
        /// <param name="index">Индекс ответа, который необходимо пропустить</param>
        private void ResetOthersCheckBoxAnswers(bool[] arrayCheckBoxAnswers, int index)
        {
            for (int i = 0; i < arrayCheckBoxAnswers.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                arrayCheckBoxAnswers[i] = false;
            }
        }

        private void checkBoxDiseases_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == checkBoxDiseases1)
            {
                answerDiseases[0] = (bool)checkBoxDiseases1.IsChecked;

                if (answerDiseases[0] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases2)
            {
                answerDiseases[1] = (bool)checkBoxDiseases2.IsChecked;

                if (answerDiseases[1] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases3)
            {
                answerDiseases[2] = (bool)checkBoxDiseases3.IsChecked;

                if (answerDiseases[2] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases4)
            {
                answerDiseases[3] = (bool)checkBoxDiseases4.IsChecked;

                if (answerDiseases[3] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases5)
            {
                answerDiseases[4] = (bool)checkBoxDiseases5.IsChecked;

                if (answerDiseases[4] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases6)
            {
                answerDiseases[5] = (bool)checkBoxDiseases6.IsChecked;

                if (answerDiseases[5] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases7)
            {
                answerDiseases[6] = (bool)checkBoxDiseases7.IsChecked;

                if (answerDiseases[6] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases8)
            {
                answerDiseases[7] = (bool)checkBoxDiseases8.IsChecked;

                if (answerDiseases[7] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases9)
            {
                answerDiseases[8] = (bool)checkBoxDiseases9.IsChecked;

                if (answerDiseases[8] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases10)
            {
                answerDiseases[9] = (bool)checkBoxDiseases10.IsChecked;

                if (answerDiseases[9] == true)
                {
                    ResetOthersCheckBoxAnswers(answerDiseases, 9);
                    checkBoxDiseases1.IsChecked = false;
                    checkBoxDiseases2.IsChecked = false;
                    checkBoxDiseases3.IsChecked = false;
                    checkBoxDiseases4.IsChecked = false;
                    checkBoxDiseases5.IsChecked = false;
                    checkBoxDiseases6.IsChecked = false;
                    checkBoxDiseases7.IsChecked = false;
                    checkBoxDiseases8.IsChecked = false;
                    checkBoxDiseases9.IsChecked = false;
                }
            }
        }

        private void checkBoxActivity_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == checkBoxActivity1)
            {
                answerActivity[0] = (bool)checkBoxActivity1.IsChecked;
            }
            if (sender == checkBoxActivity2)
            {
                answerActivity[1] = (bool)checkBoxActivity2.IsChecked;
            }
            if (sender == checkBoxActivity3)
            {
                answerActivity[2] = (bool)checkBoxActivity3.IsChecked;
            }
            if (sender == checkBoxActivity4)
            {
                answerActivity[3] = (bool)checkBoxActivity4.IsChecked;
            }
            if (sender == checkBoxActivity5)
            {
                answerActivity[4] = (bool)checkBoxActivity5.IsChecked;
            }
            if (sender == checkBoxActivity6)
            {
                answerActivity[5] = (bool)checkBoxActivity6.IsChecked;
            }
        }

        private void checkBoxActivity_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == checkBoxActivity1)
            {
                answerActivity[0] = (bool)checkBoxActivity1.IsChecked;
            }
            if (sender == checkBoxActivity2)
            {
                answerActivity[1] = (bool)checkBoxActivity2.IsChecked;
            }
            if (sender == checkBoxActivity3)
            {
                answerActivity[2] = (bool)checkBoxActivity3.IsChecked;
            }
            if (sender == checkBoxActivity4)
            {
                answerActivity[3] = (bool)checkBoxActivity4.IsChecked;
            }
            if (sender == checkBoxActivity5)
            {
                answerActivity[4] = (bool)checkBoxActivity5.IsChecked;
            }
            if (sender == checkBoxActivity6)
            {
                answerActivity[5] = (bool)checkBoxActivity6.IsChecked;
            }
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


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кратковременная потеря памяти
        /// </summary>
        private void editorShortTermMemoryLoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorShortTermMemoryLoss1)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[0] = editorShortTermMemoryLoss1.Text;
            }
            if (sender == editorShortTermMemoryLoss2)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[1] = editorShortTermMemoryLoss2.Text;
            }
            if (sender == editorShortTermMemoryLoss3)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[2] = editorShortTermMemoryLoss3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Снижение памяти
        /// </summary>
        private void editorDecreasedMemory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDecreasedMemory1)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[0] = editorDecreasedMemory1.Text;
            }
            if (sender == editorDecreasedMemory2)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[1] = editorDecreasedMemory2.Text;
            }
            if (sender == editorDecreasedMemory3)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[2] = editorDecreasedMemory3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Снижение концентрации внимания, "туман в мозгу"
        /// </summary>
        private void editorDecreasedConcentration_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDecreasedConcentration1)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[0] = editorDecreasedConcentration1.Text;
            }
            if (sender == editorDecreasedConcentration2)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[1] = editorDecreasedConcentration2.Text;
            }
            if (sender == editorDecreasedConcentration3)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[2] = editorDecreasedConcentration3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Повышенная утомляемость
        /// </summary>
        private void editorFatigue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFatigue1)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[0] = editorFatigue1.Text;
            }
            if (sender == editorFatigue2)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[1] = editorFatigue2.Text;
            }
            if (sender == editorFatigue3)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[2] = editorFatigue3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Спутанность сознания
        /// </summary>
        private void editorConfusion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorConfusion1)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[0] = editorConfusion1.Text;
            }
            if (sender == editorConfusion2)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[1] = editorConfusion2.Text;
            }
            if (sender == editorConfusion3)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[2] = editorConfusion3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение сна (патологическое бодрствование, бессонница)
        /// </summary>
        private void editorSleepDisturbance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSleepDisturbance1)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[0] = editorSleepDisturbance1.Text;
            }
            if (sender == editorSleepDisturbance2)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[1] = editorSleepDisturbance2.Text;
            }
            if (sender == editorSleepDisturbance3)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[2] = editorSleepDisturbance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Проблемы с речью (подбор слов или произношение) 
        /// </summary>
        private void editorSpeechProblems_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSpeechProblems1)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[0] = editorSpeechProblems1.Text;
            }
            if (sender == editorSpeechProblems2)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[1] = editorSpeechProblems2.Text;
            }
            if (sender == editorSpeechProblems3)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[2] = editorSpeechProblems3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение характера
        /// </summary>
        private void editorChangeOfCharacter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorChangeOfCharacter1)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[0] = editorChangeOfCharacter1.Text;
            }
            if (sender == editorChangeOfCharacter2)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[1] = editorChangeOfCharacter2.Text;
            }
            if (sender == editorChangeOfCharacter3)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[2] = editorChangeOfCharacter3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение частоты
        /// </summary>
        private void editorFrequencyChange_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFrequencyChange1)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[0] = editorFrequencyChange1.Text;
            }
            if (sender == editorFrequencyChange2)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[1] = editorFrequencyChange2.Text;
            }
            if (sender == editorFrequencyChange3)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[2] = editorFrequencyChange3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение интенсивности
        /// </summary>
        private void editorIntensityChange_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorIntensityChange1)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[0] = editorIntensityChange1.Text;
            }
            if (sender == editorIntensityChange2)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[1] = editorIntensityChange2.Text;
            }
            if (sender == editorIntensityChange3)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[2] = editorIntensityChange3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Перепады настроения
        /// </summary>
        private void editorMoodSwings_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorMoodSwings1)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[0] = editorMoodSwings1.Text;
            }
            if (sender == editorMoodSwings2)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[1] = editorMoodSwings2.Text;
            }
            if (sender == editorMoodSwings3)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[2] = editorMoodSwings3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Тревога
        /// </summary>
        private void editorAnxiety_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAnxiety1)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[0] = editorAnxiety1.Text;
            }
            if (sender == editorAnxiety2)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[1] = editorAnxiety2.Text;
            }
            if (sender == editorAnxiety3)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[2] = editorAnxiety3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Депрессия
        /// </summary>
        private void editorDepression_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDepression1)
            {
                App.patient.resultCovidTest.TableEntriesDepression[0] = editorDepression1.Text;
            }
            if (sender == editorDepression2)
            {
                App.patient.resultCovidTest.TableEntriesDepression[1] = editorDepression2.Text;
            }
            if (sender == editorDepression3)
            {
                App.patient.resultCovidTest.TableEntriesDepression[2] = editorDepression3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Навязчивые состояния
        /// </summary>
        private void editorObsessiveStates_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorObsessiveStates1)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[0] = editorObsessiveStates1.Text;
            }
            if (sender == editorObsessiveStates2)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[1] = editorObsessiveStates2.Text;
            }
            if (sender == editorObsessiveStates3)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[2] = editorObsessiveStates3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Лихорадка
        /// </summary>
        private void editorFever_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFever1)
            {
                App.patient.resultCovidTest.TableEntriesFever[0] = editorFever1.Text;
            }
            if (sender == editorFever2)
            {
                App.patient.resultCovidTest.TableEntriesFever[1] = editorFever2.Text;
            }
            if (sender == editorFever3)
            {
                App.patient.resultCovidTest.TableEntriesFever[2] = editorFever3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Повышенное потоотделение
        /// </summary>
        private void editorIncreasedSweating_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorIncreasedSweating1)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[0] = editorIncreasedSweating1.Text;
            }
            if (sender == editorIncreasedSweating2)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[1] = editorIncreasedSweating2.Text;
            }
            if (sender == editorIncreasedSweating3)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[2] = editorIncreasedSweating3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Ночная потливость
        /// </summary>
        private void editorNightSweats_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNightSweats1)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[0] = editorNightSweats1.Text;
            }
            if (sender == editorNightSweats2)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[1] = editorNightSweats2.Text;
            }
            if (sender == editorNightSweats3)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[2] = editorNightSweats3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Непереносимость тепла
        /// </summary>
        private void editorHeatIntolerance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHeatIntolerance1)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[0] = editorHeatIntolerance1.Text;
            }
            if (sender == editorHeatIntolerance2)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[1] = editorHeatIntolerance2.Text;
            }
            if (sender == editorHeatIntolerance3)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[2] = editorHeatIntolerance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Брадикардия
        /// </summary>
        private void editorBradycardia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorBradycardia1)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[0] = editorBradycardia1.Text;
            }
            if (sender == editorBradycardia2)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[1] = editorBradycardia2.Text;
            }
            if (sender == editorBradycardia3)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[2] = editorBradycardia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Тахикардия
        /// </summary>
        private void editorTachycardia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorTachycardia1)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[0] = editorTachycardia1.Text;
            }
            if (sender == editorTachycardia2)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[1] = editorTachycardia2.Text;
            }
            if (sender == editorTachycardia3)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[2] = editorTachycardia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Сердцебиение
        /// </summary>
        private void editorHeartbeat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHeartbeat1)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[0] = editorHeartbeat1.Text;
            }
            if (sender == editorHeartbeat2)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[1] = editorHeartbeat2.Text;
            }
            if (sender == editorHeartbeat3)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[2] = editorHeartbeat3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Подъемы АД
        /// </summary>
        private void editorBPRises_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorBPRises1)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[0] = editorBPRises1.Text;
            }
            if (sender == editorBPRises2)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[1] = editorBPRises2.Text;
            }
            if (sender == editorBPRises3)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[2] = editorBPRises3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Понижение АД
        /// </summary>
        private void editorLoweringBloodPressure_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorLoweringBloodPressure1)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[0] = editorLoweringBloodPressure1.Text;
            }
            if (sender == editorLoweringBloodPressure2)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[1] = editorLoweringBloodPressure2.Text;
            }
            if (sender == editorLoweringBloodPressure3)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[2] = editorLoweringBloodPressure3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Обморок
        /// </summary>
        private void editorFainting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFainting1)
            {
                App.patient.resultCovidTest.TableEntriesFainting[0] = editorFainting1.Text;
            }
            if (sender == editorFainting2)
            {
                App.patient.resultCovidTest.TableEntriesFainting[1] = editorFainting2.Text;
            }
            if (sender == editorFainting3)
            {
                App.patient.resultCovidTest.TableEntriesFainting[2] = editorFainting3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в мышцах 
        /// </summary>
        private void editorMusclePain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorMusclePain1)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[0] = editorMusclePain1.Text;
            }
            if (sender == editorMusclePain2)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[1] = editorMusclePain2.Text;
            }
            if (sender == editorMusclePain3)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[2] = editorMusclePain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в суставах
        /// </summary>
        private void editorJointPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorJointPain1)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[0] = editorJointPain1.Text;
            }
            if (sender == editorJointPain2)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[1] = editorJointPain2.Text;
            }
            if (sender == editorJointPain3)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[2] = editorJointPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Головокружение
        /// </summary>
        private void editorDizziness_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDizziness1)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[0] = editorDizziness1.Text;
            }
            if (sender == editorDizziness2)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[1] = editorDizziness2.Text;
            }
            if (sender == editorDizziness3)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[2] = editorDizziness3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение равновесия
        /// </summary>
        private void editorImbalance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorImbalance1)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[0] = editorImbalance1.Text;
            }
            if (sender == editorImbalance2)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[1] = editorImbalance2.Text;
            }
            if (sender == editorImbalance3)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[2] = editorImbalance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение зрения
        /// </summary>
        private void editorVisualImpairment_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorVisualImpairment1)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[0] = editorVisualImpairment1.Text;
            }
            if (sender == editorVisualImpairment2)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[1] = editorVisualImpairment2.Text;
            }
            if (sender == editorVisualImpairment3)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[2] = editorVisualImpairment3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кожная гиперестезия
        /// </summary>
        private void editorSkinHyperesthesia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSkinHyperesthesia1)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[0] = editorSkinHyperesthesia1.Text;
            }
            if (sender == editorSkinHyperesthesia2)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[1] = editorSkinHyperesthesia2.Text;
            }
            if (sender == editorSkinHyperesthesia3)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[2] = editorSkinHyperesthesia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в конечностях
        /// </summary>
        private void editorPainInTheLimbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorPainInTheLimbs1)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[0] = editorPainInTheLimbs1.Text;
            }
            if (sender == editorPainInTheLimbs2)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[1] = editorPainInTheLimbs2.Text;
            }
            if (sender == editorPainInTheLimbs3)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[2] = editorPainInTheLimbs3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Онемение в конечностях
        /// </summary>
        private void editorNumbnessInTheLimbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNumbnessInTheLimbs1)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[0] = editorNumbnessInTheLimbs1.Text;
            }
            if (sender == editorNumbnessInTheLimbs2)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[1] = editorNumbnessInTheLimbs2.Text;
            }
            if (sender == editorNumbnessInTheLimbs3)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[2] = editorNumbnessInTheLimbs3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Парестезии
        /// </summary>
        private void editorParesthesia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorParesthesia1)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[0] = editorParesthesia1.Text;
            }
            if (sender == editorParesthesia2)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[1] = editorParesthesia2.Text;
            }
            if (sender == editorParesthesia3)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[2] = editorParesthesia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушения вкуса (агевзия, снижение вкуса, искажение вкуса)
        /// </summary>
        private void editorTasteDisorders_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorTasteDisorders1)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[0] = editorTasteDisorders1.Text;
            }
            if (sender == editorTasteDisorders2)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[1] = editorTasteDisorders2.Text;
            }
            if (sender == editorTasteDisorders3)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[2] = editorTasteDisorders3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушения обоняния (аносмия, фантомия, паросмия)
        /// </summary>
        private void editorOlfactoryDisorders_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorOlfactoryDisorders1)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[0] = editorOlfactoryDisorders1.Text;
            }
            if (sender == editorOlfactoryDisorders2)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[1] = editorOlfactoryDisorders2.Text;
            }
            if (sender == editorOlfactoryDisorders3)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[2] = editorOlfactoryDisorders3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - кашель
        /// </summary>
        private void editorCough_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorCough1)
            {
                App.patient.resultCovidTest.TableEntriesCough[0] = editorCough1.Text;
            }
            if (sender == editorCough2)
            {
                App.patient.resultCovidTest.TableEntriesCough[1] = editorCough2.Text;
            }
            if (sender == editorCough3)
            {
                App.patient.resultCovidTest.TableEntriesCough[2] = editorCough3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Одышка
        /// </summary>
        private void editorDyspnea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDyspnea1)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[0] = editorDyspnea1.Text;
            }
            if (sender == editorDyspnea2)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[1] = editorDyspnea2.Text;
            }
            if (sender == editorDyspnea3)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[2] = editorDyspnea3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Стеснение в груди, боль в груди
        /// </summary>
        private void editorChestPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorChestPain1)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[0] = editorChestPain1.Text;
            }
            if (sender == editorChestPain2)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[1] = editorChestPain2.Text;
            }
            if (sender == editorChestPain3)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[2] = editorChestPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Учащенное сердцебиение
        /// </summary>
        private void editorCardiopalmus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorCardiopalmus1)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[0] = editorCardiopalmus1.Text;
            }
            if (sender == editorCardiopalmus2)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[1] = editorCardiopalmus2.Text;
            }
            if (sender == editorCardiopalmus3)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[2] = editorCardiopalmus3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Анорексия, снижение аппетита
        /// </summary>
        private void editorAnorexia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAnorexia1)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[0] = editorAnorexia1.Text;
            }
            if (sender == editorAnorexia2)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[1] = editorAnorexia2.Text;
            }
            if (sender == editorAnorexia3)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[2] = editorAnorexia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Судороги
        /// </summary>
        private void editorConvulsions_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorConvulsions1)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[0] = editorConvulsions1.Text;
            }
            if (sender == editorConvulsions2)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[1] = editorConvulsions2.Text;
            }
            if (sender == editorConvulsions3)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[2] = editorConvulsions3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - боль в горле
        /// </summary>
        private void editorSoreThroat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSoreThroat1)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[0] = editorSoreThroat1.Text;
            }
            if (sender == editorSoreThroat2)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[1] = editorSoreThroat2.Text;
            }
            if (sender == editorSoreThroat3)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[2] = editorSoreThroat3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Шум в ушах
        /// </summary>
        private void editorNoiseInEars_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNoiseInEars1)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[0] = editorNoiseInEars1.Text;
            }
            if (sender == editorNoiseInEars2)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[1] = editorNoiseInEars2.Text;
            }
            if (sender == editorNoiseInEars3)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[2] = editorNoiseInEars3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Ушная боль
        /// </summary>
        private void editorEarAche_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorEarAche1)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[0] = editorEarAche1.Text;
            }
            if (sender == editorEarAche2)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[1] = editorEarAche2.Text;
            }
            if (sender == editorEarAche3)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[2] = editorEarAche3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - заложенность носа
        /// </summary>
        private void editorNasalCongestion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNasalCongestion1)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[0] = editorNasalCongestion1.Text;
            }
            if (sender == editorNasalCongestion2)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[1] = editorNasalCongestion2.Text;
            }
            if (sender == editorNasalCongestion3)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[2] = editorNasalCongestion3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль и сухость носа (Синдром сухого носа)
        /// </summary>
        private void editorPainAndDrynessOfTheNose_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorPainAndDrynessOfTheNose1)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[0] = editorPainAndDrynessOfTheNose1.Text;
            }
            if (sender == editorPainAndDrynessOfTheNose2)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[1] = editorPainAndDrynessOfTheNose2.Text;
            }
            if (sender == editorPainAndDrynessOfTheNose3)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[2] = editorPainAndDrynessOfTheNose3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в животе
        /// </summary>
        private void editorAbdominalPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAbdominalPain1)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[0] = editorAbdominalPain1.Text;
            }
            if (sender == editorAbdominalPain2)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[1] = editorAbdominalPain2.Text;
            }
            if (sender == editorAbdominalPain3)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[2] = editorAbdominalPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Диарея
        /// </summary>
        private void editorDiarrhea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDiarrhea1)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[0] = editorDiarrhea1.Text;
            }
            if (sender == editorDiarrhea2)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[1] = editorDiarrhea2.Text;
            }
            if (sender == editorDiarrhea3)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[2] = editorDiarrhea3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - тошнота и рвота
        /// </summary>
        private void editorNauseaAndVomiting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNauseaAndVomiting1)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[0] = editorNauseaAndVomiting1.Text;
            }
            if (sender == editorNauseaAndVomiting2)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[1] = editorNauseaAndVomiting2.Text;
            }
            if (sender == editorNauseaAndVomiting3)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[2] = editorNauseaAndVomiting3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - выпадение волос
        /// </summary>
        private void editorHairLoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHairLoss1)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[0] = editorHairLoss1.Text;
            }
            if (sender == editorHairLoss2)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[1] = editorHairLoss2.Text;
            }
            if (sender == editorHairLoss3)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[2] = editorHairLoss3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кожные высыпания
        /// </summary>
        private void editorSkinRashes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSkinRashes1)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[0] = editorSkinRashes1.Text;
            }
            if (sender == editorSkinRashes2)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[1] = editorSkinRashes2.Text;
            }
            if (sender == editorSkinRashes3)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[2] = editorSkinRashes3.Text;
            }
        }

    }
}