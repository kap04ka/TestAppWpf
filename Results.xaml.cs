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
    /// Логика взаимодействия для Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        public Results()
        {
            InitializeComponent();
            ShowResult(App.patient);
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void ShowResult(Patient patient)
        {
            Patient.Text = $"{patient.Forename} {patient.Surname} {patient.Patronymic}";
            CovidResult.Text = $"•	Неврологические жалобы:\n" +
                                $"Кратковременная потеря памяти\n1){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[0]}  2){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[1]}  3){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[2]}\n" +
                                $"Снижение памяти\n1){patient.resultCovidTest.TableEntriesDecreasedMemory[0]}  2){patient.resultCovidTest.TableEntriesDecreasedMemory[1]}  3){patient.resultCovidTest.TableEntriesDecreasedMemory[2]}\n" +
                                $"Снижение концентрации внимания, 'туман в мозгу'\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                $"Повышенная утомляемость\n1){patient.resultCovidTest.TableEntriesFatigue[0]}  2){patient.resultCovidTest.TableEntriesFatigue[1]}  3){patient.resultCovidTest.TableEntriesFatigue[2]}\n" +
                                $"Спутанность сознания\n1){patient.resultCovidTest.TableEntriesConfusion[0]}  2){patient.resultCovidTest.TableEntriesConfusion[1]}  3){patient.resultCovidTest.TableEntriesConfusion[2]}\n" +
                                $"Нарушение сна\n1){patient.resultCovidTest.TableEntriesSleepDisturbance[0]}  2){patient.resultCovidTest.TableEntriesSleepDisturbance[1]}  3){patient.resultCovidTest.TableEntriesSleepDisturbance[2]}\n" +
                                $"Проблемы с речью\n1){patient.resultCovidTest.TableEntriesSpeechProblems[0]}  2){patient.resultCovidTest.TableEntriesSpeechProblems[1]}  3){patient.resultCovidTest.TableEntriesSpeechProblems[2]}\n" +
                                $"•	Головная боль :\n" +
                                $"Изменение характера\n1){patient.resultCovidTest.TableEntriesChangeOfCharacter[0]}  2){patient.resultCovidTest.TableEntriesChangeOfCharacter[1]}  3){patient.resultCovidTest.TableEntriesChangeOfCharacter[2]}\n" +
                                $"Изменение частоты\n1){patient.resultCovidTest.TableEntriesFrequencyChange[0]}  2){patient.resultCovidTest.TableEntriesFrequencyChange[1]}  3){patient.resultCovidTest.TableEntriesFrequencyChange[2]}\n" +
                                $"Изменение интенсивности\n1){patient.resultCovidTest.TableEntriesIntensityChange[0]}  2){patient.resultCovidTest.TableEntriesIntensityChange[1]}  3){patient.resultCovidTest.TableEntriesIntensityChange[2]}\n" +
                                $"Перепады настроения\n1){patient.resultCovidTest.TableEntriesMoodSwings[0]}  2){patient.resultCovidTest.TableEntriesMoodSwings[1]}  3){patient.resultCovidTest.TableEntriesMoodSwings[2]}\n" +
                                $"•	Аффективные растройства:\n" +
                                $"Тревога\n1){patient.resultCovidTest.TableEntriesAnxiety[0]}  2){patient.resultCovidTest.TableEntriesAnxiety[1]}  3){patient.resultCovidTest.TableEntriesAnxiety[2]}\n" +
                                $"Депрессия\n1){patient.resultCovidTest.TableEntriesDepression[0]}  2){patient.resultCovidTest.TableEntriesDepression[1]}  3){patient.resultCovidTest.TableEntriesDepression[2]}\n" +
                                $"Навязчивые состояния\n1){patient.resultCovidTest.TableEntriesObsessiveStates[0]}  2){patient.resultCovidTest.TableEntriesObsessiveStates[1]} 3){patient.resultCovidTest.TableEntriesObsessiveStates[2]}\n" +
                                $"•	Системное проявление:\n" +
                                $"Лихорадка\n1){patient.resultCovidTest.TableEntriesFever[0]}  2){patient.resultCovidTest.TableEntriesFever[1]}  3){patient.resultCovidTest.TableEntriesFever[2]}\n" +
                                $"Повышенное потоотделение\n1){patient.resultCovidTest.TableEntriesIncreasedSweating[0]}  2){patient.resultCovidTest.TableEntriesIncreasedSweating[1]}  3){patient.resultCovidTest.TableEntriesIncreasedSweating[2]}\n" +
                                $"Ночная потливость\n1){patient.resultCovidTest.TableEntriesNightSweats[0]}  2){patient.resultCovidTest.TableEntriesNightSweats[1]}  3){patient.resultCovidTest.TableEntriesNightSweats[2]}\n" +
                                $"Непереносимость тепла\n1){patient.resultCovidTest.TableEntriesHeatIntolerance[0]}  2){patient.resultCovidTest.TableEntriesHeatIntolerance[1]}  3){patient.resultCovidTest.TableEntriesHeatIntolerance[2]}\n" +
                                $"•	Сердечно-сосудистая система:\n" +
                                $"Брадикардия\n1){patient.resultCovidTest.TableEntriesBradycardia[0]}  2){patient.resultCovidTest.TableEntriesBradycardia[1]}  3){patient.resultCovidTest.TableEntriesBradycardia[2]}\n" +
                                $"Тахикардия\n1){patient.resultCovidTest.TableEntriesTachycardia[0]}  2){patient.resultCovidTest.TableEntriesTachycardia[1]}  3){patient.resultCovidTest.TableEntriesTachycardia[2]}\n" +
                                $"Сердцебиение\n1){patient.resultCovidTest.TableEntriesHeartbeat[0]}  2){patient.resultCovidTest.TableEntriesHeartbeat[1]}  3){patient.resultCovidTest.TableEntriesHeartbeat[2]}\n" +
                                $"Подъемы АД\n1){patient.resultCovidTest.TableEntriesBPRises[0]}  2){patient.resultCovidTest.TableEntriesBPRises[1]}  3){patient.resultCovidTest.TableEntriesBPRises[2]}\n" +
                                $"Понижение АД\n1){patient.resultCovidTest.TableEntriesLoweringBloodPressure[0]}  2){patient.resultCovidTest.TableEntriesLoweringBloodPressure[1]}  3){patient.resultCovidTest.TableEntriesLoweringBloodPressure[2]}\n" +
                                $"Обморок\n1){patient.resultCovidTest.TableEntriesFainting[0]}  2){patient.resultCovidTest.TableEntriesFainting[1]}  3){patient.resultCovidTest.TableEntriesFainting[2]}\n" +
                                $"•	Опорно-двигательная система:\n" +
                                $"Боль в мышцах\n1){patient.resultCovidTest.TableEntriesMusclePain[0]}  2){patient.resultCovidTest.TableEntriesMusclePain[1]}  3){patient.resultCovidTest.TableEntriesMusclePain[2]}\n" +
                                $"Боль в суставах\n1){patient.resultCovidTest.TableEntriesJointPain[0]}  2){patient.resultCovidTest.TableEntriesJointPain[1]}  3){patient.resultCovidTest.TableEntriesJointPain[2]}\n" +
                                $"•	Органы чувств:\n" +
                                $"Головокружение\n1){patient.resultCovidTest.TableEntriesDizziness[0]}  2){patient.resultCovidTest.TableEntriesDizziness[1]}  3){patient.resultCovidTest.TableEntriesDizziness[2]}\n" +
                                $"Нарушение равновесия\n1){patient.resultCovidTest.TableEntriesImbalance[0]}  2){patient.resultCovidTest.TableEntriesImbalance[1]}  3){patient.resultCovidTest.TableEntriesImbalance[2]}\n" +
                                $"Нарушение зрения\n1){patient.resultCovidTest.TableEntriesVisualImpairment[0]}  2){patient.resultCovidTest.TableEntriesVisualImpairment[1]}  3){patient.resultCovidTest.TableEntriesVisualImpairment[2]}\n" +
                                $"Кожная гиперестезия\n1){patient.resultCovidTest.TableEntriesSkinHyperesthesia[0]}  2){patient.resultCovidTest.TableEntriesSkinHyperesthesia[1]}  3){patient.resultCovidTest.TableEntriesSkinHyperesthesia[2]}\n" +
                                $"Боль в конечностях\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                $"Онемение в конечностях\n1){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[0]}  2){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[1]}  3){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[2]}\n" +
                                $"Парестезии\n1){patient.resultCovidTest.TableEntriesParesthesia[0]}  2){patient.resultCovidTest.TableEntriesParesthesia[1]}  3){patient.resultCovidTest.TableEntriesParesthesia[2]}\n" +
                                $"Нарушения вкуса\n1){patient.resultCovidTest.TableEntriesTasteDisorders[0]}  2){patient.resultCovidTest.TableEntriesTasteDisorders[1]}  3){patient.resultCovidTest.TableEntriesTasteDisorders[2]}\n" +
                                $"Нарушения обоняния\n1){patient.resultCovidTest.TableEntriesOlfactoryDisorders[0]}  2){patient.resultCovidTest.TableEntriesOlfactoryDisorders[1]}  3){patient.resultCovidTest.TableEntriesOlfactoryDisorders[2]}\n" +
                                $"•	Дыхательная система:\n" +
                                $"Кашель\n1){patient.resultCovidTest.TableEntriesCough[0]}  2){patient.resultCovidTest.TableEntriesCough[1]}  3){patient.resultCovidTest.TableEntriesCough[2]}\n" +
                                $"Одышка\n1){patient.resultCovidTest.TableEntriesDyspnea[0]}  2){patient.resultCovidTest.TableEntriesDyspnea[1]}  3){patient.resultCovidTest.TableEntriesDyspnea[2]}\n" +
                                $"Стеснение в груди, боль в груди\n1){patient.resultCovidTest.TableEntriesChestPain[0]}  2){patient.resultCovidTest.TableEntriesChestPain[1]}  3){patient.resultCovidTest.TableEntriesChestPain[2]}\n" +
                                $"Учащенное сердцебиение\n1){patient.resultCovidTest.TableEntriesCardiopalmus[0]}  2){patient.resultCovidTest.TableEntriesCardiopalmus[1]}  3){patient.resultCovidTest.TableEntriesCardiopalmus[2]}\n" +
                                $"Анорексия, снижение аппетита\n1){patient.resultCovidTest.TableEntriesAnorexia[0]}  2){patient.resultCovidTest.TableEntriesAnorexia[1]}  3){patient.resultCovidTest.TableEntriesAnorexia[2]}\n" +
                                $"Судороги\n1){patient.resultCovidTest.TableEntriesConvulsions[0]}  2){patient.resultCovidTest.TableEntriesConvulsions[1]}  3){patient.resultCovidTest.TableEntriesConvulsions[2]}\n" +
                                $"•	Лор:\n" +
                                $"Боль в горле\n1){patient.resultCovidTest.TableEntriesSoreThroat[0]}  2){patient.resultCovidTest.TableEntriesSoreThroat[1]}  3){patient.resultCovidTest.TableEntriesSoreThroat[2]}\n" +
                                $"Шум в ушах\n1){patient.resultCovidTest.TableEntriesNoiseInEars[0]}  2){patient.resultCovidTest.TableEntriesNoiseInEars[1]}  3){patient.resultCovidTest.TableEntriesNoiseInEars[2]}\n" +
                                $"Ушная боль\n1){patient.resultCovidTest.TableEntriesEarAche[0]}  2){patient.resultCovidTest.TableEntriesEarAche[1]}  3){patient.resultCovidTest.TableEntriesEarAche[2]}\n" +
                                $"Заложенность носа\n1){patient.resultCovidTest.TableEntriesNasalCongestion[0]}  2){patient.resultCovidTest.TableEntriesNasalCongestion[1]}  3){patient.resultCovidTest.TableEntriesNasalCongestion[2]}\n" +
                                $"Боль и сухость носа\n1){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[0]}  2){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[1]}  3){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[2]}\n" +
                                $"•	Желудочно-кишечный тракт:\n" +
                                $"Боль в животе\n1){patient.resultCovidTest.TableEntriesAbdominalPain[0]}  2){patient.resultCovidTest.TableEntriesAbdominalPain[1]}  3){patient.resultCovidTest.TableEntriesAbdominalPain[2]}\n" +
                                $"Диарея\n1){patient.resultCovidTest.TableEntriesDiarrhea[0]}  2){patient.resultCovidTest.TableEntriesDiarrhea[1]}  3){patient.resultCovidTest.TableEntriesDiarrhea[2]}\n" +
                                $"Тошнота и рвота\n1){patient.resultCovidTest.TableEntriesNauseaAndVomiting[0]}  2){patient.resultCovidTest.TableEntriesNauseaAndVomiting[1]}  3){patient.resultCovidTest.TableEntriesNauseaAndVomiting[2]}\n" +
                                $"•	Дерматологические проблемы:\n" +
                                $"Выпадение волос\n1){patient.resultCovidTest.TableEntriesHairLoss[0]}  2){patient.resultCovidTest.TableEntriesHairLoss[1]}  3){patient.resultCovidTest.TableEntriesHairLoss[2]}\n" +
                                $"Кожные высыпания\n1){patient.resultCovidTest.TableEntriesSkinRashes[0]}  2){patient.resultCovidTest.TableEntriesSkinRashes[1]}  3){patient.resultCovidTest.TableEntriesSkinRashes[2]}";
            ResultCognitive.Text = $"Общий результат { patient.resultMOSA.resultMOSATest}";
            ResultVasserman.Text = $"Общий результат {patient.resultVasserman.TotalResultVasserman}";
            ResultBurdon.Text = $"Концентрация внимания {patient.scoreBourdon.ConcentrationOfAtention}\nУстойчивость внимания {patient.scoreBourdon.AttentionSpan}";
            ResultPraxisAndGnosis.Text = $"Общий результат {patient.resultPraxisAndGnosis.TotalResultPraxisAndGnosis}\n" +
                               $"Результат моторного праксиса {patient.resultPraxisAndGnosis.resultMotorPraxis}\nРезультат динамического праксиса {patient.resultPraxisAndGnosis.resultDynamicPraxis}\n" +
                               $"Результат конструктивного праксиса {patient.resultPraxisAndGnosis.resultConstructivePraxis}\nРезультат объектного гнозиса {patient.resultPraxisAndGnosis.resultSubjectGnosis}\n" +
                               $"Результат копирования часов {patient.resultPraxisAndGnosis.resultClock}";
            ResultAnxietyAndDepression.Text = $"Общий результат тревоги {patient.resultAnxietyAndDepression.TotalResultAnxiety}\nОбщий результат депрессии {patient.resultAnxietyAndDepression.TotalResultDepression}";
            ResultAsthenia.Text = $"Общий результат {patient.scoreMFI20.TotalTestScore}\nБалл за общую астению {patient.scoreMFI20.ScoreAnswerGeneralAsthenia}\n" +
                               $"Балл за пониженную активность {patient.scoreMFI20.ScoreAnswerReducedActivity}\nБалл за снижение мотивации {patient.scoreMFI20.ScoreAnswerDecreasedMotivation}\n" +
                               $"Балл за физическую астению {patient.scoreMFI20.ScoreAnswerPhysicalAsthenia}\nБалл за психическую астению {patient.scoreMFI20.ScoreAnswerMentalAsthenia}";
            ResultLifeQuality.Text = $"Общий результат {patient.resultLifeQuality.TotalResultLifeQuality}";
            ResultLocus.Text = $"Общий результат {patient.resultLocus.TotalResultLocus}";
        }
    }
}
