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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace OhtaPark
{
    /// <summary>
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        ohtoParkEntities db;
        public AddOrderWindow()
        {

            InitializeComponent();
            db = new ohtoParkEntities();
            //заполнение combobox
            var serv = db.Services.Select(item => item.ServiceName).ToList();
            foreach (var us in serv) { servicecb.Items.Add(us); }
            var user = db.Clients.Select(item => item.LastName).ToList();
            foreach (var use in user) { clientscb.Items.Add(use); }
            LoadLastValueAndIncrement();
        }

        private void LoadLastValueAndIncrement()
        {

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            //Таймер
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        
        private void Window_Closed(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(timer.Interval);
            TimerLabel.Content = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        //Сохранение данных
        private void savebt_Click(object sender, RoutedEventArgs e)
        {
            db = new ohtoParkEntities();
            Order orders = new Order()
            {
                OrderCode = Codetb.Text,
                CreationDate = Convert.ToDateTime(Orderdp.SelectedDate),
                OrderTime = ordertime.Text,
                OrderStatus = statuscb.Text,
                ClosureDate = Convert.ToDateTime(returndp.SelectedDate),
                RentalTime = timetb.Text,
                ClientId = Convert.ToInt32(clientscb.SelectedIndex + 1),

            };
            db.Orders.Add(orders);
            db.SaveChanges();
            MessageBox.Show("Добавлен заказ ", "", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void ordertime_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void timetb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли вводимый символ числом
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }



        private void timetb_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.SelectionStart = 3;
        }

        private void timetb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var textBox = sender as TextBox;
            if (e.Key == Key.Back)
            {
                string currentText = textBox.Text;

                int lastDigitIndex = currentText.LastIndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });

                if (lastDigitIndex != -1)
                {
                    currentText = currentText.Remove(lastDigitIndex, 1).Insert(lastDigitIndex, "_");
                    textBox.Text = currentText;
                    textBox.SelectionStart = lastDigitIndex;
                }

                e.Handled = true;
            }
            else if (e.Key >= Key.D0 && e.Key <= Key.D9)
            {
                e.Handled = true;
                char digit = (char)(e.Key - Key.D0 + '0');
                string currentText = textBox.Text;
                int firstUnderscoreIndex = currentText.IndexOf('_');

                if (firstUnderscoreIndex != -1)
                {
                    currentText = currentText.Remove(firstUnderscoreIndex, 1).Insert(firstUnderscoreIndex, digit.ToString());
                    textBox.Text = currentText;
                    textBox.SelectionStart = firstUnderscoreIndex;
                    int digitCount = currentText.Count(c => char.IsDigit(c));
                    textBox.BorderBrush = digitCount >= 4 ? Brushes.Green : Brushes.Red;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.Show();
            this.Close();
        }
    }
}
