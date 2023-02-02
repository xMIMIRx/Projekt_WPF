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
    public partial class Paint : Page
    {
        private int rozmiarPedzla = 2;
        private Brush kolor = Brushes.Black;
        private bool czyPisze = false;
        public Paint()
        {
            InitializeComponent();
        }
        private void paint(Brush circlecolor, Point position)
        {
            Ellipse kolko = new Ellipse();
            kolko.Fill = circlecolor;
            kolko.Width = rozmiarPedzla;
            kolko.Height = rozmiarPedzla;
            Canvas.SetTop(kolko, position.Y);
            Canvas.SetLeft(kolko, position.X);
            canvasP.Children.Add(kolko);
        }
        private void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (czyPisze)
            {
                Point mouseposition = e.GetPosition(canvasP);
                paint(kolor, mouseposition);
            }
        }
        private void CanvasMouseLeftButtonDown(object sender, MouseEventArgs e) => czyPisze = true;
        private void CanvasMouseLeftButtonUp(object sender, MouseEventArgs e) => czyPisze = false;

        private void wyczysc(object sender, RoutedEventArgs e)
        {
            int iloscKropek = canvasP.Children.Count;
            if (iloscKropek > 0) 
            {
                canvasP.Children.Clear();
            }
        }

        /*Rozmiar Pędzla*/

        private void bardzoCienki(object sender, RoutedEventArgs e) => rozmiarPedzla = 2;
        private void cienki(object sender, RoutedEventArgs e) => rozmiarPedzla = 3;
        private void sredni(object sender, RoutedEventArgs e) => rozmiarPedzla = 5;
        private void gruby(object sender, RoutedEventArgs e) => rozmiarPedzla = 10;
        private void bardzoGruby(object sender, RoutedEventArgs e) => rozmiarPedzla = 15;

        /*Kolor Pędzla*/
        private void White(object sender, RoutedEventArgs e) => kolor = Brushes.White;
        private void WhiteSmoke(object sender, RoutedEventArgs e) => kolor = Brushes.WhiteSmoke;
        private void DarkGray(object sender, RoutedEventArgs e) => kolor = Brushes.DarkGray;
        private void Gray(object sender, RoutedEventArgs e) => kolor = Brushes.Gray;
        private void DimGray(object sender, RoutedEventArgs e) => kolor = Brushes.DimGray;
        private void Black(object sender, RoutedEventArgs e) => kolor = Brushes.Black;



        private void PaleGoldenrod(object sender, RoutedEventArgs e) => kolor = Brushes.PaleGoldenrod;
        private void Yellow(object sender, RoutedEventArgs e) => kolor = Brushes.Yellow;
        private void Gold(object sender, RoutedEventArgs e) => kolor = Brushes.Gold;
        private void Goldenrod(object sender, RoutedEventArgs e) => kolor = Brushes.Goldenrod;
        private void Chocolate(object sender, RoutedEventArgs e) => kolor = Brushes.Chocolate;
        private void SaddleBrown(object sender, RoutedEventArgs e) => kolor = Brushes.SaddleBrown;



        private void LightGreen(object sender, RoutedEventArgs e) => kolor = Brushes.LightGreen;
        private void YellowGreen(object sender, RoutedEventArgs e) => kolor = Brushes.YellowGreen;
        private void SpringGreen(object sender, RoutedEventArgs e) => kolor = Brushes.SpringGreen;
        private void Lime(object sender, RoutedEventArgs e) => kolor = Brushes.Lime;
        private void ForestGreen(object sender, RoutedEventArgs e) => kolor = Brushes.ForestGreen;
        private void Green(object sender, RoutedEventArgs e) => kolor = Brushes.Green;



        private void SkyBlue(object sender, RoutedEventArgs e) => kolor = Brushes.SkyBlue;
        private void Turquoise(object sender, RoutedEventArgs e) => kolor = Brushes.Turquoise;
        private void Cyan(object sender, RoutedEventArgs e) => kolor = Brushes.Cyan;
        private void DodgerBlue(object sender, RoutedEventArgs e) => kolor = Brushes.DodgerBlue;
        private void Blue(object sender, RoutedEventArgs e) => kolor = Brushes.Blue;
        private void DarkBlue(object sender, RoutedEventArgs e) => kolor = Brushes.DarkBlue;



        private void LightCoral(object sender, RoutedEventArgs e) => kolor = Brushes.LightCoral;
        private void OrangeRed(object sender, RoutedEventArgs e) => kolor = Brushes.OrangeRed;
        private void Crimson(object sender, RoutedEventArgs e) => kolor = Brushes.Crimson;
        private void Red(object sender, RoutedEventArgs e) => kolor = Brushes.Red;
        private void Firebrick(object sender, RoutedEventArgs e) => kolor = Brushes.Firebrick;
        private void DarkRed(object sender, RoutedEventArgs e) => kolor = Brushes.DarkRed;



        private void LightPink(object sender, RoutedEventArgs e) => kolor = Brushes.LightPink;
        private void Pink(object sender, RoutedEventArgs e) => kolor = Brushes.Pink;
        private void Violet(object sender, RoutedEventArgs e) => kolor = Brushes.Violet;
        private void Magenta(object sender, RoutedEventArgs e) => kolor = Brushes.Magenta;
        private void DarkOrchid(object sender, RoutedEventArgs e) => kolor = Brushes.DarkOrchid;
        private void Indigo(object sender, RoutedEventArgs e) => kolor = Brushes.Indigo;

    }
}