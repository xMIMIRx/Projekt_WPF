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
using System.Windows.Threading;

namespace Projekt_WPF.Glowna
{
    /// <summary>
    /// Logika interakcji dla klasy AimTrainer.xaml
    /// </summary>
    public partial class AimTrainer : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        private int liczbaKulek = 6+1;
        private int X;
        private int Y;
        private int ms;
        Random random = new Random();
        public AimTrainer()
        {
            InitializeComponent();
        }

        private void Gra()
        {
            liczbaKulek -= 1;
            if (liczbaKulek > 0)
            {
                X = random.Next(10, 700);
                Y = random.Next(10, 500);

                Ellipse circle = new Ellipse
                {
                    Tag = "circle",
                    Height = 25,
                    Width = 25,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = Brushes.Red
                };
                Canvas.SetLeft(circle, X);
                Canvas.SetTop(circle, Y);
                aimTrainer.Children.Add(circle);
            }
            else if(liczbaKulek <= 0)
            {
                timer.Stop();
                gridPanel.Visibility = Visibility.Visible;
                przycisk.Visibility = Visibility.Hidden;
            }
        }
        private void ClickOnCanvas(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Ellipse)
            {
                Ellipse circle = (Ellipse)e.OriginalSource;
                aimTrainer.Children.Remove(circle);
                Gra();
            }
        }

        private void button(object sender, RoutedEventArgs e)
        {
            ms = 0;
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timerTick;
            timer.Start();
            gridPanel.Visibility = Visibility.Hidden;
            Gra();
        }
        private void timerTick(object sender, EventArgs e)
        {
            ms++;
            czas.Text =  ms.ToString() + "ms";
        }
    }
}
