using System;
using System.Collections;
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

namespace OhtaPark
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ohtoParkEntities db;
        int error = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new ohtoParkEntities();
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            if (email == "" && password == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                if (db.Employees.Any(x => x.Login != email && x.Password != password))
                {

                    if (db.Employees.Any(x => x.Login == email && x.Password == password))
                    {
                        if (db.Employees.Any(x => x.Position == "Администратор" && x.Login == email))
                        {
                            OrderWindow orderWindow = new OrderWindow();
                            orderWindow.Show();
                            orderWindow.WindowState = this.WindowState;
                            this.Close();
                        }

                        else if (db.Employees.Any(x => x.Position == "Старший смены" && x.Login == email))
                        {

                            AddOrderWindow addOrderWindow = new AddOrderWindow();
                            this.Close();
                            addOrderWindow.Show();
                        }
                        else if (db.Employees.Any(x => x.Position == "Продавец" && x.Login == email))
                        {

                            AddOrderWindow addOrderWindow = new AddOrderWindow();
                            addOrderWindow.Show();
                            addOrderWindow.WindowState = this.WindowState;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        error++;
                        if (error == 3)
                        {

                            Captcha captcha = new Captcha();
                            captcha.Show();
                            this.Close();
                            error = 0;
                        }
                    }
                }
            }
        }
    }
}