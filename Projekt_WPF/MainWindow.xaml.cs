using System;
using System.Windows;
using System.Windows.Input;

namespace Projekt_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zamknij(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Pasek(object sender, RoutedEventArgs e)
        {
            DragMove();
        }




        private void Kalkulator(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.Kalkulator();
            Panel.Opacity = 0;
        }
        private void EksploatorPlikow(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.EksploatorPlikow();
            Panel.Opacity = 0;
        }
        private void KolkoIKrzyzyk(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.KolkoIKrzyzyk();
            Panel.Opacity = 0;
        }
        private void Przeglodarka(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.Przegladarka();
            Panel.Opacity = 0;
        }
        private void Paint(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.Paint();
            Panel.Opacity = 0;
        }
        private void AimTrainer(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = new Glowna.AimTrainer();
            Panel.Opacity = 0;
        }
    }
}
