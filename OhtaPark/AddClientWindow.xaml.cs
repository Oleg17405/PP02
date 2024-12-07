using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OhtaPark
{
    /// <summary>
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        ohtoParkEntities db;
        public AddClientWindow()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (login_tb.Text != null && surname_tb.Text != null && name_tb.Text != null && patronymic_tb.Text != null &&
                dr_dp.SelectedDate != null && series_tb.Text != null && number_tb.Text != null && address_tb.Text != null)
            {
                db = new ohtoParkEntities();
                Client client = new Client
                {
                  Email = login_tb.Text,
                    LastName = surname_tb.Text,
                    FirstName = name_tb.Text,
                    Patronymic = patronymic_tb.Text,
                    DateOfBirth = Convert.ToDateTime(dr_dp.SelectedDate),
                    PassportSeries = series_tb.Text,
                    PassportNumber = number_tb.Text,
                    Address = address_tb.Text,
                };
                db.Clients.Add(client);
                db.SaveChanges();
                OrderWindow orderWindow = new OrderWindow();
                orderWindow.Show();
                MessageBox.Show("Данные добавленны");

            }
            else { MessageBox.Show("Заполните данные о клиенте", "", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

        private void series_tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли вводимый символ числом
            if (!char.IsDigit(e.Text, 0))
            {
                // Отменяем ввод, если символ не является числом
                e.Handled = true;
            }
        }

        private void number_tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли вводимый символ числом
            if (!char.IsDigit(e.Text, 0))
            {
                // Отменяем ввод, если символ не является числом
                e.Handled = true;
            }
        }

        private void dr_dp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверка на цифры и точку
            if (!char.IsDigit(e.Text, 0) && e.Text != ".")
            {
                e.Handled = true;
                return;
            }

            // Проверка формата даты после каждого ввода символа
            string currentText = dr_dp.Text;
            if (currentText.Length > 0)
            {
                // Используйте регулярное выражение для проверки формата "ДД.ММ.ГГГГ"
                Regex regex = new Regex(@"^\d{1,2}\.\d{1,2}\.\d{4}$");

                if (regex.IsMatch(currentText))
                {
                    // Если дата соответствует формату, попробуйте преобразовать ее в DateTime
                    DateTime date;
                    if (DateTime.TryParseExact(currentText, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        // Если преобразование успешно, установите выбранную дату в DatePicker
                        dr_dp.SelectedDate = date;
                    }
                    else
                    {
                        // Если преобразование не удалось, очистите текстовое поле DatePicker
                        dr_dp.Text = "";
                    }
                }
            }
        }
    }
}
