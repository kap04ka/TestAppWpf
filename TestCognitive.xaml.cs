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
    /// Логика взаимодействия для TestCognitive.xaml
    /// </summary>
    public partial class TestCognitive : Page
    {
        int resultTest = 0;
        int resultVisualConstructiveSkills = 0;
        int resultNaming = 0;
        int resultAttention = 0;
        int resultSpeech = 0;
        int resultAbstraction = 0;
        int resultDelayedPlayback = 0;
        int resultOrientation = 0;
        int serialSubstractionResult = 0;

        public TestCognitive()
        {
            InitializeComponent();
            Title = "Оценка когнитивной сферы";
        }

        public void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            if (serialSubstractionResult == 5 || serialSubstractionResult == 4)
            {
                resultAttention += 3;
                resultTest += 3;
            }

            if (serialSubstractionResult == 3 || serialSubstractionResult == 2)
            {
                resultAttention += 2;
                resultTest += 2;
            }

            if (serialSubstractionResult == 1)
            {
                resultAttention += 1;
                resultTest += 1;
            }

            App.patient.resultMOSA.resultMOSATest = resultTest;
            App.patient.resultMOSA.resultVisualConstructiveSkillsMOSA = resultVisualConstructiveSkills;
            App.patient.resultMOSA.resultNamingMOSA = resultNaming;
            App.patient.resultMOSA.resultAttentionMOSA = resultAttention;
            App.patient.resultMOSA.resultSpeechMOSA = resultSpeech;
            App.patient.resultMOSA.resultAbstractionMOSA = resultAbstraction;
            App.patient.resultMOSA.resultDelayedPlaybackMOSA = resultDelayedPlayback;
            App.patient.resultMOSA.resultOrientationMOSA = resultOrientation;

            MessageBox.Show($"Общий результат = {resultTest}\n" +
                                       $"Баллы за зрительно-конструктивные навыки = {resultVisualConstructiveSkills}\n" +
                                       $"Баллы за называние = {resultNaming}\n" +
                                       $"Баллы за память = {resultAttention}\n" +
                                       $"Баллы за речь = {resultSpeech}\n" +
                                       $"Баллы за абстракцию = {resultAbstraction}\n" +
                                       $"Баллы за отсроченное воспроизведение = {resultDelayedPlayback}\n" +
                                       $"Баллы за ориентацию = {resultOrientation}\n", "Результат", MessageBoxButton.OK);

            visualConstructiveSkillsFirst.IsChecked = false;
            visualConstructiveSkillsSecond.IsChecked = false;
            visualConstructiveSkillsThird.IsChecked = false;
            visualConstructiveSkillsFourth.IsChecked = false;
            visualConstructiveSkillsFifth.IsChecked = false;

            namingFirst.IsChecked = false;
            namingSecond.IsChecked = false;
            namingThird.IsChecked = false;

            firstWord1.IsChecked = false;
            firstWord2.IsChecked = false;
            secondWord1.IsChecked = false;
            secondWord2.IsChecked = false;
            thirdWord1.IsChecked = false;
            thirdWord2.IsChecked = false;
            fourthWord1.IsChecked = false;
            fourthWord2.IsChecked = false;
            fifthWord1.IsChecked = false;
            fifthWord2.IsChecked = false;

            attentionFirst.IsChecked = false;
            attentionSecond.IsChecked = false;
            attentionThird.IsChecked = false;
            serialSubtractionFirst.IsChecked = false;
            serialSubtractionSecond.IsChecked = false;
            serialSubtractionThird.IsChecked = false;
            serialSubtractionFourth.IsChecked = false;
            serialSubtractionFifth.IsChecked = false;

            speechFirst.IsChecked = false;
            speechSecond.IsChecked = false;
            speechThird.IsChecked = false;

            abstractionFirst.IsChecked = false;
            abstractionSecond.IsChecked = false;

            delayedPlaybackFirst.IsChecked = false;
            delayedPlaybackSecond.IsChecked = false;
            delayedPlaybackThird.IsChecked = false;
            delayedPlaybackFourth.IsChecked = false;
            delayedPlaybackFifth.IsChecked = false;

            orientationFirst.IsChecked = false;
            orientationSecond.IsChecked = false;
            orientationThird.IsChecked = false;
            orientationFourth.IsChecked = false;
            orientationFifth.IsChecked = false;
            orientationSixth.IsChecked = false;

            promptSecond.IsEnabled = false;

            resultTest = 0;
            resultVisualConstructiveSkills = 0;
            resultNaming = 0;
            resultAttention = 0;
            resultSpeech = 0;
            resultAbstraction = 0;
            resultDelayedPlayback = 0;
            resultOrientation = 0;
            serialSubstractionResult = 0;

            NavigationService.Navigate(new Menu());
        }

        private void OnCheckBoxCheckedVisualConstructiveSkills(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultVisualConstructiveSkills += 1;
            }

            else
            {
                resultTest -= 1;
                resultVisualConstructiveSkills -= 1;
            }
        }

        private void OnCheckBoxCheckedNaming(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultNaming += 1;
            }

            else
            {
                resultTest -= 1;
                resultNaming -= 1;
            }
        }

        private void OnCheckBoxCheckedAttention(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultAttention += 1;
            }

            else
            {
                resultTest -= 1;
                resultAttention -= 1;
            }
        }

        private void OnCheckBoxCheckedSerialSubtraction(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                serialSubstractionResult += 1;
            }

            else
            {
                serialSubstractionResult -= 1;
            }

        }

        private void OnCheckBoxCheckedSpeech(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultSpeech += 1;
            }

            else
            {
                resultTest -= 1;
                resultSpeech -= 1;
            }

        }

        private void OnCheckBoxCheckedAbstraction(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultAbstraction += 1;
            }

            else
            {
                resultTest -= 1;
                resultAbstraction -= 1;
            }

        }
        private void OnCheckBoxCheckedDelayedPlayback(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultDelayedPlayback += 1;
            }

            else
            {
                resultTest -= 1;
                resultDelayedPlayback -= 1;
            }

        }

        private void OnCheckBoxCheckedOrientation(object sender, RoutedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if ((bool)chBox.IsChecked)
            {
                resultTest += 1;
                resultOrientation += 1;
            }

            else
            {
                resultTest -= 1;
                resultOrientation -= 1;
            }

        }

        private void button_PromptFirst(object sender, System.EventArgs e)
        {
            MessageBox.Show("Лицо - часть тела\n" +
                         "Вельвет - вид материала\n" +
                         "Церковь - строение\n" +
                         "маргаритка - цветок\n" +
                         "Красный - цвет\n", "Подсказка категория", MessageBoxButton.OK);

            promptSecond.IsEnabled = true;
        }

        private void button_PromptSecond(object sender, System.EventArgs e)
        {
            MessageBox.Show("нос, лицо, рука\n" +
                         "бархат, хлопок, вельвет\n" +
                         "церковь, школа, больница\n" +
                         "роза, маргаритка, тюльпан\n" +
                         "красный, синий, зеленый\n", "Подсказка выбор", MessageBoxButton.OK);
        }
    }
}
