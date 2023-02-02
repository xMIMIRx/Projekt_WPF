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
using System.Drawing;
using System.IO;

namespace Projekt_WPF.Glowna
{
    /// <summary>
    /// Logika interakcji dla klasy EksploatorPlikow.xaml
    /// </summary>
    public partial class EksploatorPlikow : Page
    {
        public EksploatorPlikow()
        {
            InitializeComponent();
        }
        private void W_Loaded(object sender, EventArgs e)
        {
            Uri uri = new Uri("C:/", UriKind.RelativeOrAbsolute);
            this.webBrowser.Navigate(uri);
        }
        private void otworz(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(this.txtBox.Text, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri) 
            {
                stopka.Text = "Dodaj ścieżkę!";
                return;
            }
            stopka.Text = "";
            this.webBrowser.Navigate(uri);
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
