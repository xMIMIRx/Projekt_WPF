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
    /// Logika interakcji dla klasy KolkoIKrzyzyk.xaml
    /// </summary>
    public partial class KolkoIKrzyzyk : Page
    {
        public bool kogoTura;
        public int ktoraTura;
        public KolkoIKrzyzyk()
        {
            InitializeComponent();
            nowaGra();
        }
        public void nowaGra()
        {
            kogoTura = false;
            ktoraTura = 0;

            btn00.Content = string.Empty;
            btn01.Content = string.Empty;
            btn02.Content = string.Empty;
            btn10.Content = string.Empty;
            btn11.Content = string.Empty;
            btn12.Content = string.Empty;
            btn20.Content = string.Empty;
            btn21.Content = string.Empty;
            btn22.Content = string.Empty;

            btn00.Background = default;
            btn01.Background = default;
            btn02.Background = default;
            btn10.Background = default;
            btn11.Background = default;
            btn12.Background = default;
            btn20.Background = default;
            btn21.Background = default;
            btn22.Background = default;

            txtBox.Text = "";
            txtBox.Foreground = default;
            nGra.Visibility = Visibility.Hidden;
        }

        private void btn_ng(object sender, RoutedEventArgs e)
        {
            nowaGra();
        }



        private void btn(object sender, RoutedEventArgs e)
        {
            if (kogoTura) kogoTura = false;
            else kogoTura = true;

            var button = sender as Button;
            if (button.Content == "X" || button.Content == "O") return;

            ktoraTura++;
            if (ktoraTura > 9)
            {
                nowaGra();
                return;
            }


            if (kogoTura)
            {
                button.Content = "X";
                button.Foreground = Brushes.Crimson;
            }
            else 
            {
                button.Content = "O";
                button.Foreground = Brushes.DarkTurquoise;
            }


            if (czyWygral() == "X")
            {
                txtBox.Text = "Wygrywa\n Krzyżyk";
                txtBox.Foreground = Brushes.Crimson;
                nGra.Visibility = Visibility.Visible;
                ktoraTura = 9;
            }
            else if (czyWygral() == "O")
            {
                txtBox.Text = "Wygrywa\n Kółko";
                txtBox.Foreground = Brushes.DarkTurquoise;
                nGra.Visibility = Visibility.Visible;
                ktoraTura = 9;
            }
            else if (czyWygral() != "X" && czyWygral() != "O" && ktoraTura == 9)
            {
                txtBox.Text = "! REMIS !";
                txtBox.Foreground = Brushes.Gray;
                nGra.Visibility = Visibility.Visible;
                ktoraTura = 9;
            }
        }

        private string czyWygral()
        {
            /* X - Poziomo*/
            if (btn00.Content != string.Empty && btn00.Content == "X" && btn00.Content == btn01.Content && btn01.Content == btn02.Content)
            {
                btn00.Background = Brushes.LightPink;
                btn01.Background = Brushes.LightPink;
                btn02.Background = Brushes.LightPink;
                return "X";
            }
            else if (btn10.Content != string.Empty && btn10.Content == "X" && btn10.Content == btn11.Content && btn11.Content == btn12.Content)
            {
                btn10.Background = Brushes.LightPink;
                btn11.Background = Brushes.LightPink;
                btn12.Background = Brushes.LightPink;
                return "X";
            }
            else if (btn20.Content != string.Empty && btn20.Content == "X" && btn20.Content == btn21.Content && btn21.Content == btn22.Content)
            {
                btn20.Background = Brushes.LightPink;
                btn21.Background = Brushes.LightPink;
                btn22.Background = Brushes.LightPink;
                return "X";
            }

            /* X - Pionowo*/
            else if (btn00.Content != string.Empty && btn00.Content == "X" && btn00.Content == btn10.Content && btn10.Content == btn20.Content)
            {
                btn00.Background = Brushes.LightPink;
                btn10.Background = Brushes.LightPink;
                btn20.Background = Brushes.LightPink;
                return "X";
            }
            else if (btn01.Content != string.Empty && btn01.Content == "X" && btn01.Content == btn11.Content && btn11.Content == btn21.Content)
            {
                btn01.Background = Brushes.LightPink;
                btn11.Background = Brushes.LightPink;
                btn21.Background = Brushes.LightPink;
                return "X";
            }
            else if (btn02.Content != string.Empty && btn02.Content == "X" && btn02.Content == btn12.Content && btn12.Content == btn22.Content)
            {
                btn02.Background = Brushes.LightPink;
                btn12.Background = Brushes.LightPink;
                btn22.Background = Brushes.LightPink;
                return "X";
            }

            /* X - Skos*/
            else if (btn00.Content != string.Empty && btn00.Content == "X" && btn00.Content == btn11.Content && btn11.Content == btn22.Content)
            {
                btn00.Background = Brushes.LightPink;
                btn11.Background = Brushes.LightPink;
                btn22.Background = Brushes.LightPink;
                return "X";
            }
            else if (btn02.Content != string.Empty && btn02.Content == "X" && btn02.Content == btn11.Content && btn11.Content == btn20.Content)
            {
                btn02.Background = Brushes.LightPink;
                btn11.Background = Brushes.LightPink;
                btn20.Background = Brushes.LightPink;
                return "X";
            }



            /* O - Poziome*/
            else if (btn00.Content != string.Empty && btn00.Content == "O" && btn00.Content == btn01.Content && btn01.Content == btn02.Content)
            {
                btn00.Background = Brushes.LightCyan;
                btn01.Background = Brushes.LightCyan;
                btn02.Background = Brushes.LightCyan;
                return "O";
            }
            else if (btn10.Content != string.Empty && btn10.Content == "O" && btn10.Content == btn11.Content && btn11.Content == btn12.Content)
            {
                btn10.Background = Brushes.LightCyan;
                btn11.Background = Brushes.LightCyan;
                btn12.Background = Brushes.LightCyan;
                return "O";
            }
            else if (btn20.Content != string.Empty && btn20.Content == "O" && btn20.Content == btn21.Content && btn21.Content == btn22.Content)
            {
                btn20.Background = Brushes.LightCyan;
                btn21.Background = Brushes.LightCyan;
                btn22.Background = Brushes.LightCyan;
                return "O";
            }

            /* O - Pionowo*/
            else if (btn00.Content != string.Empty && btn00.Content == "O" && btn00.Content == btn10.Content && btn10.Content == btn20.Content)
            {
                btn00.Background = Brushes.LightCyan;
                btn10.Background = Brushes.LightCyan;
                btn20.Background = Brushes.LightCyan;
                return "O";
            }
            else if (btn01.Content != string.Empty && btn01.Content == "O" && btn01.Content == btn11.Content && btn11.Content == btn21.Content)
            {
                btn01.Background = Brushes.LightCyan;
                btn11.Background = Brushes.LightCyan;
                btn21.Background = Brushes.LightCyan;
                return "O";
            }
            else if (btn02.Content != string.Empty && btn02.Content == "O" && btn02.Content == btn12.Content && btn12.Content == btn22.Content)
            {
                btn02.Background = Brushes.LightCyan;
                btn12.Background = Brushes.LightCyan;
                btn22.Background = Brushes.LightCyan;
                return "O";
            }

            /* O - Skos*/
            else if (btn00.Content != string.Empty && btn00.Content == "O" && btn00.Content == btn11.Content && btn11.Content == btn22.Content)
            {
                btn00.Background = Brushes.LightCyan;
                btn11.Background = Brushes.LightCyan;
                btn22.Background = Brushes.LightCyan;
                return "O";
            }
            else if (btn02.Content != string.Empty && btn02.Content == "O" && btn02.Content == btn11.Content && btn11.Content == btn20.Content)
            {
                btn02.Background = Brushes.LightCyan;
                btn11.Background = Brushes.LightCyan;
                btn20.Background = Brushes.LightCyan;
                return "O";
            }



            /* Remis 
            else if (btn00.Content != string.Empty && btn02.Content == btn11.Content && btn11.Content == btn20.Content)
            {
                return "R";
            }*/
            return "";
        }
    }
}
