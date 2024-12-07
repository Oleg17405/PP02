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

namespace OhtaPark
{
    public partial class Captcha : Window
    {
        private string captchaText;
        private string generatedCaptcha;
        private int attempts = 0;
        public Captcha()
        {
            InitializeComponent();
            GenerateCaptcha();
        }
        private void GenerateCaptcha()
        {
            // Генерация случайной капчи
            Random random = new Random();
            generatedCaptcha = "";
            int power = 4;
            for (int i = 0; i < power; i++)
            {
                generatedCaptcha += (char)('А' + random.Next(0, 32));

            }

            CaptchaTextBlock.Text = generatedCaptcha;
            Label captchaLabel = new Label();
            captchaLabel.Content = captchaText;
            captchaLabel.FontSize = 20;
            captchaLabel.Margin = new Thickness(10);
            captchaLabel.Foreground = Brushes.Black;
            // Добавление шума и линий к капче
            DrawingVisual visual = new DrawingVisual();
            using (DrawingContext context = visual.RenderOpen())
            {
                for (int i = 0; i < 100; i++)
                {
                    context.DrawEllipse(Brushes.Black, null, new Point(random.Next(0, 200), random.Next(0, 50)), 1, 1);
                    context.DrawEllipse(Brushes.Black, null, new Point(random.Next(0, 200), random.Next(0, 50)), 2, 2);
                }
                context.DrawLine(new Pen(Brushes.Black, 2), new Point(0, random.Next(0, 30)), new Point(200, random.Next(0, 50)));
                context.DrawLine(new Pen(Brushes.Black, 2), new Point(0, random.Next(0, 30)), new Point(200, random.Next(0, 50)));
            }

            VisualBrush visualBrush = new VisualBrush(visual);
            CaptchaTextBlock.Background = visualBrush;



        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            GenerateCaptcha();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            // Проверка капчи
            if (InputTextBox.Text == generatedCaptcha)
            {
                MessageBox.Show("Капча пройдена");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();

            }
            else
            {
                attempts++;
                if (attempts == 3)
                {
                    MessageBox.Show("Слишком много неверных попыток. Попробуйте снова через 15 секунд.");
                    InputTextBox.IsEnabled = false;
                    Refresh.IsEnabled = false;
                    Check.IsEnabled = false;
                    System.Threading.Thread.Sleep(15000);
                    GenerateCaptcha();
                    InputTextBox.IsEnabled = true;
                    Refresh.IsEnabled = true;
                    Check.IsEnabled = true;
                    attempts = 0;
                }
                else
                {
                    MessageBox.Show(" Попробуйте снова.");
                    GenerateCaptcha();
                }
            }
        }
    }
}
