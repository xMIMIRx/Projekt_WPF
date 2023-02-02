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
    /// Logika interakcji dla klasy Przegladarka.xaml
    /// </summary>
    public partial class Przegladarka : Page
    {
        public Przegladarka()
        {
            InitializeComponent();
        }

        private void W_Loaded(object sender, RoutedEventArgs e)
        {
            webBrowser.Source = new Uri("http://www.google.com");
        }

        private void szukaj(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri("http://" + txtBox.Text);
            }
            catch 
            {
                stopka.Text = "Podaj właściwy link!";
                return;
            }
            stopka.Text = "";
        }

        private void strzalkaLewo(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void strzalkaPrawo(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }
    }
}
