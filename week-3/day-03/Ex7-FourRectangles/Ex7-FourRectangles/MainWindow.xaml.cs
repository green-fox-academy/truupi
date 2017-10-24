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
using GreenFox;

namespace Ex7_FourRectangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double halfwidth = canvas.Width / 2;
            double halfheigth = canvas.Height / 2;
            double side = 50;

            foxDraw.FillColor(RandomColorGenerator());
            foxDraw.StrokeColor(RandomColorGenerator());
            foxDraw.DrawRectangle(halfwidth - side, halfheigth - side, side, side);
            foxDraw.FillColor(RandomColorGenerator());
            foxDraw.StrokeColor(RandomColorGenerator());
            foxDraw.DrawRectangle(halfwidth, halfheigth, side, side);
            foxDraw.FillColor(RandomColorGenerator());
            foxDraw.StrokeColor(RandomColorGenerator());
            foxDraw.DrawRectangle(halfwidth - side, halfheigth, side, side);
            foxDraw.FillColor(RandomColorGenerator());
            foxDraw.StrokeColor(RandomColorGenerator());
            foxDraw.DrawRectangle(halfwidth, halfheigth - side, side, side);
        }

        public static Color RandomColorGenerator()
        {
            var randomColor = Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256));
            return randomColor;
        }
    }
}
