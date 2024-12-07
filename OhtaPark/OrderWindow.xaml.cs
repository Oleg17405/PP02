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
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {

        private DispatcherTimer timer;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        ohtoParkEntities db = new ohtoParkEntities();
        Order orders = new Order();
        public OrderWindow()
        {
            InitializeComponent();
            Tab.IsReadOnly = true;
            db = new ohtoParkEntities();
            Tab.ItemsSource = db.Orders.ToList();
            update();
        }

        public void update()
        {
            Tab.ItemsSource = db.Orders.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(50); // Обновление каждые 50 мс
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

    }
}
