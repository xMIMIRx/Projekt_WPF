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

namespace Projekt_WPF.Glowna
{
    /// <summary>
    /// Logika interakcji dla klasy Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Page
    {
        public Kalkulator()
        {
            InitializeComponent();
            Dzialanie.Text = string.Empty;
        }
        private void btn(object sender, RoutedEventArgs e)
        {
            var jakiPrzycisk = sender as Button;
            int liczba = int.Parse((string) jakiPrzycisk.Content);
            Dzialanie.Text += liczba;
        }
        private void btn_dodawanie(object sender, RoutedEventArgs e)
        {
            string txtBlock = Dzialanie.Text;
            if (czyZnak(txtBlock))
            {
                Dzialanie.Text = rownanie(txtBlock).ToString();
            }
            Dzialanie.Text += "+";
        }
        private void btn_odejmowanie(object sender, RoutedEventArgs e)
        {
            string txtBlock = Dzialanie.Text;
            if (czyZnak(txtBlock))
            {
                Dzialanie.Text = rownanie(txtBlock).ToString();
            }
            Dzialanie.Text += "-";
        }
        private void btn_mnozenie(object sender, RoutedEventArgs e)
        {
            string txtBlock = Dzialanie.Text;
            if (czyZnak(txtBlock))
            {
                Dzialanie.Text = rownanie(txtBlock).ToString();
            }
            Dzialanie.Text += "*";
        }
        private void btn_dzielenie(object sender, RoutedEventArgs e)
        {
            string txtBlock = Dzialanie.Text;
            if (czyZnak(txtBlock))
            {
                Dzialanie.Text = rownanie(txtBlock).ToString();
            }
            Dzialanie.Text += "/";
        }
        private void btn_rownanie(object sender, RoutedEventArgs e)
        {
            string txtBlock = Dzialanie.Text;
            Dzialanie.Text = string.Empty;
            Dzialanie.Text = rownanie(txtBlock).ToString();
        }
        private void btn_clear(object sender, RoutedEventArgs e)
        {
            Dzialanie.Text = string.Empty;
        }
        private double rownanie(string txtBlock)
        {
            try
            {
                if (txtBlock.Contains("+"))
                {
                    string[] liczby = txtBlock.Split("+");
                    return double.Parse(liczby[0]) + double.Parse(liczby[1]);
                }
                else if (txtBlock.Contains('-'))
                {
                    string[] liczby = txtBlock.Split("-");
                    return double.Parse(liczby[0]) - double.Parse(liczby[1]);
                }
                else if (txtBlock.Contains('*'))
                {
                    string[] liczby = txtBlock.Split("*");
                    return double.Parse(liczby[0]) * double.Parse(liczby[1]);
                }
                else if (txtBlock.Contains('/'))
                {
                    string[] liczby = txtBlock.Split("/");
                    return double.Parse(liczby[0]) / double.Parse(liczby[1]);
                }
            }
            catch (System.Exception)
            {
                return default;
            }
            return default;
        }
        private bool czyZnak(string txtBlock)
        {
            return txtBlock.Contains("+") || txtBlock.Contains("-") || txtBlock.Contains("*") || txtBlock.Contains("/");
        }
    }
}
