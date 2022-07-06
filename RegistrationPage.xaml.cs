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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void buttonMainMenu_Clicked(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }

        private void button_CalculateResult(object sender, RoutedEventArgs e)
        {
            //ввели данные 
            if (DataEntered())
            {
                ReadDataPatient();

                //данные введены правильно
                if (DataValidation())
                {
                    //переход на тест
                    NavigationService.Navigate(new Menu());
                }
                //не правильно введены данные
                else
                {
                    MessageBox.Show("Введите данные корректно", "Предупреждение", MessageBoxButton.OK);
                }
            }
            //данные не ввели
            else
            {
                MessageBox.Show("Введите свои данные в каждом пунтке", "Ошибка", MessageBoxButton.OK);
            }
        }


        /// <summary>
        /// Считывание введенных данных из формы
        /// </summary>
        private void ReadDataPatient()
        {
            App.patient.Forename = entryForename.Text;
            App.patient.Surname = entrySurname.Text;
            App.patient.Patronymic = entryPatronymic.Text;
            App.patient.PhoneNumber = entryTelephone.Text;
            App.patient.Email = entryEmail.Text;
            App.patient.Company = entryWork.Text;
            App.patient.DoctorFIO = entryAttendingDoctor.Text;
            App.patient.DateOfBirth = (DateTime)dataPickerDateOfBirth.SelectedDate;

            App.patient.Age = DateTime.Today.Year - App.patient.DateOfBirth.Year;
            if (App.patient.DateOfBirth.DayOfYear > DateTime.Today.DayOfYear)
            {
                App.patient.Age--;
            }
        }


        /// <summary>
        /// Ввел ли пациент данные 
        /// </summary>
        /// <returns></returns>
        private bool DataEntered()
        {
            if (entryForename.Text == null || entrySurname.Text == null || entryPatronymic.Text == null ||
               entryTelephone.Text == null || entryEmail.Text == null || entryWork.Text == null ||
               entryAttendingDoctor.Text == null || dataPickerDateOfBirth.SelectedDate == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Проверка правильности введенных данных
        /// </summary>
        /// <returns></returns>
        private bool DataValidation()
        {
            if (App.patient.Forename == "" || App.patient.Surname == "" || App.patient.Patronymic == "" ||
               App.patient.PhoneNumber == "" || App.patient.Email == "" || App.patient.Company == "" ||
               App.patient.DoctorFIO == "" || App.patient.Forename[0] == ' ' || App.patient.Surname[0] == ' ' ||
               App.patient.Patronymic[0] == ' ' || App.patient.PhoneNumber[0] == ' ' || App.patient.Email[0] == ' ' ||
               App.patient.Company[0] == ' ' || App.patient.DoctorFIO[0] == ' ' || App.patient.Age < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}